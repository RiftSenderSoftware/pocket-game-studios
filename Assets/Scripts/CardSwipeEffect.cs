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
    public GameObject image;           // Ссылка на объект изображения
    private Vector2 startPos;          // Начальная позиция свайпа
    private Vector2 endPos;            // Конечная позиция свайпа
    private float swipeThreshold = 50f; // Порог свайпа для определения действия
    private bool isSwiping = false;     // Флаг для отслеживания свайпа
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
        if (Input.GetMouseButtonDown(0))      // Проверяем нажатие левой кнопки мыши/тачскрина
        {
            startPos = Input.mousePosition;  // Сохраняем начальную позицию свайпа
            isSwiping = true;                // Устанавливаем флаг свайпа
        }
        else if (Input.GetMouseButtonUp(0))   // Проверяем отпускание левой кнопки мыши/тачскрина
        {
            endPos = Input.mousePosition;    // Сохраняем конечную позицию свайпа

            Vector2 swipeDirection = endPos - startPos;     // Вычисляем вектор направления свайпа

            if (swipeDirection.magnitude > swipeThreshold)  // Если длина вектора больше порога свайпа
            {
                if (swipeDirection.x > 0)           // Если свайп вправо
                {
                    Debug.Log("Swipe right");
                    // Действия при свайпе вправо (например, лайк)
                }
                else                                // Если свайп влево
                {
                    Debug.Log("Swipe left");
                    // Действия при свайпе влево (например, дизлайк)
                }
            }

            isSwiping = false;           // Сбрасываем флаг свайпа
        }

        if (isSwiping)
        {
            Vector2 delta = (Vector2)Input.mousePosition - startPos;   // Вычисляем разницу между текущей позицией и начальной позицией свайпа

            image.transform.position = startPos + delta;   // Обновляем позицию изображения в соответствии с позицией свайпа
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
