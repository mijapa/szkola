#pragma once
#include "Document.h"
#include<vector>
#include <cctype>

using namespace std;

class DocText: public Document {
private:
	vector<string> lines;
	int getCountLines() {
		return lines.size();
	}
	int getCountChar() {
		int result{ 0 };
		for (string line : lines) {
			result += line.size();
		}
		return result;
	}
	int getAlpha();
	int getVowels();
	int getWords(int minLength = 0);
	int getConsonant();

public:
	DocText(string name, int size,vector<string> lines);
	DocText();
	void Info();
	void ContentToFile(string fileName);
	void LoadToContent(string fileName);
};
