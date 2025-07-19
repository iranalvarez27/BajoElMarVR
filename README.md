# 🌊 Bajo El Mar - Aplicación de Realidad Virtual para la Conservación Marina

![Unity](https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white) 
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) 
![VR](https://img.shields.io/badge/VR-MetaQuest-5D8AA8?style=for-the-badge&logo=oculus&logoColor=white) 
![Blender](https://img.shields.io/badge/Blender-F5792A?style=for-the-badge&logo=blender&logoColor=white)

---

## 👩🧔‍♂️ Integrantes

- Nicol Anccana Llanto  
- Harold Canto Vidal  
- Irán María Alvarez Flores  
- Luis Fernando Izaguirre Zavaleta  

---

## 📌 Introducción

**Bajo El Mar** es una aplicación de **Realidad Virtual (VR)** desarrollada con Unity, enfocada en la **educación ambiental y la conservación marina**. A través de una experiencia inmersiva, los usuarios navegan por túneles submarinos y entornos interactivos donde pueden conocer **especies marinas protegidas del Perú**, identificar su normativa legal y reflexionar sobre la importancia de preservar el ecosistema marino.

Dirigida a:

- 👨‍🏫 **Educadores y estudiantes**
- 🐟 **Niños y jóvenes curiosos**
- 🌍 **Público general interesado en la biodiversidad marina**

---

## 🎯 Objetivos del Proyecto

- Fomentar la conciencia ecológica sobre especies marinas protegidas.  
- Usar la Realidad Virtual como recurso pedagógico accesible y envolvente.  
- Simular un entorno marino donde el usuario interactúe, aprenda y explore.  
- Integrar normativa oficial (PRODUCE) sobre conservación de especies.

---

## 🚀 Funcionalidades Principales

- 🛶 Navegación en bote con joystick o teletransporte en un entorno acuático.  
- 🐠 Observación de modelos 3D animados de especies marinas protegidas.  
- 🗂️ Visualización de nombre y normativa legal asociada a cada especie.  
- 📜 Túneles informativos con banners y tutorial de navegación.  
- 🔊 Música ambiental para mayor inmersión.  
- 🧾 Banners digitales llamativos de las especies presentadas.

---

## 🛠️ Tecnologías Utilizadas

- **Unity Engine + XR Toolkit**: Desarrollo de entornos VR para Meta Quest.  
- **C#**: Programación de interacción y navegación.  
- **OVR Camera Rig / TeleportHotspot / Hand Grab**: Funciones de locomoción e interacción en VR.  
- **Blender + Meshy AI**: Modelado, rigging y animación de peces.  
- **Canva**: Diseño de UI y banners informativos.  
- **Meta XR Simulator**: Testing sin visor físico.  

---

## 🎨 Diseño y Usabilidad

- Interfaz minimalista y amigable, pensada para niños y adultos.  
- Sistema de botones simples e intuitivos.  
- Tutorial integrado en la escena inicial para guiar al usuario.  
- Información educativa clara, accesible mediante banners.  
- Ambientación sonora envolvente para reforzar la inmersión.

---

## 🧭 Flujo de la Experiencia

1. **Inicio**: Pantalla principal con botón de inicio.  
2. **Túnel informativo**: Instrucciones, controles y objetivos de la app.  
3. **Exploración en bote**: Recorrido libre con observación de especies protegidas.  
4. **Segundo túnel**: Reforzamiento de información mediante banners visuales.  
5. **Cierre**: Mensaje de agradecimiento y reflexión final.

---

## 📂 Estructura del Proyecto

```plaintext
/Assets
├── /Prefabs        # Modelos 3D de especies marinas en formato FBX
├── /Scripts        # Lógica en C# (interacción, movimiento, menú)
├── /UI             # Elementos de interfaz (botones, iconos, pantallas)
├── /Audio          # Música ambiental y efectos
└── /Scenes         # Inicio, Túneles, Exploración principal
```

---

## 📈 Impacto y Futuras Mejoras

- 🧠 Aprendizaje significativo sobre la biodiversidad marina del Perú.  
- 🎓 Herramienta educativa para colegios, museos y ferias ambientales.  
- Próximas mejoras:
  - ✨ Feedback háptico y sonido 3D envolvente.  
  - 🐋 Ampliación del catálogo de especies.  
  - 🧭 Modo guiado por voz o asistente virtual interactivo.  
  - 💡 Implementación de retos o logros gamificados.

---

## 🧪 Instalación y Ejecución

Para ejecutar correctamente la aplicación **Bajo El Mar**, asegúrate de cumplir con los siguientes pasos:

1. **Requisitos previos**:
   - Unity 2022 o versión compatible con XR Toolkit y OVR Plugin.
   - Dispositivo Meta Quest 2 o superior (opcional para pruebas reales).
   - Meta XR Plugin instalado en Unity.

2. **Escenas necesarias**:
   - Asegúrate de que las siguientes escenas estén añadidas en el *Build Settings*:
     - `MenuPrincipal`
     - `Escena1`
     - `Escena2`
     - `Escena3`

3. **Ejecución**:
   - Abrir el proyecto en Unity.
   - Configurar el XR Plugin Management en modo Oculus.
   - Verificar que las escenas mencionadas están en el orden correcto.
   - Ejecutar el proyecto desde Unity o compilar para Meta Quest desde la opción `Build and Run`.

---

## 📲 Link del APK

Puedes descargar el archivo APK de la aplicación **Bajo El Mar** desde el siguiente enlace de Google Drive:

🔗 [Descargar APK](https://drive.google.com/drive/folders/15Al8X5eeos1KSCQWYK1funmX59YezexH)

---

## 📚 Referencias

- Ministerio de la Producción del Perú (PRODUCE)  
- Decreto Supremo Nº 012-2001-PE  
- Majluf, S. (2024). Pesca artesanal en Perú y sostenibilidad marina  
- Meshy AI, Meta XR Toolkit, Unity Docs  
- https://www.actualidadambiental.pe  
- https://cdn.www.gob.pe
