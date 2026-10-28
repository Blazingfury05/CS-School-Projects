import random

import turtle

joker_card = False

suits = ["♥", "♠", "♦", "♣"]

ranks = [
    "Ace", "2", "3", "4", "5", "6", "7",
    "8", "9", "10", "Jack", "Queen", "King"
]

cards = []

for card_value in ranks:
    for suit in suits:
        cards.append([card_value, suit])

if joker_card:
    cards.append(["Joker", "★"])
    cards.append(["Joker", "★"])

random.shuffle(cards)

print(cards)
print("Total cards:", len(cards))

gamemode = int(input("How many human players? "))

players = []
if len(players) < 4:
    players.append("CPU")


for player_number in range(gamemode):
    name = input(f"Who is Player {player_number + 1}?\n")
    players.append(name)
    print("players")


player_hands = [[], [], [], []]
print(players)