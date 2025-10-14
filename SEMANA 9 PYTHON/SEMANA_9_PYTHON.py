from TRIANGULO import TRIANGULO
from CUADRADO import CUADRADO
t = TRIANGULO()
c = CUADRADO()

def menu1()->None:
    print("BIENVENIDOS A CALCULOS DE AREAS Y PERIMETROS\n")
    print("***********menu de opciones***********")
    print("*           1. triangulo           *")
    print("*           2. cuadrado            *")
    print("*           3. rectangulo          *")
    print("*           4. trapecio            *")
    print("*           0. salir               *")
    print("************************************")
    
def menu2()->int:
        print ("****seleccione calculo****")
        print ("*            1. Area            *")
        print ("*            2. Perimetro            *")
        print ("************************************\n")

        opcion = int(input("Ingrese una opcion: "))
        return opcion

while True:
    menu1()
    while True: 
        opcion = int(input("Ingrese opcion: "))

        if opcion in (0,1,2,3,4): break
        else: print ("Error. Opcion no valida.\n")
            
    match opcion:
        case 0: exit() #quit()
        case 1: 
            opc = menu2()

            match opc:
                case 1: t.area()
                case 2: t.perimetro()

        case 2:
            opc = menu2()
            l= int(input("Ingrese lado: "))
            match opc:
                case 1: c.area(l);
                case 2: c. perimetro(l);
        case 3: print()
        case 4: print()

    while True: 
        conti = input("¿Desea continuar..? (s/n): ")
        if conti in("s", "n"): break
        else: print ("Error. Solo ingrese 's' o 'n'.")

        if conti == "n": break

