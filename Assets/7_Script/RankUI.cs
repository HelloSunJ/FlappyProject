using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class RankUI : MonoBehaviour
{
    [SerializeField] private Image medal;
    [SerializeField] private TextMeshProUGUI rankText;
    [SerializeField] private TextMeshProUGUI dateText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Sprite[] medalSprite;

    public void SetRank (int rank, int score, string dt)
    {
        //3�̻��̸� 3��, �ƴϸ� �� ���� �ε����� �Ѵ�.
        int medalindexer = (rank > 2) ? 3 : rank;
        //�޴޽�������Ʈ�� �ִ� �޴� ����
        medal.sprite = medalSprite[medalindexer];
        //��ũ ���� 0�����̹Ƿ� +1
        rankText.text = (rank + 1).ToString();
        //��ũ�� 3�̻��϶��� ǥ��
        /*  bool temp = false;
        if (rank > 2) temp = true;*/
        rankText.gameObject.SetActive(rank > 2); //temp
        if(dt != null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("20");
            sb.Append(dt.Substring(0, 2));
            sb.Append("/");
            sb.Append(dt.Substring(2, 2));
            sb.Append("/");
            sb.Append(dt.Substring(4, 2));
            sb.Append("\n");
            sb.Append(dt.Substring(6, 2));
            sb.Append(":");
            sb.Append(dt.Substring(8, 2));
            sb.Append(":");
            sb.Append(dt.Substring(10, 2));
            sb.ToString();

            dateText.text = sb.ToString();
        }
        scoreText.text = score.ToString();


    }


}
