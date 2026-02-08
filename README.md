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
- [ ] Question 4 - 
- [ ] Question 5 - 
- [ ] Question 6 - 

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


## ===== END =====