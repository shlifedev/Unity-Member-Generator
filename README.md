# UnityMemberGenerator
 영어 Readme 작성필요, 리포지토리 명 변경필요 (이젠 UGUI에 국한되지 않음)
 ###
 This is Component Member-Variable Auto Generator.
 등록한 어셈블리의 멤버 변수들을 자동으로 생성해줍니다.
 
  * region 영역 지정가능
  * serialize attribute 지정가능
  * public/private 지정가능
  
 ## 설명
 
 * 다음과 같이 멤버스크립트를 자동생성 할 수 있습니다.
  
  코드 생성을 원하는 오브젝트를 우클릭후 Run Generator 를 클릭하면 하위 오브젝트들이 가지고있는
  등록한 네임스페이스를 탐색하여 코드에 복사-붙여넣기 가능한 수준의 멤버 변수 코드로 생성합니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst1.gif)
* 다음과 같이 속성을 지정할 수 있습니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst2.gif)
* 다음과 같이 속성을 지정할 수 있습니다.
  
![Instruction-1](https://github.com/shlifedev/UnityUGUIMemberGenerator/blob/master/ScreenShots/inst3.gif)


 ## 추가 예정기능 
  - Serialize Field add prefix '_' , and start character Tolower.
  - Add Property Generator (Get/Set option)
  - Save Generator Option
  - Better Inspector Design.
  - Tree-Gen System.
  - If selected transform has Button(Image children text) then make space line. (for readability improve)
  - Variable prefix character
  - Attribute Enum BitMask
  
  (2019-04-26 Done)
  * user custom type (text, image, spriterenderer, gameobject .. etc)
   
  
