# Guess-Game
# 🎯 Guess Game (숫자 맞추기 게임)

## 📌 Overview (개요)

This is a simple console-based number guessing game written in C#.
사용자가 숫자를 맞추는 간단한 콘솔 게임입니다.

---

## 🕹️ How It Works (작동 방식)

* The program generates a random number between 1 and 100.
  프로그램은 1~100 사이의 랜덤 숫자를 생성합니다.

* The player tries to guess the number.
  사용자는 숫자를 맞추려고 시도합니다.

* The program gives hints:

  * "Too low" → 숫자가 작음
  * "Too high" → 숫자가 큼

* The player has **3 attempts**.
  총 **3번의 기회**가 주어집니다.

* If the player fails, the correct answer is revealed.
  실패 시 정답이 공개됩니다.

* After each game, the player can choose to restart.
  게임 종료 후 재시작 여부를 선택할 수 있습니다.

---

## ⚙️ Key Features (주요 기능)

* Random number generation (`Random.Next`)
* Input handling (`Console.ReadLine`)
* Game loop using `while`
* Recursive input validation (y/n 확인)
* Attempt limit system (3 tries)

---

## 🧠 Code Explanation (코드 설명)

### 🔹 GameDone() 함수

* Asks the user if they want to play again
* y → restart
* n → exit
* Invalid input → asks again (recursion)

👉 게임 재시작 여부를 확인하는 함수
👉 잘못된 입력 시 다시 물어봄

---

### 🔹 Main() 함수

* Generates random number
* Controls game loop
* Checks user input
* Handles win/lose conditions

👉 게임의 핵심 로직이 들어있는 부분

---

## 🚀 Example Output (실행 예시)

Guess a number between 1 and 100:
50
Too low! Try again.
75
Too high! Try again.
63
Congratulations! You guessed the number!

---

## 🛠️ Tech Stack

* Language: C#
* Platform: .NET Console Application

---

## 📎 Author

* GitHub: https://github.com/leejonin

---

## 📌 Improvement Ideas (개선 아이디어)

* Add difficulty levels (easy/normal/hard)

* 난이도 추가

* Track number of attempts

* 시도 횟수 기록

* Add UI (WinForms / Unity)

* UI 확장

---
