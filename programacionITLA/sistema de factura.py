Refrescos = 30
Refresco = 30
Galletas = 15
Galleta = 15
Pan = 10
Total_factura = 0
while True:
    producto = input("ingrese el producto: "). strip(). lower()
    cantidad = int(input("ingrese la cantidad: "))   
    print("ingrese el producto")
    subtotal = 0
    if producto == "refrescos" :
     subtotal = Refrescos * cantidad
    elif (producto == "galletas")  or (Galleta):
     subtotal = Galletas * cantidad
    elif producto == "Pan" :
     subtotal = Pan * cantidad
    else: 
      print("producto no registrado, vuelva a intentarlo")
    if subtotal > 0:
      print(f"subtotal por este producto: {subtotal}") 
      Total_factura = Total_factura + subtotal
    solo_eso = input("solo eso? (si/no)"). strip(). lower()
    if solo_eso == "si":
      print("-" * 30)
      print(f"FACTURA FINAL: total a pagar {Total_factura}")
      print("-" * 30)
      break