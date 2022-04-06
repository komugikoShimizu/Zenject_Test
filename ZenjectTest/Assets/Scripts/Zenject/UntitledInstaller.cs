using UnityEngine;
using Zenject;

public class UntitledInstaller : MonoInstaller<UntitledInstaller> // このスクリプト
{
    public override void InstallBindings()
    {
        // 実体がない場合
        //Container
        //    .Bind<IMoveInterface>() // インターフェース
        //    .To<InputScripts>()     // 上記のインターフェースを実装したスクリプト
        //    .AsCached();            // なんか使いまわすやつ

        // 実体がある場合
        Container
            .Bind<IMoveInterface>().FromComponentInHierarchy() // ヒエラルキーからスクリプト探索
            .AsCached();                                       // ないとエラーになる?
    }

    private void Memo()
    {
        string stadyMemo =
            "ScriptableObject SceneObject Prefab でわけられている" +
            "入れる場所を間違えないように" +
            "参照する側に[inject]をつけ忘れないこと" +
            "渡すスクリプトから特別な操作は必要なし" +
            "オブジェクトとして存在してなくても大丈夫";

        Debug.LogWarning(stadyMemo);
    }
}