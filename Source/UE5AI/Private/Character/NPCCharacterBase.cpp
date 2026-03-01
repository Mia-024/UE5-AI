// Fill out your copyright notice in the Description page of Project Settings.

#include "Character/NPCCharacterBase.h"

ANPCCharacterBase::ANPCCharacterBase()
{
	PrimaryActorTick.bCanEverTick = false;
}

void ANPCCharacterBase::BeginPlay()
{
	Super::BeginPlay();
}

