Done
8th Folder --> 1

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