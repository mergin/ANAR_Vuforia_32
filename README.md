## Sinopsis

Este es un proyecto de realidad aumentada desarrollado usando Vuforia. La intención de este proyecto es que sea desplegable a la mayor cantidad de plataformas posibles, incluyendo Windows y Linux.

Los modelos 3D son de alta calidad y resultan muy pesados para dispositivos móviles.


## Ejemplo de Código

Los recursos del proyecto están disptribuidos en sub carpetas de Assets:

- Icons: Imagenes usadas como íconos en los botones.
- Materials: Las texturas usadas por los modelos.
- Models: Los modelos usados en el proyecto. Las figuras rupestres están en formato OBJ y los mapas en formato FBX exportados de Maya.
- Questions: Las preguntas usadas en el proyecto, consisten en archivos PNG. Una por cada modelo.
- Scripts: El código desarrollado para cumplir con los requerimientos particulares del proyecto.
	- **GlowingColors.cs** 
	Para resaltar los colores de los estados de los mapas, donde se encuentra el arte rupestre.
	- **RotateVirtualButtonEventHandler.cs**
	Para rotar los modelos. Actualmente no se utiliza.
	- **UserInterfaceButtons.cs**
	Para controlar el manejo de los botones virtuales de cada target del proyecto. Se usa agrega una instancia de este script a cada target.
- Sounds: Los sonidos usados en el proyecto en formato OGG.


## Motivación

Este proyecto fue creado como parte del servicio comunitario de la Universidad Simón Bolivar para el ANAR (Archivo Nacional de Arte Rupestre).


## Instalación

Clonar el proyecto y abrir con **Unity Editor de 32 bits**. La librería de Vuforia 5.5.9 ya está incluida.

Este proyecto fue creado con Unity 5.3.5f1 de 32-bit para Windows.


## Colaboradores

[David Prieto](https://github.com/mergin)
