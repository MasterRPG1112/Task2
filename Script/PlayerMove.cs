using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //키보드 입력 값 저장 변수 지정
    float moveX;
    float moveZ;

    //Inspector 창에서 조정 가능 세팅
    public float Speed;

    //X, Y, Z 좌표 저장 구조체
    Vector3 moveVector;

    //매 프레임 실행
    void Update()
    {
        //입력하도록 강제하는 함수
        moveX = Input.GetAxis("Horizontal");    //A, D
        moveZ = Input.GetAxis("Vertical");  //W, S

        //moveX와 moveZ에 입력받은 값을 데리고 옴
        moveVector = new Vector3(moveX, 0, moveZ).normalized;   //대각선 가속도 제거

        //Object 기존 위치 += 방향 * 속도 * 컴퓨터 간에 속도 격차 해결
        transform.position += moveVector * Speed * Time.deltaTime;
    }
}
