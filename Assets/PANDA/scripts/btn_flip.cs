using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Vuforia;
using Newtonsoft.Json;


public class paintEvent : UnityEvent<string,string> { }
public class Root
{
    public string paint_name;
    public string author;
    public string year;
    public string size;
    public string type;
    public string locate;
    public string description1;
    public string description2;
    public string description3;
    public string description4;
    public string description5;
    public string description6;
    public string description7;
    public string description8;
    public string description9;
    public string description10;
}

public class btn_flip : MonoBehaviour
{ 
    public pinned_refresh R;
    public paintEvent paintE= new paintEvent();//實例化
    public UnityAction<string,string> action;//聲明一個具有int,bool的unityaction並命名為action
    
    public GameObject[] paintnow;   

    public Animator ani;  
    public Text pin;
    public Text tt;
    public string l="left";
    public string r="right";
    public int max;
    public int min; 
    
    // Use this for initialization    
    void Start()
    {
        globall.paintname="";
        action = new UnityAction<string,string>(flip);//將MyFunction註冊進action
        paintE.AddListener(action);//監聽
        globall.page = 1;  
        max = 0;
        min = 1;
    }
    public void tunrL()
    {
        paintE.Invoke(globall.paintname,l);
    }
    public void turnR()
    {
        paintE.Invoke(globall.paintname,r);
    }

