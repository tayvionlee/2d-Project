using UnityEngine;

public interface IPooledObject
{
    /*
     * specifies types and functions. All objects within an interface
     * All objects that derive from this interface have to implement 
     * the functions and the types from the interface.
     */


    void onObjectSpawn();
}



