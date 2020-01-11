#pragma once

#include <string>;

using namespace std;

namespace Invokable {
	extern "C" class DoWork
	{
	public:
		__declspec(dllexport) void Init();
		__declspec(dllexport) string GetString();
	};
}
