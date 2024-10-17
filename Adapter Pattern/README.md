# Adapter Pattern
<b>'어댑터 패턴'</b>이란? </br>
소프트웨어 디자인 패턴 중 하나로, 서로 호환되지 않는 인터페이스를 가진 클래스들 간의 상호작용을 가능하게 만드는 패턴이다. </br>
어댑터 패턴을 사용하면 기존의 코드(구)와 새로운 코드(신) 간의 호환성을 유지하면서 새로운 기능을 추가할 수 있다. </br>
어댑터 패턴은 다음과 같은 요소로 구성되어 있다. </br>
</br>
-타겟 : 클라이언트가 사용하는 인터페이스 </br>
-어댑터 : 타겟 인터페이스를 구현, 기존 클래스의 인스턴스를 사용하여 타겟 인터페이스의 메서드를 호출 </br>
-어댑티 : 기존 클래스 또는 인터페이스로, 어댑터를 통해 타겟 인터페이스와 연결됨 </br>
-클라이언트 : 타겟 인터페이스를 사용하는 코드 </br>
</br>
1. 클라이언트는 타겟 인터페이스를 통해 어댑터에 접근 
2. 어댑터는 어댑티(기존 클래스)의 인스턴스를 생성하거나 참조
3. 클라이언트의 요청이 어댑터로 전달되고, 어댑터는 이를 어댑티에 맞게 변환하여 호출
4. 어댑티의 결과는 다시 어댑터로 통해 클라이언트에 전달됨
</br>

<img src="https://www.hanbit.co.kr/data/editor/20220322101025_tpglvirm.png">
</br>

# 예시코드
IButton 인터페이스 정의

```csharp
public interface IButton
    {
        void Click();
        void SetLabel(string label);
    }
```

WindowsButton 클래스 정의 
```csharp
public class WindowsButton
    {
        public void ClickBUtton()
        {
            MessageBox.Show("버튼 클릭");
        }

        public void SetButtonLabel(String label)
        {

        }
    }
```

ButtonAdapter 클래스 정의
```csharp
public class ButtonAdapter : IButton
    {
        private readonly WindowsButton windowsButton;

        public ButtonAdapter(WindowsButton windowsButton)
        {
            this.windowsButton = windowsButton;
        }

        public void Click()
        {
            windowsButton.ClickBUtton();
        }

        public void SetLabel(string label)
        {
            windowsButton.SetButtonLabel(label);
        }
    }
```

WinForms 폼 사용
```csharp
public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            // WindowsButton을 생성
            var windowsButton = new WindowsButton();

            // 어댑터를 통해 IButton으로 변환
            IButton buttonAdapter = new ButtonAdapter(windowsButton);

            // 버튼 클릭 이벤트를 처리
            Button myButton = new Button();
            myButton.Text = "Click";
            myButton.Click += (sender, e) => buttonAdapter.Click();
            myButton.Location = new Point(150, 105);

            this.Controls.Add(myButton);
        }
    }
```

- MainForm(클라이언트) : 인터페이스를 통해 버튼 기능을 사용 </br>
- IButton(타겟 인터페이스) : 클라이언트가 사용할 수 있는 메서드 정의 </br>
- ButtonAdapter(어댑터) : IButton을 구현하고 WindowsButton의 메서드를 호출하도록 변환 </br>
- WindowsButton(어댑티) : 실제 WinForms 버튼 기능을 구현 클래스 </br>

</br>
참고자료 : https://hongjinhyeon.tistory.com/44 </br>
참고자료 : https://www.hanbit.co.kr/channel/category/category_view.html?cms_code=CMS8616098823
