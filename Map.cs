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
  class Map {
    int house;
    int [,] neighbor;
    int [] level;

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
    ArrayList c_route;

    public Hide_n_Seek(int n) {
      map = new Map(n);
      c_route = new ArrayList();
    }

    public void findLevel(int c_pos, int dest, int level) {
      if(c_pos == dest) {
        map.setLevel(dest-1,level);
      }
      else {
        c_route.Add(c_pos);
        for(int i = 0; i < map.getHouse(); i++) {
          if((map.getNeighbors(c_pos-1,i) == 1) && (!c_route.Contains(i+1))) {
            findLevel(i+1,dest,level+1);
          }
        }
        c_route.Remove(c_pos);
      }
    }

  public void Trace(int dir, int finish, int start, Check c) {
    if(start == finish) {
      c.setFound(true);
    }
    else {
      c_route.Add(start);
      for(int i = 0; i < map.getHouse(); i++) {
        if(dir == 0) {
          if((map.getNeighbors(start-1,i) == 1) && (map.getLevel(start-1) > map.getLevel(i))) {
            Trace(dir,finish,i+1,c);
            }
          }
        else if(dir == 1) {
          if((map.getNeighbors(start-1,i) == 1) && (map.getLevel(start-1) < map.getLevel(i))) {
            Trace(dir,finish,i+1,c);
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
