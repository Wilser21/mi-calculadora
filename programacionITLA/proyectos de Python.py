num1 = float(input("escribe el primer numero: "))
num2 = float(input("escribe el segundo numero:"))
operacion = input("Escribe +,-,* o /: ")
if operacion == "+":
    print("Resultado:", num1 + num2)
elif operacion == "-": 
    print("Resultado:", num1 - num2)
elif operacion == "*":
    print("resultado:", num1 * num2)
elif operacion == "/":
    if num2 != 0:
        print("Resultado:", num1 / num2)
    else:
        print("no se puede dividir entre 0")
else:
    print("operacion no valida")