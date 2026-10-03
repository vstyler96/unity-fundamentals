# My project

Pequeño juego 3D hecho en Unity: controlas a un jugador que empuja una pelota con física hacia una portería. Cada gol suma un punto al marcador.

## Requisitos

- Unity **6000.6.0f1** (Unity 6)
- Universal Render Pipeline (URP) 17.6
- Input System 1.20

## Cómo ejecutarlo

1. Clona el repositorio.
2. Abre la carpeta del proyecto con Unity Hub usando la versión indicada arriba.
3. Abre la escena `Assets/Scenes/SampleScene.unity`.
4. Pulsa **Play**.

## Controles

| Acción | Teclado | Mando |
|--------|---------|-------|
| Moverse | WASD / flechas | Stick izquierdo |

## Estructura

```
Assets/
├── Materials/   Materiales (pelota, suelo, madera) y material físico rebotante
├── Prefab/      Prefabs de Player, Ball y Goal
├── Scenes/      SampleScene, la escena principal
├── Scripts/     Lógica del juego
├── Settings/    Configuración de URP (PC y móvil)
└── Textures/    Texturas PBR 4K
```

### Scripts

- **`Player.cs`**: Rigidbody simple que mueve al jugador.
- **`Ball.cs`**: la pelota; `ResetPhysics()` la detiene y la devuelve al centro (sin uso actualmente).
- **`Goal.cs`**: al entrar un objeto con la etiqueta `Ball` en el trigger, suma un punto al jugador y actualiza el texto del marcador.

## Licencia

Este proyecto se distribuye bajo la licencia [GNU Affero General Public License v3.0](LICENSE).
