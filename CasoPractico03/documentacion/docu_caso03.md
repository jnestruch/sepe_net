## Caso Práctico 3
***

A continuación se muestra el código utilizado para esta práctica junto con el formulario final.

Captura del formulario resultante:
<br>![example outputimage](captura_output.png "n exemplary image")

<br><br>
### Formulario: Objetos incluidos
<br><br>

 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Form | 
**Propiedades:** | Name | Form1
| | Text | Curso VB'.Net - Tarea 3
| | Font | Microsoft Sans Serif; 9pt

<br><br>

 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Label | 
**Propiedades:** | Name | Label1
| | Text | Escribe tu nombre
| | Font | Microsoft Sans Serif; 9pt
----
<br><br>
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | TextBox | 
**Propiedades:** | Name | TextBox1
| | Text | 
| | Font | Microsoft Sans Serif; 9pt
| | ForeColor | Black
----
<br><br>
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Label | 
**Propiedades:** | Name | Label2
| | Text | Tipo de letra
| | Font | Microsoft Sans Serif; 9pt
----
<br><br>
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Label | 
**Propiedades:** | Name | Label3
| | Text | Formato
| | Font | Microsoft Sans Serif; 9pt
----
<br><br>
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Label | 
**Propiedades:** | Name | Label4
| | Text | Color
| | Font | Microsoft Sans Serif; 9pt
----
<br><br>
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Label | 
**Propiedades:** | Name | Label5
| | Text | Tamaño
| | Font | Microsoft Sans Serif; 9pt
----
<br><br>
----
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | RadioButton | 
**Propiedades:** | Name | RadioButton1
| | Text | Mistral
**Evento:** | CheckedChanged | Radiobutton1_CheckedChanged
**Codigo:** |
~~~vbnet
    TextBox1.Font = New Font(RadioButton1.Text, TextBox1.Font.Size, TextBox1.Font.Style)
~~~
---
<br><br>
----
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | RadioButton | 
**Propiedades:** | Name | RadioButton2
| | Text | Tahoma
**Evento:** | CheckedChanged | Radiobutton2_CheckedChanged
**Codigo:** |
~~~vbnet
    TextBox1.Font = New Font(RadioButton2.Text, TextBox1.Font.Size, TextBox1.Font.Style)
~~~
<br><br>
----
 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | RadioButton | 
**Propiedades:** | Name | RadioButton3
| | Text | Verdana
**Evento:** | CheckedChanged | Radiobutton3_CheckedChanged
**Codigo:** |
~~~vbnet
    TextBox1.Font = New Font(RadioButton3.Text, TextBox1.Font.Size, TextBox1.Font.Style)
~~~
<br><br>
----

 | | Nombre | Valor |
 --- | --- | ---
**Objeto:** | Button | 
**Propiedades:** | Name | Button1
| | Text | Salir
**Evento:** | Click | Button1_Click
**Codigo:** |
~~~vbnet
    Me.Close()
~~~
<br>El código del programa se puede descargar desde [aquí](https://github.com/jnestruch/sepe_net/blob/master/CasoPractico02/casopractico02/Program.vb).