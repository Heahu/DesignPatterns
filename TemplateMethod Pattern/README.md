# TemplateMethod Pattern
<b>'템플릿 메서드 패턴'</b>이란? </br>
알고리즘의 구조를 정의하고 그 알고리즘의 일부 단계를 서브클래스에서 구현하도록 허용하는 패턴을 말한다. </br>
이 패턴은 공통된 알고리즘의 고정된 흐름은 유지하면서, 개별 단계의 구현을 서브클래스에 맡길 때 유용하다. </br>
</br>
추가로 템플릿 메서드 패턴을 사용하면 코드 재사용성이 높아지며 서브클래스에서 세부적인 구현을 변경하여 다양한 알고리즘을 정의(유연성)할 수 있고, 알고리즘의 실행 흐름을 표준화하여 일관성을 유지할 수 있다는 장점이 있다. </br>
</br>
주요 구성 요소로 크게 두가지가 존재한다.
1. 추상클래스 : 템플릿을 정의하는 클래스. 하나 이상의 템플릿 메서드를 포함하며, 알고리즘의 전체 흐름을 제어.
2. 구체 클래스 : 추상 클래스를 상속받아 템플릿 메서드에서 정의된 특정 단계들을 구현하는 클래스.
</br>


<img src="https://www.hanbit.co.kr/data/editor/20220322100143_mzdegywk.png">
</br>

# 예시코드
커피와 홍차는 비슷하다. 만드는 방법 또한 비슷하다. </br>
</br>
<b>[커피 만드는 법]</b>
1. 물을 끓인다.
2. 끓는 물에 커피를 우려낸다.
3. 커피를 컵에 따른다.
4. 설탕과 우유를 추가한다.
   
<b>[홍차 만드는 법]</b>
1. 물을 끓인다.
2. 끓는 물에 찻잎을 우려낸다.
3. 홍차를 컵에 따른다.
4. 레몬을 추가한다.
</br>

</br>
[ CaffeineBeverage ] </br>

```csharp
public abstract class CaffeineBeverage
{
    protected abstract void Brew();
    protected abstract void AddCondiments();

    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected void BoilWater()
    {
        Console.WriteLine("물 끓이는 중");
    }

    protected void PourInCup()
    {
        Console.WriteLine("컵에 따르는 중");
    }
}
```

[ Coffee ] </br>

```csharp
public class Coffee : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("커피 내리는 중");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("설탕과 우유 추가 중");
    }
}
```

[ Tea ] </br>

```csharp
public class Tea : CaffeineBeverage
{
    protected override void Brew()
    {
        Console.WriteLine("찻잎을 우려내는 중");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("레몬 추가 중");
    }
}
```
</br>

참고자료 : 
https://velog.io/@shasha/%ED%97%A4%EB%93%9C%ED%8D%BC%EC%8A%A4%ED%8A%B8-%EB%94%94%EC%9E%90%EC%9D%B8%ED%8C%A8%ED%84%B4-Chapter-08.-%ED%85%9C%ED%94%8C%EB%A6%BF-%EB%A9%94%EC%86%8C%EB%93%9C-%ED%8C%A8%ED%84%B4
