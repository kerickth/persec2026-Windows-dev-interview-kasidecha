# InterviewCoding
## Project Structure
CodingTest.sln  
│  
├─ src  
│   ├─ Question1      # Business logic   
│   ├─ Question2  
│   └─ ...  
│  
├─ tests  
│   ├─ Question1.Test # Console app to test case input/output  
│   ├─ Question2.Test  
│   └─ ...  

## How to Run
1. Open `InterviewCoding.sln` in Visual Studio
2. Set the desired `*.Test` project as **Startup Project**
3. Press **F5** to run
4. Input and output will be displayed in the console

## Status
- [x] Question 1 – Bracket validation
- [x] Question 2 – Custom string sorting
- [x] Question 3 - Autocomplete
- [x] Question 4 - Modern Roman Numerals
- [x] Question 5 - Digit Sorting
- [x] Question 6 - Tribonacci Sequence

## Question 1 – Bracket Validation
### Description
A string is considered valid if:
- Every opening bracket has a corresponding closing bracket
- Brackets are closed in the correct order
- Supported brackets: `()`, `{}`, `[]`

### Test Cases
() => True  
()[]{} => True  
(] => False  
([)] => False  
{[]} => True  

## Question 2 – String Sorting
### Description
Sort an array of strings by:
1. Prefix (alphabetical order)
2. Numeric value (ascending)
3. Suffix (alphabetical order)

### Test Cases
Input : [TH19, SG20, TH2]  
Output : [SG20, TH2, TH19]  

Input : [TH10, TH3Netflix, TH1, TH7]  
Output : [TH1, TH3Netflix, TH7, TH10]  

## Question 3 – Autocomplete
### Description
Return autocomplete results from a list of strings by:
1.Case-insensitive search
2.Matching items that contain the search keyword
3.Sorting by keyword position: [Beginning, Middle, End]
4.Limit results by maxResult

### Test Cases
Input : [Mother, Think, Worthy, Apple, Android]  
Search : th  
MaxResult : 2  
Output: [Think, Mother]  

## Question 4 - Modern Roman Numerals
### Description
Convert numbers between Integer and Roman Numerals.
Support symbols: I, V, X, L, C, D, M
Support subtractive notation (e.g. IV, IX, CM)
Implement 2 functions:
1.IntToRoman(int number) -> string
2.RomanToInt(string roman) -> int

### Test Cases
Input  : 1989
Output : MCMLXXXIX

Input  : 2000
Output : MM

Input  : 68
Output : LXVIII

Input  : 109
Output : CIX

Input  : MCMXXXIX
Output : 1939

Input  : MM
Output : 2000

Input  : LXVIII
Output : 68

Input  : CIX
Output : 109

## Question 5 – Digit Sorting
### Description
Reorder digits of a positive integer from highest to lowest and return as an integer.

### Test Cases
3008 → 8300  
1989 → 9981  
2679 → 9762  
9163 → 9631

## Question 6 – Tribonacci
### Description
Generate Tribonacci sequence using up to 3 initial values.
Each new value is the sum of the previous 3 values.

### Test Cases
Input: f([1, 3, 5],5)  => Output: [1, 3, 5, 9, 17]  
Input: f([2, 2, 2],3)  => Output: [2, 2, 2]  
Input: f([10, 10, 10],4)  => Output: [10, 10, 10, 30]  

## ===== END =====