using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���԰���ǽ�����ƽ����,Ҳ���԰���������,��������ײ��ǽ�����ƽ��ʱ,��������ײ������
public class collisionDetection : MonoBehaviour
{
    public GameObject boomPrefab;
    //���Ԥ���������������ײ֮����������,���������Ч��,�ǵý�ѭ�����Źر�
    //������ըЧ����Ԥ����(״̬���л����һ��GameObject�Ĺ�����,������Ҫ���б�ը��ʧ������ϵ��������)
   
    void Start()
    {
        
    }


    void Update()
    {

    }
    //������ײ
    private void OnCollisionEnter(Collision collision)
    {
        //Debug�ҾͲ�˵ʲô��˼��,collision.gameObject����ײ������,����ͨ�������ȡ����ײ���������
        Debug.Log("��ײ������:��ײ��"+collision.gameObject.name);
        //������ը��Ч:���������ײ�����ɵ�boomPrefab��� ע��:���������Ч��,�ǵý�ѭ�����Źر�,�����һֱ����,���о���Quaternion.Euler�Ӻ���Ĳ������Ե����������ת�Ƕ�,�������Ҫ����,ֱ��дQuternion.identity����
        GameObject boom = Instantiate(boomPrefab, collision.transform.position, Quaternion.Euler(-90f, 0f, 0f));
        //������ײ����:һ���ǵø���Ҫ��ײ�����������ײ��,���û����ײ�����޷�����Ч����
        Destroy(collision.gameObject);
    }
    //������ײ
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("��ײ������");
    }

    //������ײ
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("��ײ������");
    }
}
