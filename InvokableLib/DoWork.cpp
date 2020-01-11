#include "pch.h"
#include "DoWork.h"
using namespace std;

string msg;

void Invokable::DoWork::Init() {
	msg = string("Do Work");
}

string Invokable::DoWork::GetString()
{
	return msg;
}
