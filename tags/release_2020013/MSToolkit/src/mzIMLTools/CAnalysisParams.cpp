/*
Copyright 2017, Michael R. Hoopmann, Institute for Systems Biology
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

#include "CAnalysisParams.h"

using namespace std;

CAnalysisParams::CAnalysisParams(){
  cvParam=new vector<sCvParam>;
  userParam=new vector<sUserParam>;

  sCvParam cv;
  sUserParam u;

  cvParam->push_back(cv);
  userParam->push_back(u);
}
CAnalysisParams::CAnalysisParams(const CAnalysisParams& c){
  size_t i;
  cvParam = new vector<sCvParam>;
  userParam = new vector<sUserParam>;
  for (i = 0; i<c.cvParam->size(); i++) cvParam->push_back(c.cvParam->at(i));
  for (i = 0; i<c.userParam->size(); i++) userParam->push_back(c.userParam->at(i));
}

CAnalysisParams::~CAnalysisParams(){
  delete cvParam;
  delete userParam;
}

//operators
CAnalysisParams& CAnalysisParams::operator=(const CAnalysisParams& c){
  if (this != &c){
    size_t i;
    delete cvParam;
    delete userParam;
    cvParam = new vector<sCvParam>;
    userParam = new vector<sUserParam>;
    for (i = 0; i<c.cvParam->size(); i++) cvParam->push_back(c.cvParam->at(i));
    for (i = 0; i<c.userParam->size(); i++) userParam->push_back(c.userParam->at(i));
  }
  return *this;
}

void CAnalysisParams::writeOut(FILE* f, int tabs){
  int i;
  size_t j;

  for (i = 0; i<tabs; i++) fprintf(f, " ");
  fprintf(f, "<AnalysisParams>\n");

  if (tabs > -1){
    for (j = 0; j<cvParam->size(); j++) cvParam->at(j).writeOut(f, tabs + 1);
    for (j = 0; j<userParam->size(); j++) userParam->at(j).writeOut(f, tabs + 1);
  } else {
    for (j = 0; j<cvParam->size(); j++) cvParam->at(j).writeOut(f);
    for (j = 0; j<userParam->size(); j++) userParam->at(j).writeOut(f);
  }

  for (i = 0; i<tabs; i++) fprintf(f, " ");
  fprintf(f, "</AnalysisParams>\n");

}
