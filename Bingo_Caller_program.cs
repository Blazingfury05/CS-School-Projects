
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Random rng = new Random();

string[] gameModes =
{
    "Standard",
    "No Horizontal",
    "No Vertical",
    "No Diagonals",
    "Four Corners",
    "Blackout",
    "ONLY Horizontal",
    "ONLY Vertical",
    "ONLY Diagonals"
};

bool gameStarted = false;
bool hasEnded = false;

int gamemode = 1;
int boardtype = 1;

List<int> availableNumbers = new List<int>();
List<string> callHistory = new List<string>();

int? lastCalled = null;
string gametype = "Standard";

// Convert a number into its standard Bingo letter.
string GetLetter(int number)
{
    if (number <= 15)
    {
        return "B";
    }
    else if (number <= 30)
    {
        return "I";
    }
    else if (number <= 45)
    {
        return "N";
    }
    else if (number <= 60)
    {
        return "G";
    }
    else
    {
        return "O";
    }
}

// Package the current game information for the webpage.
object GetGameState()
{
    return new
    {
        gameStarted,
        hasEnded,
        gameType = gametype,
        boardType = boardtype,
        lastCalled = lastCalled.HasValue
            ? $"{GetLetter(lastCalled.Value)}-{lastCalled.Value}"
            : "--",
        numbersRemaining = availableNumbers.Count,
        gameOver = gameStarted && availableNumbers.Count == 0,
        history = callHistory.AsEnumerable()
            .Reverse()
            .Take(10)
            .ToArray()
    };
}

// Start a new game using the selected mode.
app.MapPost("/api/start/{mode:int}", (int mode) =>
{
    if (mode < 1 || mode > 9)
    {
        return Results.BadRequest(
            new { error = "Please select a game mode from 1 to 9." });
    }

    gamemode = mode;
    gametype = gameModes[mode - 1];

    // Only Four Corners and ONLY Diagonals use board type 2.
    boardtype = (mode == 5 || mode == 9) ? 2 : 1;

    availableNumbers.Clear();
    callHistory.Clear();
    lastCalled = null;

    // Fill the number pool according to the selected board.
    for (int number = 1; number <= 75; number++)
    {
        if (boardtype == 1 ||
            number <= 15 ||
            number >= 61)
        {
            availableNumbers.Add(number);
        }
    }

    gameStarted = true;
    hasEnded = false;

    return Results.Ok(GetGameState());
});

// Draw the next number.
app.MapPost("/api/next", () =>
{
    if (!gameStarted)
    {
        return Results.BadRequest(
            new { error = "Start a game before calling a number." });
    }

    if (availableNumbers.Count == 0)
    {
        return Results.Ok(GetGameState());
    }

    int index = rng.Next(availableNumbers.Count);

    lastCalled = availableNumbers[index];

    availableNumbers.Remove(lastCalled.Value);

    string call = $"{GetLetter(lastCalled.Value)}-{lastCalled.Value}";
    callHistory.Add(call);

    return Results.Ok(GetGameState());
});

// End the current game.
app.MapPost("/api/end", () =>
{
    gameStarted = false;
    hasEnded = true;

    return Results.Ok(GetGameState());
});

