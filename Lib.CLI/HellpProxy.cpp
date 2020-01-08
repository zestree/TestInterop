#include "pch.h"
#include "HellpProxy.h"

using namespace System;

String^ Proxy::HelloProxy::GetGreeting()
{
	return gcnew String("Hellow World");
}
