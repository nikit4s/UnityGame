# 💀 Scully

> *The dead don't rest. Neither does he.*

**Scully** is a 2D dungeon crawler built in Unity where you play as an animated skeleton warrior on a relentless mission through cursed dungeons. Fight through waves of enemies, dodge deadly traps, unlock hidden rooms, and battle your way to the final boss — all as the rattling, blade-wielding Scully.

---

## 🎮 Gameplay Overview

You control **Scully**, a 2D animated skeleton brought back from the dead with one purpose: fight his way through the dungeon and destroy whatever lies at the end.

- ⚔️ **Kill mobs** — Encounter a variety of enemies that grow stronger as you progress deeper
- 🪤 **Avoid traps** — Navigate spike pits, swinging blades, pressure plates, and more
- 🔐 **Unlock new rooms** — Discover keys, levers, and secrets that open the path forward
- 👹 **Defeat the Final Boss** — Survive long enough and face the ultimate challenge waiting at the dungeon's end

---

## ✨ Features

- 🦴 Fluid 2D skeleton character animation with a unique, expressive style
- 🏰 Procedurally influenced dungeon layouts with hand-crafted room encounters
- 🗡️ Melee combat system with attack combos and dodge mechanics
- 💀 Variety of enemy mobs, each with unique behavior patterns
- 🔦 Atmospheric pixel art visuals with dynamic lighting
- 🎵 Immersive dungeon soundtrack and sound effects
- 💾 Save system with checkpoint rooms

---

## 🛠️ Built With

- **Engine**: [Unity](https://unity.com/) (version 2021.3)
- **Language**: C#
- **Art Style**: 2D Pixel Art
- **Physics**: Unity 2D Physics

---

## 🚀 Getting Started

### Prerequisites

- Unity Editor **2021.3 LTS** or newer
- Git (to clone the repository)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/scully.git
   ```

2. **Open in Unity**
   - Launch **Unity Hub**
   - Click **Open** → navigate to the cloned folder
   - Select the project and open it

3. **Load the main scene**
   - In the Project window, navigate to `Assets/Scenes/`
   - Open `MainMenu.unity` or `Level_01.unity` to start playing

4. **Press Play** ▶️

---

## 🗂️ Project Structure

```
Assets/
├── Animations/       # Scully and enemy animation controllers
├── Art/              # Sprites, tilesets, and UI assets
├── Audio/            # Music and sound effects
├── Prefabs/          # Reusable game objects (enemies, traps, doors)
├── Scenes/           # Game scenes and levels
├── Scripts/
│   ├── Player/       # Scully's movement, combat, health
│   ├── Enemies/      # Enemy AI and behavior
│   ├── Traps/        # Trap logic and triggers
│   ├── Dungeon/      # Room management and unlocking
│   └── UI/           # HUD, menus, and overlays
└── Tilemaps/         # Dungeon tilemap assets
```

---

## 🎯 Controls

| Action        | Key / Button         |
|---------------|----------------------|
| Move          | `WASD` / Arrow Keys  |
| Attack        | `Left Click`         |
| Dodge / Roll  | `Space`              |
| Interact      | `E`                  |
| Pause         | `Escape`             |

---

## 🗺️ Roadmap

- [x] Core player movement and animation
- [x] Basic melee combat
- [x] First dungeon level
- [ ] Multiple enemy types
- [ ] Trap variety and puzzle rooms
- [ ] Boss encounter(s)
- [ ] Sound design and music
- [ ] Main menu and UI polish
- [ ] Gamepad support

---

## 🤝 Contributing

Contributions are welcome! If you'd like to help build Scully:

1. Fork the repository
2. Create a new branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature/your-feature`)
5. Open a Pull Request

Please follow the existing code style and include comments where appropriate.

---

## 👤 Author

Made by **Nikitas Savva & Demetris Nearchou**

---
