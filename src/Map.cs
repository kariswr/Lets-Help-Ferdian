using System;
using System.Collections;

namespace Kingdom {
  class Check {
    Boolean found;

    public Check() {
      found = false;
    }

    public Boolean getFound() {
      return found;
    }

    public void setFound(Boolean f) {
      found = f;
    }
  }

  class Solution
    {
        public ArrayList solution;

        public Solution()
        {
            solution = new ArrayList();
        }

        public void Copy(ArrayList A)
        {
            solution.AddRange(A);
        }

        public void Add(int i)
        {
            solution.Add(i);
        }

        public int getLength()
        {
            return (solution.Count);
        }

        public int getElement(int i)
        {
            return ((int)solution[i]);
        }
    }

  class Map {
    int house;
    public int [,] neighbor;
    public int [] level;

  public Map(int n) {
    house = n;
    neighbor = new int [n,n];
    for(int i = 0; i < n; i++) {
      for(int j = 0; j < n; j++) {
        neighbor[i,j] = 0;
      }
    }
    level = new int [n];
    for(int i = 0; i < n; i++) {
      level[i] = 0;
    }
  }

  public void makeNeighbors(int i, int j) {
    neighbor[i,j] = 1;
    neighbor[j,i] = 1;
  }

  public int getHouse() {
    return house;
  }

  public int getNeighbors(int i, int j) {
    return neighbor[i,j];
  }

  public void setLevel(int i, int l) {
    level[i] = l;
  }

  public int getLevel(int i) {
    return level[i];
  }
  }

  class Hide_n_Seek {
    public Map map;
    public ArrayList c_route;

    public Hide_n_Seek(int n) {
      map = new Map(n);
      c_route = new ArrayList();
    }

    public void findLevel(int c_pos, int dest, int level, Check c) {
      if(c_pos == dest) {
        map.setLevel(dest-1,level);
        c.setFound(true);
      }
      else {
        c_route.Add(c_pos);
        for(int i = 0; i < map.getHouse(); i++) {
          if((map.getNeighbors(c_pos-1,i) == 1) && (!c_route.Contains(i+1))) {
            findLevel(i+1,dest,level+1,c);
          }
          if(c.getFound()) {
            break;
          }
        }
        c_route.Remove(c_pos);
      }
    }

  public void Trace(int dir, int finish, int start, Check c, Solution S) {
    if(start == finish) {
     c_route.Add(start);
     S.Copy(c_route);
     c_route.Remove(start);
     c.setFound(true);
      
    }
    else {
      c_route.Add(start);
      for(int i = 0; i < map.getHouse(); i++) {
        if(dir == 0) {
          if((map.getNeighbors(start-1,i) == 1) && (map.getLevel(start-1) > map.getLevel(i))) {
            Trace(dir,finish,i+1,c,S);
            }
          }
        else if(dir == 1) {
          if((map.getNeighbors(start-1,i) == 1) && (map.getLevel(start-1) < map.getLevel(i))) {
            Trace(dir,finish,i+1,c,S);
          }
        }
        if(c.getFound()) {
          break;
        }
      }
      c_route.Remove(start);
    }
  }
    
  }
}