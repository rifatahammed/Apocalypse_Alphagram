Done
3rd Folder --> 09


https://github.com/DruidMech/UE4-CPP-Shooter-Series/tree/master/Source/Shooter

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