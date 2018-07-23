# Rover
Welcome to MARS program!!!

Instruction:
Configure input file path in the app.config file, eg. <add key ="filePath" value="C:\\temp\\Input.txt"/>
And you are ready to go!! (Don't change the key name "filePath")

Assumptions:
X,Y Co-ordinates supplied will have same no. of digits . eg. 77 (meaning 7,7) or 1010 (10,10)
Wrong data - 105  (10,5) 
Right Data - 1005 (10,05)

Correctness:
7 Unit Tests make sure basic rover operations run correctly.

Design Considerations:
 - Reusable Interface IRover defines basic rover operations
 - Abstract class Rover implements it along with required data members
 - Abstract class Rover can be inherited to have different variations of Rover
 - static FileParser and Rover Helper classes can be reused elsewhere


