import random
from statistics import mode

array = []
valor = int(input("Ingrese el numero \n"))

for i in range(valor):
    dado1 = random.randint(1, 6)
    dado2 = random.randint(1, 6)
    print("El dado1 {} y el dado2 {}".format(dado1, dado2))
    result = dado1 + dado2
    array.append(result)
    print("La suma de los dados es :", result)
    print("------")


print(array)
print("El resultado de la suma que mas se repite es: ", max(array, key=array.count))
print("El resultado de la suma que mas se repite es: ", mode(array))
