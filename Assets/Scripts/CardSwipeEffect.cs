using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSwipeEffect : MonoBehaviour, IDrugHandler
{
   // public GameObject image;
    //private Vector3 startPos;
    //private float swipeThreshold = 50f;

    /*
    public GameObject image;           // ������ �� ������ �����������
    private Vector2 startPos;          // ��������� ������� ������
    private Vector2 endPos;            // �������� ������� ������
    private float swipeThreshold = 50f; // ����� ������ ��� ����������� ��������
    private bool isSwiping = false;     // ���� ��� ������������ ������
    */
    private void Start()
    {
        //startPos = image.transform.position;
    }
    private void Update()
    {
        
    }

    /*
    private void FunTwo()
    {
        if (Input.GetMouseButtonDown(0))      // ��������� ������� ����� ������ ����/���������
        {
            startPos = Input.mousePosition;  // ��������� ��������� ������� ������
            isSwiping = true;                // ������������� ���� ������
        }
        else if (Input.GetMouseButtonUp(0))   // ��������� ���������� ����� ������ ����/���������
        {
            endPos = Input.mousePosition;    // ��������� �������� ������� ������

            Vector2 swipeDirection = endPos - startPos;     // ��������� ������ ����������� ������

            if (swipeDirection.magnitude > swipeThreshold)  // ���� ����� ������� ������ ������ ������
            {
                if (swipeDirection.x > 0)           // ���� ����� ������
                {
                    Debug.Log("Swipe right");
                    // �������� ��� ������ ������ (��������, ����)
                }
                else                                // ���� ����� �����
                {
                    Debug.Log("Swipe left");
                    // �������� ��� ������ ����� (��������, �������)
                }
            }

            isSwiping = false;           // ���������� ���� ������
        }

        if (isSwiping)
        {
            Vector2 delta = (Vector2)Input.mousePosition - startPos;   // ��������� ������� ����� ������� �������� � ��������� �������� ������

            image.transform.position = startPos + delta;   // ��������� ������� ����������� � ������������ � �������� ������
        }
    }
    */

    /*
private void FuncOne()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - startPos;
            if (delta.magnitude > swipeThreshold)
            {
                if (delta.x > 0)
                {
                    Debug.Log("Right");

                }
                else
                {
                    Debug.Log("left");
                }
                image.transform.position = startPos;
            }
        }
    }
    */
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(transform.localPosition.x + eventData.delta.x, transform.localPosition.y);
    }
}
