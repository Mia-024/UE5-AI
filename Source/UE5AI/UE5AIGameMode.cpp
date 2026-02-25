// Copyright Epic Games, Inc. All Rights Reserved.

#include "UE5AIGameMode.h"
#include "UE5AICharacter.h"
#include "UObject/ConstructorHelpers.h"

AUE5AIGameMode::AUE5AIGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