// Serve the webpage.
app.MapGet("/", () =>
{
    return Results.Content("""
        <!DOCTYPE html>
        <html lang="en">
        <head>
            <meta charset="utf-8">
            <meta name="viewport"
                  content="width=device-width, initial-scale=1">
            <title>Blaze's Bingo Caller</title>

            <style>
                * {
                    box-sizing: border-box;
                }

                body {
                    margin: 0;
                    min-height: 100vh;
                    padding: 24px;
                    background: #111827;
                    color: #f9fafb;
                    font-family: Arial, Helvetica, sans-serif;
                    text-align: center;
                }

                main {
                    width: 100%;
                    max-width: 1000px;
                    margin: 0 auto;
                }

                h1 {
                    margin: 8px 0 24px;
                    font-size: clamp(2rem, 5vw, 3.5rem);
                }

                .setup {
                    display: flex;
                    justify-content: center;
                    align-items: center;
                    flex-wrap: wrap;
                    gap: 12px;
                    margin-bottom: 24px;
                }

                select, button {
                    border: none;
                    border-radius: 10px;
                    padding: 14px 20px;
                    font-size: 1.1rem;
                    cursor: pointer;
                }

                select {
                    max-width: 100%;
                    background: white;
                    color: #111827;
                }

                button:disabled {
                    opacity: 0.4;
                    cursor: not-allowed;
                }

                .primary {
                    background: #2563eb;
                    color: white;
                    font-weight: bold;
                }

                .next {
                    width: 100%;
                    max-width: 500px;
                    padding: 20px;
                    font-size: 1.5rem;
                    background: #16a34a;
                    color: white;
                    font-weight: bold;
                }

                .end {
                    background: #374151;
                    color: white;
                }

                .number-panel {
                    margin: 20px auto;
                    padding: 20px 12px;
                    border: 2px solid #374151;
                    border-radius: 20px;
                    background: #1f2937;
                }

                .number {
                    font-size: clamp(6rem, 24vw, 15rem);
                    line-height: 1.05;
                    font-weight: 800;
                    letter-spacing: -4px;
                    overflow-wrap: anywhere;
                }

                .caption {
                    margin-top: 8px;
                    color: #d1d5db;
                    font-size: 1.1rem;
                }

                .status {
                    min-height: 1.6em;
                    margin: 16px 0;
                    font-size: 1.2rem;
                    color: #d1d5db;
                }

                .details {
                    display: flex;
                    justify-content: center;
                    flex-wrap: wrap;
                    gap: 12px 32px;
                    margin: 18px 0;
                    font-size: 1.15rem;
                }

                .history {
                    margin-top: 28px;
                    padding: 20px;
                    border-radius: 14px;
                    background: #1f2937;
                }

                .history h2 {
                    margin-top: 0;
                }

                .history-list {
                    display: flex;
                    justify-content: center;
                    flex-wrap: wrap;
                    gap: 10px;
                }

                .history-item {
                    padding: 10px 14px;
                    border-radius: 8px;
                    background: #374151;
                    font-size: 1.3rem;
                    font-weight: bold;
                }

                @media (max-width: 500px) {
                    body {
                        padding: 12px;
                    }

                    .number {
                        letter-spacing: -2px;
                    }

                    .setup > * {
                        width: 100%;
                    }
                }
            </style>
        </head>

        <body>
            <main>
                <h1>Blaze's Bingo Caller</h1>

                <div class="setup">
                    <select id="mode" aria-label="Select game mode">
                        <option value="1">Standard</option>
                        <option value="2">No Horizontal</option>
                        <option value="3">No Vertical</option>
                        <option value="4">No Diagonals</option>
                        <option value="5">Four Corners</option>
                        <option value="6">Blackout</option>
                        <option value="7">ONLY Horizontal</option>
                        <option value="8">ONLY Vertical</option>
                        <option value="9">ONLY Diagonals</option>
                    </select>

                    <button class="primary" id="startButton"
                            onclick="startGame()">
                        Start New Game
                    </button>
                </div>

                <div class="number-panel">
                    <div class="number" id="number">--</div>
                    <div class="caption">LAST NUMBER CALLED</div>
                </div>

                <div class="status" id="status" role="status"
                     aria-live="polite">
                    Choose a game mode and start a game.
                </div>

                <div class="details">
                    <div>Game: <strong id="gameType">None</strong></div>
                    <div>Board: <strong id="boardType">--</strong></div>
                    <div>Remaining: <strong id="remaining">--</strong></div>
                </div>

                <div>
                    <button class="next" id="nextButton"
                            onclick="nextNumber()" disabled>
                        CALL NEXT NUMBER
                    </button>
                </div>

                <div style="margin-top: 12px">
                    <button class="end" id="endButton"
                            onclick="endGame()" disabled>
                        End Game
                    </button>
                </div>

                <section class="history">
                    <h2>Recent Calls</h2>
                    <div class="history-list" id="history">
                        <span class="caption">No numbers called yet.</span>
                    </div>
                </section>
            </main>

            <script>
                async function request(url) {
                    const response = await fetch(url, {
                        method: "POST"
                    });

                    const data = await response.json();

                    if (!response.ok) {
                        throw new Error(data.error || "Request failed.");
                    }

                    return data;
                }

                function showError(error) {
                    document.getElementById("status").textContent =
                        "Error: " + error.message;
                }

                function render(state) {
                    document.getElementById("number").textContent =
                        state.lastCalled;

                    document.getElementById("gameType").textContent =
                        state.gameType;

                    document.getElementById("boardType").textContent =
                        state.boardType;

                    document.getElementById("remaining").textContent =
                        state.gameStarted || state.hasEnded
                            ? state.numbersRemaining
                            : "--";

                    const status = document.getElementById("status");

                    if (state.gameOver) {
                        status.textContent =
                            "All available numbers have been called!";
                    } else if (state.hasEnded) {
                        status.textContent = "Game ended.";
                    } else if (state.gameStarted) {
                        status.textContent = "Game in progress.";
                    } else {
                        status.textContent =
                            "Choose a game mode and start a game.";
                    }

                    document.getElementById("nextButton").disabled =
                        !state.gameStarted || state.gameOver;

                    document.getElementById("endButton").disabled =
                        !state.gameStarted;

                    const history = document.getElementById("history");
                    history.replaceChildren();

                    if (state.history.length === 0) {
                        const empty = document.createElement("span");
                        empty.className = "caption";
                        empty.textContent = "No numbers called yet.";
                        history.appendChild(empty);
                    } else {
                        for (const call of state.history) {
                            const item = document.createElement("span");
                            item.className = "history-item";
                            item.textContent = call;
                            history.appendChild(item);
                        }
                    }
                }

                async function startGame() {
                    try {
                        const mode = document.getElementById("mode").value;
                        const state = await request("/api/start/" + mode);
                        render(state);
                    } catch (error) {
                        showError(error);
                    }
                }

                async function nextNumber() {
                    try {
                        const state = await request("/api/next");
                        render(state);
                    } catch (error) {
                        showError(error);
                    }
                }

                async function endGame() {
                    try {
                        const state = await request("/api/end");
                        render(state);
                    } catch (error) {
                        showError(error);
                    }
                }
            </script>
        </body>
        </html>
        """, "text/html");
});

app.Run();
