namespace StoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Story Game");

            Actor actor = new Actor();

            actor.ShowActor(actor.Title);

            actor.ShowActor(actor.RoomA);

            actor.ShowActor(actor.camel);
            actor.Tell("낙타", "안녕하세요 낙타입니다.");

            Console.ReadKey(); // 입력을 기다리고 있습니다. 다음 내용이 실행됩니다.
            Console.Clear();   // 화면을 전부다 지웁니다.
            actor.ShowActor(actor.sleepCat); // actor에 등록된 이미지를 가져옵니다.
            actor.Tell("고양이", "안녕하세요 고양이입니다."); // 첫번째 : 화자, 두번째 : 대사

            actor.Tell("[낙타]", "오늘 점심을 먹었나요?");
            bool select = actor.Selection("[고양이]", "네 먹었습니다.", "아니오 안먹었습니다", actor.sleepCat, actor.sleepCat);

            if(select) // 긍정에 대한 이후 답변이 진행
            {
                Console.ReadKey();
                actor.Tell("나레이션", "방안에서 전화 벨이 울립니다.");

                Console.Clear();
                actor.ShowActor(actor.man);
                actor.ShowActor(actor.bird);
                actor.ShowActor(actor.dolphin);


                Console.Clear();
                actor.ShowActor(actor.End);
                actor.Tell("[나레이션]", "Good Ending");

            }
            else // 부정 이후의 답변이 진행
            {
                Console.ReadKey();
                actor.Tell("[나레이션]", "주방에서 연기가 납니다.");
            }         
        }
    }
}
