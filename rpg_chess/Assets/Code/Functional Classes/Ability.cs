using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public Entity owner { get; private set; }
    public HashSet<Vector2Int> targets { get; private set; }
    // ����������� ���������� ����� ���������� ������������ ������������.
    // ������ ��������� �������� ��� ������� ����� ����� ����� ����� �����.
    // �������� ���������� (0,0) ����������� ���������� �� ����,
    // ���� ��������� ������� �����������.


    public Ability(Entity owner)
    {
        this.owner = owner;
    }

}
