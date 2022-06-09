##Apocalypse Alphagram
By Rifat Ahammed
---


Features
-	Character Movement
1.	Character Movement ( w,a,s,d)
2.	Character Jump (Space)
3.	Crouch ( C ) 
4.	Fire ( Mouse – Left Button) 
5.	Zoom in Out ( Mouse – Right Button) 
6.	Pickup ( F ) 
-	Inventory System
o	Inventory Item Change ( G , 1, 2 , 3, 4 ) 
-	Dynamic Inventory Slots for different guns
-	Dynamic Ammo Icon
-	Different Gun Type
o	AR
o	SMG
o	Pistol
-	Gun Pickup Widget ( Dynamic)
-	Ammo Pickup Widget ( Dynamic)
-	Gun Rarity
o	Damaged
o	Common
o	Uncommon
o	Rare
o	Legendary
-	Different Ammo
o	9mm
o	AR Ammo
-	Auto Ammo pickup 
-	Gun Fire 
o	Auto
o	Manual 
-	Gun Swap If inventory is full
-	Auto Inventory Slot animation before gun pickup
-	Muzzle Flash
-	Smoke Beam
-	Hit Flash
-	Reload System
o	Auto when Magazine is Finished
o	Manual by Clicking R 
-	Health Bar
o	Enemy
o	Character
-	Healing Medicine ( Increase Health Percentage ) 
-	Explosive Barrels ( Decrease Health for both Character And Enemy)
-	Enemy Damage
o	Body Shot
o	Headshot
-	Enemy AI
o	Patrols Between Two Points 
o	Chase to Attack if character enters enemy’s zone
o	Attacks when character shoot him
-	Different Animation Montage
-	Usage of Data Table
-	Different Crosshair for Different Guns 









===========================================================
Just delete the Intermediate and Saved folders in your project, 
they are not needed unless you want to recover something.
===========================================================

UE_LOG(LogTemp, Warning, TEXT("Hello"));

	int myInt{ (int)10.6 };
	UE_LOG(LogTemp, Warning, TEXT("%d"),myInt);
	float myFloat{ 3.14159f };
	UE_LOG(LogTemp, Warning, TEXT("%f"), myFloat);

	FString myString{ TEXT("My String!!!") };
	UE_LOG(LogTemp, Warning, TEXT("%s"), *myString);
	to get the name of the current instance
	UE_LOG(LogTemp, Warning, TEXT("Name of instance:  %s"), *GetName());

	#DeltaTime: Time between frames, times between Frames 
	when game lags , DeltaTime becomes high 
	void Tick(float DeltaTime){
		Move(1.f * DeltaTime); // will move one cm in every Frame
	}