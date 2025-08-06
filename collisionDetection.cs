using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//可以绑在墙面或者平面上,也可以绑在球体上,当球体碰撞到墙面或者平面时,会销毁碰撞的物体
public class collisionDetection : MonoBehaviour
{
    public GameObject boomPrefab;
    //这个预设体是物件发生碰撞之后所产生的,如果是粒子效果,记得将循环播放关闭
    //声明爆炸效果的预设体(状态栏中会出现一个GameObject的功能栏,将你想要进行爆炸消失的物件拖到里面就行)
   
    void Start()
    {
        
    }


    void Update()
    {

    }
    //产生碰撞
    private void OnCollisionEnter(Collision collision)
    {
        //Debug我就不说什么意思了,collision.gameObject是碰撞的物体,可以通过这个获取到碰撞物体的名称
        Debug.Log("碰撞发生了:碰撞了"+collision.gameObject.name);
        //产生爆炸特效:就是物件碰撞后生成的boomPrefab物件 注意:如果是粒子效果,记得将循环播放关闭,否则会一直播放,还有就是Quaternion.Euler加后面的参数可以调整物件的旋转角度,如果不需要调整,直接写Quternion.identity即可
        GameObject boom = Instantiate(boomPrefab, collision.transform.position, Quaternion.Euler(-90f, 0f, 0f));
        //销毁碰撞物体:一定记得给需要碰撞的物体添加碰撞器,如果没有碰撞器是无法出现效果的
        Destroy(collision.gameObject);
    }
    //正在碰撞
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("碰撞持续中");
    }

    //结束碰撞
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("碰撞结束了");
    }
}
