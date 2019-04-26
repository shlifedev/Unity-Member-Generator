# UnityUGUIMemberGenerator
 영어 Readme 작성필요, 리포지토리 명 변경필요 (이젠 UGUI에 국한되지 않음)
 ###
 This is Component Member-Variable Auto Generator.
  
 멤버 변수들을 자동으로 생성해주며 일반적으로 'MaskableGraphic'을 상속받는 
 컴퍼넌트를 대상으로 작동합니다. 
 
 ## 설명
 
 * 다음과 같이 멤버스크립트를 자동생성 할 수 있습니다.
  
  코드 생성을 원하는 오브젝트를 우클릭후 Run Generator 를 클릭하면 하위 오브젝트들이 가지고있는
  모든 MaskableGraphic을 탐색하여 스크립트에 복사-붙여넣기 가능한 수준의 멤버 변수 코드로 생성합니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst1.gif)
* 다음과 같이 속성을 지정할 수 있습니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst2.gif)
* 다음과 같이 속성을 지정할 수 있습니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst3.gif)


 ## 커스텀 타입 추가하는방법
  UIScriptGenerator.cs를 열어 private static void CodeGenerator(List<Transform> transforms) 함수에서
  아래와같이 수정하세요 (<<<<<<<<-----------  확인)
 
``` csharp

    private static void CodeGenerator(List<Transform> transforms)
        {

            StringBuilder builder = new StringBuilder();
            if (UIScriptGeneratorEditor.WriteRegion == true)
                builder.AppendLine("#region " + UIScriptGeneratorEditor.Region + "\n");


            for (int i = 0; i < transforms.Count; i++)
            {
                var compArr = transforms[i].GetComponents<MaskableGraphic>();  <<<<<<<<----------- Add Your Custom Component.
                foreach (var component in compArr)
                {
                    string ret = null;
                    if (component is Image)
                    {
                        ret = Write(UIScriptGeneratorEditor.AttrStr + UIScriptGeneratorEditor.AplStr, component.GetType().Name, component.name);
                    }
                    else if (component is Text)
                    {
                        ret = Write(UIScriptGeneratorEditor.AttrStr + UIScriptGeneratorEditor.AplStr, component.GetType().Name, component.name);
                    }
                    
                    if (component is YourCustomComponent) <<<<<<<<-----------
                    {
                        ret = Write(UIScriptGeneratorEditor.AttrStr + UIScriptGeneratorEditor.AplStr, component.GetType().Name, component.name);
                    }
                    
                    if (ret != null)
                        builder.AppendLine(ret);
                }
            }
            
```
=======
 ## 추가 예정기능 
  - Serialize Field add prefix '_' , and start character Tolower.
  - Add Property Generator (Get/Set option)
  - Save Generator Option
  - Better Inspector Design.
  - Tree-Gen System.
  - if selected transform has Button(Image children text) then make space line. (for readability improve)
  - variable prefix character
  
  (2019-04-26 Done)
  * user custom type (text, image, spriterenderer, gameobject .. etc)
   
  
