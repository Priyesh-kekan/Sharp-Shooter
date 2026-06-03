# 🚀 Space Shooter — Multi-Stage Action FPS (Unity)

> **Space Shooter** is a 3-stage first-person action game built in Unity featuring AI-driven enemies, weapon systems, pickup mechanics, maze exploration, and aim-training gameplay. Each stage offers unique mechanics such as bot tracking, maze traps, teleporters, gun pickups, and a training island.

---


## 📥 Download Project

Download the complete project here:

[SpaceShooter.zip](./SpaceShooter.zip)


---

## 📸 Game Preview

**Spawn Area**
<img width="1919" height="1079" alt="Screenshot 2026-06-03 175752" src="https://github.com/user-attachments/assets/078beb8d-f3e8-49d3-999b-284d3da389fb" />


**Arena Stage Screenshot**
<img width="1919" height="1079" alt="Screenshot 2026-06-03 175830" src="https://github.com/user-attachments/assets/55382b32-7d52-4b09-a9ad-f9981db9ad0c" />
<img width="1919" height="1079" alt="Screenshot 2026-06-03 175853" src="https://github.com/user-attachments/assets/c64e61a7-a483-4d21-8281-6f2bc5abadcd" />


**Maze Stage Screenshot**
<img width="1919" height="1079" alt="Screenshot 2026-06-03 175947" src="https://github.com/user-attachments/assets/7cf5094b-a95a-404f-afcc-510fc8531e0d" />


**Aim Training Screenshot**
<img width="1919" height="1079" alt="Screenshot 2026-06-03 180857" src="https://github.com/user-attachments/assets/faf118c4-13c7-46b7-9a4e-668a2372526e" />
<img width="1919" height="1079" alt="Screenshot 2026-06-03 180955" src="https://github.com/user-attachments/assets/4a9e7d1b-d6e8-410f-9ce9-6adf7abf6fe5" />

---

## 🎮 Game Overview (3 Stages)

### **1️⃣ Arena — Survival Combat**

* Robots (enemy bots) track and attack the player from anywhere on the map.
* Multiple guns spawn at different locations.
* Ammo pickup boxes available.
* Fast-paced FPS combat with raycast shooting.

### **2️⃣ Maze — Teleporter Escape Challenge**

* Player must navigate a maze to find the **correct teleporter**.
* Maze contains **traps** and **proximity-based robots**.
* Robots attack only if the player enters their detection radius.
* High tension, exploration-focused gameplay.

### **3️⃣ Aim Training Island**

* Different guns spawn on the island.
* Player can practice aiming and shoot targets.
* Teleporter brings player back to the main spawn island.
* Designed for weapon testing and skill building.

---

## 🧠 Gameplay Systems

### 🔹 Enemy AI

* NavMesh-based movement
* Full tracking in Arena
* Radius-based detection in Maze
* Health + self-destruct mechanics

### 🔹 Weapon System

* Multiple guns (pistol, machine gun, sniper)
* Scriptable Objects for stats
* Shooting cooldown
* Muzzle + hit FX
* Gun switching & pickups
* Ammo system + pickup boxes

### 🔹 Maze / Teleporter System

* Player must locate correct teleporter
* Wrong teleporters return to danger zones
* Traps & AI robots inside maze

### 🔹 Aim Training

* Targets for practice
* Guns spawn on platform
* Teleport back to main island

---

## 🛠️ Tech Stack

* **Unity Engine**
* **C#**
* **NavMesh / AI Agents**
* **Scriptable Objects**
* **ProBuilder**
* **Particle FX**

---

## 🚀 How to Run the Project

1. Clone or download the project.
2. Open in **Unity 2021+** (or your project version).
3. Ensure NavMeshComponents package is installed.
4. Press **Play** and choose the stage.
