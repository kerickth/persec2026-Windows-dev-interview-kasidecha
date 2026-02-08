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
- [ ] Question 2 – 
- [ ] Question 3 - 
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

# ===== END =====