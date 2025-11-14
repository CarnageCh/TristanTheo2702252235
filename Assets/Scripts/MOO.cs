using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOO : MonoBehaviour, IInteractable
{
    public bool isNear { get; private set; }
    public string MOOID { get; private set; }
    public GameObject itemPrefab;
    public Sprite touched;

    // Start is called before the first frame update
    void Start()
    {
        MOOID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    public bool CanInteract()
    {
        return true;
    }

    public void Interact()
    {
        if(!CanInteract())
        {
            return;
        }
        TouchCow();
    }

    private void TouchCow()
    {
        setTouched(true);
        if(itemPrefab)
        {
            GameObject droppeditem = Instantiate(itemPrefab, transform.position + Vector3.down, Quaternion.identity);
            droppeditem.GetComponent<BounceEffect>().StartBounce();
        }
        Debug.Log("MOO");
    }

    public void setTouched(bool near)
    {
        if(isNear == near)
        {
            GetComponent<SpriteRenderer>().sprite = touched;
        }
    }
}
