#include "pch.h"
#include "Hello.h"

LPCTSTR Native::Hello::GetGreeting()
{
	return LPCTSTR(L"Hello World");
}
