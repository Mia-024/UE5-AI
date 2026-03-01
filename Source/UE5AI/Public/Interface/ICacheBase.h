#pragma once
#include "ICacheBase.generated.h"

UINTERFACE(Blueprintable)
class UCacheBase : public UInterface
{
	GENERATED_BODY()
};

class UE5AI_API ICacheBase
{
	GENERATED_BODY()
	
	// 从缓存池出生
	virtual void OnLeavePool() = 0;
	// 进入缓存池
	virtual void OnEnterPool() = 0;
};
