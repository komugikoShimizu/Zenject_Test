using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller<UntitledInstaller> // ���̃X�N���v�g
{
    public override void InstallBindings()
    {
        // ���̂��Ȃ��ꍇ
        //Container
        //    .Bind<IMoveInterface>() // �C���^�[�t�F�[�X
        //    .To<InputScripts>()     // ��L�̃C���^�[�t�F�[�X�����������X�N���v�g
        //    .AsCached();            // �Ȃ񂩎g���܂킷���

        // ���̂�����ꍇ
        Container
            .Bind<IMoveInterface>().FromComponentInHierarchy() // �q�G�����L�[����X�N���v�g�T��
            .AsCached();                                       // �Ȃ��ƃG���[�ɂȂ�?
    }

    private void Memo()
    {
        string stadyMemo =
            "ScriptableObject SceneObject Prefab �ł킯���Ă���" +
            "�����ꏊ���ԈႦ�Ȃ��悤��" +
            "�Q�Ƃ��鑤��[inject]�����Y��Ȃ�����" +
            "�n���X�N���v�g������ʂȑ���͕K�v�Ȃ�" +
            "�I�u�W�F�N�g�Ƃ��đ��݂��ĂȂ��Ă����v";

        Debug.LogWarning(stadyMemo);
    }
}