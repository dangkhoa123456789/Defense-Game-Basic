using UnityEngine;

public class Player : MonoBehaviour
{
    public float attackRate;
    private float m_curattackRate;
    private Animator m_anim;
    private bool m_isAttacked;
    private void Awake()
    {
        m_anim = GetComponent<Animator>();
        m_curattackRate = attackRate;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !m_isAttacked)
        {
            if (m_anim)
                m_anim.SetBool(Const.ATTACK_ANIM, true);
            m_isAttacked = true;
        }
        if(m_isAttacked)
        {
            m_curattackRate -= Time.deltaTime;
            if (m_curattackRate <= 0)
            {
                m_isAttacked=false;
                m_curattackRate = attackRate;
            }
        }
    }
    public void ResetAttackAnim()
    {
        if (m_anim)
            m_anim.SetBool(Const.ATTACK_ANIM, false);
    }
        
}
