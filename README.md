# Zombie Survival VR

Welcome to **Zombie Survival VR**, a thrilling virtual reality experience that tests your survival skills against waves of dynamically spawning zombies. Developed using Unity and leveraging the XR Interaction Toolkit, this game sets a new standard for immersive VR gameplay.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Contributing](#contributing)
- [Contact](#contact)

## Features

**Zombie Survival VR** offers players a unique blend of horror, strategy, and action with the following key features:

- **Advanced AI Navigation**: Zombies use Unity's NavMesh for intelligent pathfinding, making each encounter unpredictably challenging.
- **Randomized Spawning**: Gameplay stays fresh with zombies spawning at random points around the player:
  ```csharp
  Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
  Instantiate(spawnGameObject, randomPoint.position, randomPoint.rotation);
  timer = 0;
- **VR Interaction**: Players interact with the world using VR controllers, managing weapons and navigating through a creepy graveyard setting.
- **Atmospheric Environment**: Strategic lighting and fog effects create a haunting atmosphere perfect for a horror survival game.
- **Immersive Gameplay**: Encounter zombies that dynamically react to player movements, enhancing the immersive VR experience.

## Getting Started

To dive into Zombie Survival VR, follow these simple steps:

**Prerequisites**

Install Unity (version 2020.3 LTS or newer recommended).
Ensure you have a compatible VR headset setup, like Oculus Rift, HTC Vive, or Valve Index.

**Installation**
- Clone the repo:
git clone https://github.com/yourusername/zombie-survival-vr.git
- Open the project in Unity.
- Set up your VR rig in the Unity project settings.
- Load the Main scene and hit play.

## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

**Fork the Project**
Create your Feature Branch (git checkout -b feature/AmazingFeature)
Commit your Changes (git commit -m 'Add some AmazingFeature')
Push to the Branch (git push origin feature/AmazingFeature)
Open a Pull Request

## Contact

**Your Name** - @krngrover6
**Project Link**: https://github.com/krngrover6/VR_Zombie_Survival
