# 🚀 Space Shooter — Multi-Stage Action FPS (Unity)

> **Space Shooter** is a 3-stage first-person action game built in Unity featuring AI-driven enemies, weapon systems, pickup mechanics, maze exploration, and aim-training gameplay. Each stage offers unique mechanics such as bot tracking, maze traps, teleporters, gun pickups, and a training island.

---

## 📸 Game Preview

*(Add images here)*

**Arena Stage Screenshot**
![Arena](ADD_IMAGE_HERE)

**Maze Stage Screenshot**
![Maze](ADD_IMAGE_HERE)

**Aim Training Screenshot**
![Training](ADD_IMAGE_HERE)

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