    public void flip(string p,string way)
    {
        Root root;
        string json;
        string page1="";
        string page2="";
        string page3="";
        string page4="";
        string page5="";
        string page6="";
        string page7="";
        string page8="";
        switch (p)
        {
        case "paint_cafe":
            paintnow = GameObject.FindGameObjectsWithTag("cafe");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：夜晚露天咖啡座 Café Terrace at Night',
                'author': '作者：梵谷',
                'year': '創作年份：1888',
                'size': '畫布尺寸：81 x 65 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：荷蘭 國立渥特羅庫勒穆勒美術館',
                'description1': '完成《夜晚露天咖啡座》後，梵谷曾寫信給他的妹妹，表達了自己對於這幅作品的熱情：我最近被打斷，因為最近幾天一幅繪製晚上咖啡館外觀的新畫作讓我忙碌不已。在露台上有人們喝酒。',
                'description2': '一個巨大的黃燈照亮了露臺、立面、人行道，甚至將燈光投射到街道的鵝卵石上，街道變成了紫粉色調。在藍天星斗閃爍的街道上，房屋的山牆是深藍色或紫色，盡頭有一棵綠色的樹。現在，這是一幅沒有黑色的夜晚畫作，',
                'description3': '畫作中只有美麗的藍色、紫色和綠色，而在這樣的環境中，照亮的廣場呈淡硫磺色、檸檬綠色。我非常喜歡在夜晚的現場繪畫。過去人們習慣於白天繪製素描，然後在畫作上進行繪畫。但我發現直接在現場繪畫比較適合我。',
                'description4': '黑暗中，我可能會把藍色當成綠色，藍紫色當成粉紫色，因為調色的本質無法清晰辨認。但這是遠離黑夜的唯一方法，在普通的黑夜中，只有貧弱、蒼白和略帶白色的光線，然而一道燭光，就能夠帶給我們最豐富的黃色和橙色。',
                'description5': '你從未告訴我你是否讀過莫泊桑的小說《俊友》，以及你對他才能的看法。我之所以這麼說是因為《俊友》的開場，就是對巴黎星空下露天咖啡館的描述，而這正好是我現在所創作的主題有著相似之處。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            max=6;            
            break;
        case "paint_selfie":
            paintnow = GameObject.FindGameObjectsWithTag("selfie");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：沒鬍子的自畫像 Self-portrait without beard',
                'author': '作者：梵谷',
                'year': '創作年份：1889',
                'size': '畫布尺寸：40 x 31 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：私人收藏',
                'description1': '梵谷一生中，創作了很多自畫像。梵谷很可能是通過看鏡子中的像畫自己的，即畫像中的右臉實際是他的左臉。是梵谷給母親的生日禮物，有學者認為這是梵谷的最後一幅自畫像。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            max=2;            
            break;
        case "paint_flower":
            paintnow = GameObject.FindGameObjectsWithTag("flower");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '花瓶裡的十四朵向日葵 Sunflowers',
                'author': '作者：梵谷',
                'year': '創作年份：1888',
                'size': '畫布尺寸：92 x 73 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：英國 倫敦國家畫廊',
                'description1': '這幅畫是荷蘭畫家梵谷在1888年繪畫的，它展現了他對黃色的熱愛和對自然美的追求。梵谷大膽地運用黃色系，將花瓶裡的14朵向日葵畫得生動而充滿力量。整個畫面灼亮卻不炙人，顯然有意象徵他對未來有著前程似錦的信心。',
                'description2': '《向日葵》是梵谷繪畫的一系列靜物油畫，其中有2幅繪有15朵向日葵，1幅繪有14朵向日葵，另有兩幅繪有12朵向日葵。這些作品被認為是梵谷最著名和最具代表性的作品之一，在現代藝術史上具有重要的地位。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            max=3;            
            break;
        case "paint_irises":
            paintnow = GameObject.FindGameObjectsWithTag("irises");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：鳶尾花 Irises',
                'author': '作者：梵谷',
                'year': '創作年份：1889',
                'size': '畫布尺寸：71 x 93 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：美國 加州洛杉磯市保羅蓋提博物館',
                'description1': '這幅作品是梵谷在聖保羅醫院的精神病院中創作的，他在此期間創作了很多風景和花卉的作品。《鳶尾花》是他在1889年創作的一幅油畫，它描繪了一群鮮艷的鳶尾花。',
                'description2': '在這幅作品中，梵谷運用了明亮的色彩和簡潔的筆觸，表現出了鳶尾花的美麗和生命力。他也運用了對比的手法，將鮮艷的鳶尾花和深色的背景形成了強烈的對比。',
                'description3': '這幅作品展現出了梵谷對自然和花卉的熱愛，也表達了他對生命和美的追求。他通過對鳶尾花的描繪，表現了自然的力量和生命的脆弱。他也通過色彩和筆觸的運用，創造出了一種夢幻般的氛圍。',
                'description4': '《鳶尾花》被認為是梵谷的代表作之一，它不僅展現了他獨特的藝術風格和技巧，也反映了他對自然和生命的深刻感受。它也成為了印象派和後印象派藝術的重要代表作。',
                'description5': '這幅作品也被稱為是梵谷畫作中的“療癒之花”，因為它展現出了一種安寧和平靜的氛圍，可以幫助人們減輕壓力和焦慮。它也成為了許多人喜愛的藝術品，被廣泛收藏和展出。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            max=6;            
            break;
        case "paint_potato":
            paintnow = GameObject.FindGameObjectsWithTag("potato");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：吃馬鈴薯的人 The Potato Eaters',
                'author': '作者：梵谷',
                'year': '創作年份：1885',
                'size': '畫布尺寸：82 x 114 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：荷蘭 阿姆斯特丹梵谷美術館',
                'description1': '在這幅畫裡，梵谷用樸實的模特來顯示真正的平民。梵谷說，「我想傳達的觀點是，借著一個油燈的光線，吃馬鈴薯的人用他們同一雙在土地上工作的手從盤子裡抓起馬鈴薯：他們誠實地自食其力」。',
                'description2': '這幅作品展示了梵谷對於描繪人物的細膩觀察和對光線的巧妙運用。雖然畫中的氛圍相對陰暗，但通過細緻的筆觸和色彩層次，梵谷成功地捕捉到了這個平凡場景中的情感和人性。《吃馬鈴薯的人》現在被收藏在荷蘭阿姆斯特丹梵谷美術館中。'
                }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            max=3;        
            break;
        case "paint_blossom":
            paintnow = GameObject.FindGameObjectsWithTag("blossom");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
            'paint_name': '作品名稱：盛開的杏花 Almond Blossoms',
            'author': '作者：梵谷',
            'year': '創作年份：1890',
            'size': '畫布尺寸：73 × 92 cm',
            'type': '繪畫類型：油畫',
            'locate': '館藏地點：荷蘭 阿姆斯特丹梵谷博物館',
            'description1': '1888年，梵谷在法國南部迎來了他繪畫生涯中產量最高的時期。1888年3月當梵谷到達阿爾勒時，果園裡果樹的花朵即將盛開。杏樹、桃樹和李樹的花朵激勵著他，在一個月之內，梵谷繪製了十四幅開花的果樹。',
            'description2': '對於這種題材，梵谷作畫的速度接近每天一張畫。在4月21日梵谷寫給弟弟提奧的信中，說他「不得不找一些新的東西，因為果園裡的花朵幾乎快謝完了」。梵谷的作品反映了他對於日本木刻的興趣。',
            'description3': '梵谷收集了數百幅日本浮世繪，在他1887年的兩幅作品中，梵谷使用了一些浮世繪的畫法，以表示對廣重的敬意。梵谷的日本風格畫作代表了他對於平靜的渴望，正如在給他妹妹的信中所說的「可以肯定地說，如此多的',
            'description4': '平靜比藥店裡賣的所有東西對我的病來說都更有療效」。法國南部地區和開花的樹似乎把梵谷從低迷的狀態下喚醒，變得方向明確且富有活力。他寫道，「我忙於繪製那些開花的樹，我想把普羅旺斯果園令人驚嘆的喜悅畫下來」。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            max=5;            
            break;
        case "paint_church":
            paintnow = GameObject.FindGameObjectsWithTag("church");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：奧維爾教堂 The Church at Auvers',
                'author': '作者：梵谷',
                'year': '創作年份：1890',
                'size': '畫布尺寸：74 × 94 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：巴黎 奧賽博物館',
                'description1': '藝評家崔伯特對梵谷以教堂為背景的創作，有以下的說法：「因為背景前的路面左右分開是關鍵性的道路……這條路右側通往墳場，左面有一背向觀眾向前行的女人，似乎也象徵著從此遠離教堂。」',
                'description2': '梵谷畫無門的教堂的後方，似乎也可象徵他生涯中為教堂背棄的痛苦。1890 年 6 月梵谷所創作的『奧維的教堂』中，深藍色的天空重重的壓向地面，和呈 V 字形的淺色地面的構圖，剛好相互呼應。',
                'description3': '神秘而陰暗的玻璃窗和戶外明朗的色調形成對比，以及線條的律動看似穩定卻內藏著起伏不定的不安。這是梵谷在所有作品中充滿矛盾以及統一的一件作品，似乎早已預知即將死亡的警鐘之作。',
                'description4': '《奧維的教堂》是在他死前約一個月所畫的，使用上下起伏的獨特筆法，把天空描繪得像深海一樣地劇烈翻騰，由於這座教堂到現在還保持原樣地聳立在當地，所以，它是梵谷當年描繪的對象，似乎毫無疑問。',
                'description5': '可是，從畫面左下方道路上行走的婦人背影，由她頭上所戴的帽子來看，應該是梵谷誕生地荷蘭的服飾。',
                'description6': '梵谷是一位很少憑空描繪想像之物的畫家，至少，在來到奧維以前是如此。隨著死亡的迫近，才開始憑藉著想像來畫畫。梵谷是否一邊讓心靈飄向遠方的故鄉，而一邊畫著晝呢？'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            page7 = $"{root.description6}";
            max=7;            
            break;
        case "paint_wheatfield":
            paintnow = GameObject.FindGameObjectsWithTag("wheatfield");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：麥田群鴉 Wheat Field with Crows',
                'author': '作者：梵谷',
                'year': '創作年份：1890',
                'size': '畫布尺寸：50 x 103 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：荷蘭 阿姆斯特丹梵谷美術館',
                'description1': '在完成「麥田群鴉」之後的兩個星期，梵谷即舉槍自盡。這幅畫明顯地充滿騷動與不安，可以清楚地看成是梵谷的最後絕唱。畫中的道路像是攤開的手腳，憤然伸進麥田裏；一群烏鴉驟然飛起，好像被槍聲驚嚇到一般。',
                'description2': '梵谷描繪寬曠的田野景色，但他已不再如從前，精心描摹草叢、茅舍、樹木，反而用簡化的造型，讓畫面上只流動著色彩和韻律。這幅畫明白反映了他那些日子的心境，在這幅畫中，他試圖表達他的',
                'description3': '「悲傷與極度的寂寞」：透過不尋常的寬畫幅，麥田延伸得特別寬闊，並在畫幅前景處開出三條通道。讓觀者不自在的是，我們不知道地平線和路的盡頭究竟在何處？',
                'description4': '在麥田裡，或是在畫幅之外？一般常用在寬廣、開放的田野上的正常結構透視表現法，在此全被顛倒了過來：畫中的線條走向是由地平線向畫面的前方匯集，畫面上的空間完全沒有視點中心，藍天和黃色的田野',
                'description5': '彼此朝反方向推擠，一大群烏鴉劃過天地的分界，飛向未知的前方。和他澎湃騷動的線條不同的是，整幅畫的空間充滿一種簡明的寬潤與單純，',
                'description6': '用色降低到只剩三原色，和互為補色的藍色天空/黃色玉米、紅色路徑/綠色路邊草莖。地平線乃由藝術家的內心世界來認定，而非自畫框或畫布上決定，這條地平線呈現的既非一種景緻',
                'description7': '也並非由主宰空間的事物所創造，因此整幅畫上都沒有垂直的線條。總體而言，畫上的局部、整體、及遠近，都沒有明確地區隔開來。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            page7 = $"{root.description6}";
            page8 = $"{root.description7}";
            max=8;            
            break;
        case "paint_treeroots":
            paintnow = GameObject.FindGameObjectsWithTag("treeroots");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '樹根 Tree Roots',
                'author': '作者：梵谷',
                'year': '創作年份：1890',
                'size': '畫布尺寸：50 x 100 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：荷蘭 阿姆斯特丹梵谷美術館',
                'description1': '這幅畫是梵谷在1890年繪畫的，受攝影的影響，他將交錯扭曲的樹幹和樹根畫得栩栩如生，呈現出生命力的強大和自然的力量。這幅畫使用了長方形的畫布，非常適合於注重前景的風景，像相片中的特寫一樣。據說這是梵谷生前最後一幅作品之一。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            max=2;            
            break;
        case "paint_starrynight":
            paintnow = GameObject.FindGameObjectsWithTag("starrynight");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
            'paint_name': '作品名稱：星夜 The Starry Night',
            'author': '作者：梵谷',
            'year': '創作年份：1890',
            'size': '畫布尺寸：74 × 93 cm',
            'type': '繪畫類型：油畫',
            'locate': '館藏地點：紐約 現代藝術博物館',
            'description1': '油畫中的主色調藍色代表不開心、陰沉的感覺。很粗的筆觸代表憂愁。畫中景象是一個望出窗外的景象。畫中的樹是柏樹，但畫得像黑色火舌一般，直上雲端，令人有不安之感。天空的紋理像渦狀星系，並伴隨眾多星點，',
            'description2': '而月亮則是以昏黃的月蝕形式出現。整幅畫中，底部的村落是以平直、粗短的線條繪畫，表現出一種寧靜；但與上部粗獷彎曲的線條卻產生強烈的對比，在這種高度誇張變形和強烈視覺對比中體現出了畫家躁動不安的情感',
            'description3': '和迷幻的意象世界。梵谷生前非常欣賞日本浮世繪《冨嶽三十六景》中的《神奈川沖浪裏》，而《星夜》中天空的渦狀星雲畫風被認為參考並融入了《神奈川沖浪裏》的元素。梵谷的作品反映了他對於日本木刻的興趣。',
            'description4': '科學人員發現梵谷的後期作品，包括《星夜》在內，包含有一種物理上稱為「湍流」的神韻，並推測此神韻來源於梵谷由於長期處於癲狂狀態中而得到超於常人的感悟能力和繪畫表述能力。',
            'description5': '而在2004年3月4日，美國宇航局和歐洲太空總署公布了一張哈勃太空望遠鏡拍攝的太空照片，並稱「這幅太空攝影作品與梵谷的名作《星夜》有『異常相似』之處。」',
            'description6': '其中，哈勃太空望遠鏡所拍照片為一顆名為「麒麟座V838」的恆星周圍的景象。該恆星位於麒麟座方向，距離地球2萬光年。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            page7 = $"{root.description6}";
            max=7;            
            break;
        case "paint_bandaged":
            paintnow = GameObject.FindGameObjectsWithTag("bandaged");
            foreach(GameObject t in paintnow)
            {
                if(t.name =="descr")
                {                    
                    ani=t.GetComponent<Animator>();
                }
                if(t.name =="descr_text")
                {
                    tt=t.GetComponent<Text>();
                }
            }
            json = @"{
                'paint_name': '作品名稱：耳朵綁上繃帶的自畫像 Self Portrait with Bandaged Ear',
                'author': '作者：梵谷',
                'year': '創作年份：1889',
                'size': '畫布尺寸：60 x 50 cm',
                'type': '繪畫類型：油畫',
                'locate': '館藏地點：英國 倫敦可陶德學院畫廊',
                'description1': '這幅自畫像是梵谷在1889年畫的，他在自畫像中戴著一頂黑色毛皮藍色帽子和一件綠色大衣，耳朵上纏著繃帶，一直延伸到下巴下方。他的前視略微向右傾斜，超出了畫面。他身後是一扇敞開的窗戶，這也出現在他創作的其他肖像畫的背景中。',
                'description2': '這幅自畫像中呈現出梵谷對日本文化和木版畫的影響，畫架上放著一幅日本木版畫《風景中的藝妓》，這幅畫經鑑定為佐藤東京於1870年代出版的作品。梵谷在自畫像中使用了厚塗筆劃，創造了一個紋理，從畫布上出現並為平面增加尺寸。膚色柔和，帶有綠色和淡黃色調。',
                'description3': '耳朵上的繃帶是這幅自畫像最引人注目的特徵之一，它暗示著梵谷最著名的衝突。梵谷在自畫像中使用了一面鏡子，這就是為什麼有些人錯誤地認為他失去了右耳而不是左耳的原因。',
                'description4': '這幅自畫像是梵谷最著名的作品之一，它展現了他獨特的藝術風格和技巧，也反映了他對自我形象和內心狀態的深刻思考。它也被認為是表達了梵谷對藝術和生命的追求，以及他對自己和世界的反思。',
                'description5': '這幅自畫像現在收藏在英國倫敦可陶德學院畫廊，成為了繪畫藝術的重要珍品之一，也吸引了許多人的關注和欣賞。'
            }";
            root = JsonConvert.DeserializeObject<Root>(json);
            page1 = $"{root.paint_name}\n{root.author}\n{root.year}\n{root.size}\n{root.type}\n{root.locate}";
            page2 = $"{root.description1}";
            page3 = $"{root.description2}";
            page4 = $"{root.description3}";
            page5 = $"{root.description4}";
            page6 = $"{root.description5}";
            max=6;            
            break;
        default:
            break;
        }
        ani.Play("intro_flip",  -1, 0f);
        if(way=="left")
        {
            globall.page-=1;
            if(globall.page<min)
            globall.page=max;
        }else if(way=="right")
        {
            globall.page+=1;                     
            if(globall.page>max)
            globall.page=min;
        }
        switch(globall.page)
        {
            case 1:
            tt.text = page1;
            break;
            case 2:
            tt.text = page2;
            break;
            case 3:
            tt.text = page3;
            break;
            case 4:
            tt.text = page4;
            break;
            case 5:
            tt.text = page5;
            break;
            case 6:
            tt.text = page6;
            break;
            case 7:
            tt.text = page7;
            break;
            case 8:
            tt.text = page8;
            break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{globall.paintname}");
    }
    IEnumerator wait(float tim)
    {                
        //this.StartCoroutine(wait(1));
        yield return new WaitForSeconds(tim);
    }
}