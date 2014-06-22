/*
  Copyright 2014 Edward Fleming III

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

using UnityEngine;
using System.Collections;

[System.Serializable]
public class CurMax {
  private int cur;
  private int max;
  
  public curMax(int maxValue){
    this.max = maxValue;
    this.cur = maxValue;
  }

  public curMax(int currentValue, int maxVaule){
    this.cur = currentValue;
    this.max = maxValue;
    sanitize();
  }

  public void setTo(int newCurrent){
    cur = newCurrent;
    sanitize();
    
  }

  public void addTo(int addToCurrent){
    cur += addToCurrent;
    sanitize();
  }

  public void subtractFrom(int removeFromCurrent){
    cur -= removeFromCurrent;
    sanitize();
  }

  public int current(){
    return cur;
  }

  public int max(){
    return max;
  }

  private void sanitize(){
    if (cur > max){
      cur = max;
    }
  }
}
