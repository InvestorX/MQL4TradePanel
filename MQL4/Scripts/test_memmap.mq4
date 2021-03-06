// script
#property strict

#import "MM0423.dll"
string SetMemString(string tag,string msg);
string GetMemString(string tag);
#import


const string obj_prefix = "__TEST__";

void OnDeinit(const int reason){
    PlaySound("tick");
}


void OnStart(){
    
    // このスクリプトで作ったオブジェクトがあったらそれらを削除して終了します
    bool del = false;
    for(int i=ObjectsTotal()-1; i>=0; i--){
        string name = ObjectName(i);
        if(StringFind(name, obj_prefix)>=0) del |= ObjectDelete(name);
    }
    if(del) return;
    
    
    string tag_name = "MEMMAP_TEST"; // メモリマップドファイルのタグ名に使う
    
    obj("　彡 ⌒ ミ");
    obj("(´・ω・｀)実験開始");
    
    // ------------------------------------------------------------------------
    // 何もしないループが何回回るか試してみます
    ulong cnt = 0;
    uint st = GetTickCount();
    uint time_limit = st+1000; // だいたい1000ミリ秒間回します
    
    while(GetTickCount()<time_limit) cnt++;
    obj(StringFormat("空のループだと %d回", cnt));
    
    
    // ------------------------------------------------------------------------
    // SetMemStringで数値を書き込んでみます
    // IntegerToString()で文字列にしてから書き込みます
    cnt = 0;
    st = GetTickCount();
    time_limit = st+1000;
    
    while(GetTickCount()<time_limit) SetMemString(tag_name, IntegerToString(++cnt));
    obj(StringFormat("SetMemStringすると %d回", StringToInteger(GetMemString(tag_name))));
    
    
    // ------------------------------------------------------------------------
    // GetMemString()が何回できるか試してみます
    cnt = 0;
    st = GetTickCount();
    time_limit = st+1000;
    while(GetTickCount()<time_limit){
        string s = GetMemString(tag_name);
        cnt++;
    }
    obj(StringFormat("GetMemStrinした回数 %d回", cnt));
    
    
    // ------------------------------------------------------------------------
    // 大きめのデータを書き込んでみます
    // 5000本ぶんの価格データを書き込んで見ます
    // 文字列に変換して連結して書き込みます
    cnt = 0;
    st = GetTickCount();
    time_limit = st+1000;
    int slen = 0;
    int size = 5000;
    while(GetTickCount()<time_limit){
        string s = "";
        for(int i=0; i<size; i++){
            s += IntegerToString(Time[i])+",";
            s += DoubleToStr(Open[i], _Digits)+",";
            s += DoubleToStr(High[i], _Digits)+",";
            s += DoubleToStr(Low[i], _Digits)+",";
            s += DoubleToStr(Close[i], _Digits)+",";
            s += IntegerToString(Volume[i])+"\n";
        }
        SetMemString(tag_name, s);
        slen = StringLen(s);
        cnt++;
    }
    obj(StringFormat("5000本を何回書き込めたか %d回", cnt));
    obj(StringFormat("1回の書き込み時の文字列の長さ %d文字", slen));
    
    
    // ------------------------------------------------------------------------
    // 上で書き込んだ価格情報を何回読み込めるか試してみます
    cnt = 0;
    slen = 0;
    st = GetTickCount();
    time_limit = st+1000;
    while(GetTickCount()<time_limit){
        string s = GetMemString(tag_name);
        slen = StringLen(s);
        cnt++;
    }
    obj(StringFormat("5000本ぶんのデータを読み込めた回数 %d回", cnt));
    obj(StringFormat("読み込み1回ぶんの文字数 %d文字", slen));
    
    
    obj("終わりです");
    obj("このスクリプトをもう一度実行すると");
    obj("オブジェクトを削除します (´・ω・｀)");
    
    
    return;
}


void obj(string text){
    static int cnt = 0;
    string name = obj_prefix+string(cnt);
    int fs = 24;
    ObjectCreate(0, name, OBJ_LABEL, 0, 0, 0);
    ObjectSetInteger(0, name, OBJPROP_XDISTANCE, 10);
    ObjectSetInteger(0, name, OBJPROP_YDISTANCE, int(fs*1.75*cnt));
    ObjectSetText(name, text, fs, "ＭＳ ゴシック", clrWhite);
    ChartRedraw();
    cnt++;
}

