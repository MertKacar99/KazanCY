# Project Description

 A comprehensive quiz project featuring Yaz Kazan (open-ended) and Çoktan Kazandım (multiple-choice) games, along with an integrated admin panel for managing questions and viewing statistics.

## Components

### 1. Yaz Kazan Quiz Game

**Yaz Kazan** is an open-ended quiz game with the following features:

- **Player Input**: The game starts by capturing the player's name.
- **Difficulty Levels**: Includes 11 distinct difficulty levels.
- **Answer Attempts**: Players have three attempts to answer each question correctly.
- **Time Limit**: Each question has a 30-second time limit.
- **Random Questions**: Questions are randomly selected from pools specific to each difficulty level.
- **Answer Validation**: Answers are validated logically, with no case sensitivity.
- **Scoring and Leaderboard**: After the game ends (due to time expiration, an incorrect answer, or winning the grand prize), a scoreboard displays player rankings based on earnings and total playtime. Players with the same earnings are ranked by shortest playtime. Multiple plays by the same player are tracked, showing their best score.

### 2. Çoktan Kazandım Quiz Game

**Çoktan Kazandım** is a multiple-choice quiz game with:

- **Player Input**: Players provide their full name at the start.
- **Difficulty Levels**: Features 11 distinct difficulty levels.
- **Question Pools**: Each level has its own question pool.
- **Random Questions**: Questions and answer choices are randomly presented.
- **Time Limit**: Questions are subject to time constraints.

### 3. Admin Panel

The **Admin Panel** offers management features, including:

- **Unique Admin Code**: Each admin has a unique eight-character code (e.g., `#1234567`).
- **Admin Access**: Admins can enter their unique code at the game selection screen to access the admin login. Each code is assigned to only one admin for security purposes. Admins log in with a username and password.
- **Game Management**: Admins can add, update, or delete questions in the database for both games. The system supports seamless updates across both games with a single action.
- **Statistics**: Includes a statistics section where error rates for each level are graphically displayed. Admins can convert these graphs to text and view detailed statistics, including which questions within a level are most error-prone.

**Note**: Due to the presence of an admin panel, voice-over functionality for questions was not implemented to avoid complexity. However, the project is modular, and integrating a speech library for English content is feasible with minimal code adjustments.

---

For more details or to contribute to the project, please refer to the documentation provided in the respective directories of this repository.

