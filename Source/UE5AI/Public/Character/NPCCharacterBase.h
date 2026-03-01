// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Character.h"
#include "Interface/ICacheBase.h"
#include "NPCCharacterBase.generated.h"

UCLASS()
class UE5AI_API ANPCCharacterBase : public ACharacter, public ICacheBase
{
	GENERATED_BODY()

public:
	ANPCCharacterBase();

protected:
	virtual void BeginPlay() override;
	virtual void OnLeavePool() override {};
	virtual void OnEnterPool() override {};
};
