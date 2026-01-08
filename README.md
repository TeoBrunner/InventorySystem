

https://github.com/user-attachments/assets/049fa023-5bd7-49ff-a9b4-0566fa53584c

# Modular Inventory & Input System 🎒🕹️

**A high-performance, signal-driven Unity framework for mobile and top-down games.**

![Unity](https://img.shields.io/badge/Unity-6.3+-black?style=flat&logo=unity)
![Zenject](https://img.shields.io/badge/DI-Zenject-blue)
![Architecture](https://img.shields.io/badge/Pattern-SignalBus-orange)

## 📖 Overview

This project is a technical demonstration of a **modular, decoupled architecture** for Unity. It focuses on two core pillars of game development: a robust **Mobile Input Suite** and a flexible **Data-Driven Inventory System**. 

By leveraging **Zenject SignalBus**, the systems communicate without knowing about each other, making the codebase highly maintainable and easy to extend.

---

## 🎮 Key Features

### 1. Advanced Joystick Suite
A professional-grade mobile input solution with custom Editor tooling:
* **Three Modes:** * *Fixed:* Static position for classic layouts.
    * *Floating:* Appears at the touch point for ergonomic comfort.
    * *Variable/Dynamic:* Follows the finger movement with a customizable "move threshold."
* **Custom Inspectors:** Dedicated Unity Editor scripts for each joystick type to streamline configuration.

### 2. Scalable Inventory System
A slot-based "Backpack" system designed for performance and flexibility:
* **Item Database:** A centralized `ScriptableObject` registry for easy balancing and item management.
* **Collection Logic:** Uses 2D trigger detection with automated signal firing.
* **UI Sync:** Real-time synchronization between the logical `BackpackHandler` and the uGUI representation.

---

## 🏗 Architecture & Patterns



### Signal-Driven Communication
Instead of using direct references or brittle C# events, this project utilizes the **Zenject SignalBus**. This creates a "Fire and Forget" workflow:
* `CollectItemSignal`: Triggered by the world-space collector, picked up by the Inventory.
* `BackpackToggleSignal`: Decouples the UI trigger from the inventory logic.
* `BackpackSlotClickedSignal`: Handles UI interactions through a centralized command flow.

### Dependency Injection (Zenject)
The project adheres to the **Dependency Inversion Principle**:
* **Constructors/Method Injection:** dependencies are provided by the DI Container, ensuring classes remain "Pure C#" where possible.
* **Contextual Binding:** `SceneInstaller` and `ConfigInstaller` manage scope-specific instances.

### Data-Driven Design
Game balance is separated from logic using `ScriptableObject` configurations:
* `PlayerConfig`: Tune movement and agility in real-time.
* `BackpackConfig`: Define slot counts and storage rules.
* `ItemData`: Manage IDs, high-res icons, and stack properties in a single asset.

---

## 🛠 Tech Stack
* **Engine:** Unity 6.3 (LTS).
* **DI Framework:** Zenject / Extenject.
* **Patterns:** Signal Bus, Factory Pattern, Repository Pattern.
* **UI:** Unity UI (uGUI) with custom EventSystem integration.
* **Tooling:** Custom Unity Editor scripting.

---

## 🚀 How to Use

1.  **Configure Items:** Add new items to the `ItemDatabase` ScriptableObject.
2.  **Adjust Input:** Select the Joystick prefab and choose the mode (Fixed/Floating/Variable) in the Inspector.
3.  **Inject:** Use `[Inject] private SignalBus _signalBus;` in any new class to join the communication ecosystem.
