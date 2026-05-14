# 🎰 Lotto Simulator

A desktop application that simulates lottery draws and shows how often you would have won — across hundreds of thousands of draws.

## What It Does

You enter your seven lucky numbers and choose how many draws to simulate. The app runs all of them and tells you exactly how many times you would have matched 5, 6, or 7 numbers.

- **Your numbers** — Enter a row of 7 unique numbers (between 1 and 35) as your lottery pick
- **Simulate draws** — Choose how many random draws to run — up to nearly a million
- **See your results** — Get a breakdown of how many draws gave you exactly 5, 6, or 7 correct matches
- **Input validation** — The app won't let you run a simulation unless your numbers and draw count are both valid, preventing confusing or misleading results

## Why I Built It

This was a school assignment about simulation and randomness. The interesting challenge wasn't just generating random numbers — it was doing it correctly and efficiently. Running a million lottery draws means the logic has to be both accurate and fast enough to finish in a reasonable time.

## What I Learned

This project taught me to think carefully about performance — naive approaches fall apart quickly at scale. I also had to handle a number of rules that aren't immediately obvious, like the fact that matching 7 numbers doesn't also count as a win for 5 or 6, and that the order of numbers in a row is irrelevant. Getting those details right is what separates a working program from a correct one.

## Project Status

Complete — submitted as part of a school assignment.

---

*Built by Salim — [LinkedIn](#) · [Portfolio](#)*
