import os

def FizzBuzz_Worst():
    for i in range(1,101):
        if(((i % 3) == 0) and ((i % 5) == 0)):
            print("FizzBuzz")
        elif((i % 5) == 0):
            print("Buzz")
        elif((i % 3) == 0):
            print("Fizz")
        else:
            print(i)
    if os.name == 'nt':
        os.system('pause')
    else:
        os.system("""bash -c 'read -s -n 1 -p "Press any key to continue"'""")
        print()
            
def FizzBuzz_Better():
    x = 3
    y = 5
    for i in range(1,101):
        output = ""
        if((i % x) == 0):
            output += "Fizz"
        if((i % y) == 0):
            output += "Buzz"
        if(output == ""):
            output = i
        print(output)
    if os.name == 'nt':
        os.system('pause')
    else:
        os.system("""bash -c 'read -s -n 1 -p "Press any key to continue"'""")
        print()

def FizzBuzz_Best():
    numbers = [3, 5] 
    words = ["Fizz", "Buzz"]
    for i in range(1,101):
        output = ""
        for j,s in zip(numbers,words):
            if((i % j) == 0):
                output += s
        if(output == ""):
            output = i
        print(output)
    if os.name == 'nt':
        os.system('pause')
    else:
        os.system("""bash -c 'read -s -n 1 -p "Press any key to continue"'""")
        print()

if __name__ == "__main__":
    while(True):
        selected = input("Please enter 1 for FizzBuzz with hardcoded values\nPlease enter 2 for FizzBuzz with variables\nPlease enter 3 for FizzBuzz with arrays\nPlease enter anything else to exit the program\n")
        if selected == "1":
            FizzBuzz_Worst()
        elif selected == "2":
            FizzBuzz_Better()
        elif selected == "3":
            FizzBuzz_Best()
        else:
            exit(0)