// Copyright The Knights of Unity. All Rights Reserved.


#include "GASAbilitySystemComponent.h"

const UAttributeSet* UGASAbilitySystemComponent::MyGetAttributeSet(TSubclassOf<UAttributeSet> AttributeSetClass) const
{
	// get the attribute set
	const UAttributeSet* AttributeSet = GetAttributeSubobject(AttributeSetClass);

	// return the pointer
	return AttributeSet;
}