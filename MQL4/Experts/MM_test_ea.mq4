#property strict

input int milliseconds = 10;
input string tag_prefix = "MM_TEST_";

#import "MM0423.dll"
string SetMemString(string tag,string msg);
string GetMemString(string tag);
#import

const string obj_prefix = "__TEST__";


int OnInit(){
    EventSetMillisecondTimer(milliseconds);
    return(INIT_SUCCEEDED);
}


void OnDeinit(const int reason){
    EventKillTimer();
    for(int i=ObjectsTotal()-1; i>=0; i--){
        string name = ObjectName(i);
        if(StringFind(name, obj_prefix)>=0) ObjectDelete(name);
    }
}


void OnTimer(){
    
    // どうせなら価格データで試したいけどこのコードを書いてる現在が
    // 土曜日で価格が動いてないのでしょうがないので
    // TimeLocal()とGetTickCount()とrand()で得た値
    // を適当に書き込んでみます(´・ω・｀)
    
    srand(GetTickCount());
    
    /*
    こんな感じのものを書き込んでみたいと思います
    
    time, 2016.04.23 HH:MM:SS
    
    GetTickCount, 数値
    
    rand0, 数値, 数値, 数値, 数値\n
    rand1, 数値, 数値, 数値, 数値\n
    rand2, 数値, 数値, 数値, 数値\n
    rand3, 数値, 数値, 数値, 数値\n
    rand4, 数値, 数値, 数値, 数値\n
    rand5, 数値, 数値, 数値, 数値\n
    rand6, 数値, 数値, 数値, 数値\n
    rand7, 数値, 数値, 数値, 数値\n
    rand8, 数値, 数値, 数値, 数値\n
    rand9, 数値, 数値, 数値, 数値
    */
    
    
    // 時刻
    SetMemString(tag_prefix+"TIME",
                 "time"+","+TimeToStr(TimeLocal(), TIME_DATE|TIME_SECONDS));
    
    // GetTickCount
    SetMemString(tag_prefix+"GETTICKCOUNT",
                 "GetTickCount"+","+IntegerToString(GetTickCount()));
    
    
    // 特に意味はないけど配列の数値を書き込む感じにします
    double val[10][4]; ZeroMemory(val);
    int ilimit = ArrayRange(val, 0);
    int jlimit = ArrayRange(val, 1);
    for(int i=0; i<ilimit; i++){
        for(int j=0; j<jlimit; j++){
            val[i][j] = (double)rand();
        }
    }
    
    string s = "";
    for(int i=0; i<ilimit; i++){
        s += "rand"+IntegerToString(i)+",";
        for(int j=0; j<jlimit; j++){
            s += DoubleToStr(val[i][j], 0) + ((j<jlimit-1)? ",": (i<ilimit-1)? "\n": "");
        }
    }
    
    // rand
    SetMemString(tag_prefix+"RAND", s);
    
    
    // そうだ(´・ω・｀)　tag_prefix+"PY"というのがあったらMT4の画面に描画するようにしてみます
    // これはpythonから書き込みさせる予定です
    string py = GetMemString(tag_prefix+"PY");
    if(py!="" && py!=NULL){
        string a[];
        int limit = StringSplit(py, '\n', a);
        for(int i=0; i<limit; i++){
            obj(a[i], i);
        }
    }
    
}

void obj(string text, int row){
    string name = obj_prefix+string(row);
    int fs = 24;
    ObjectCreate(0, name, OBJ_LABEL, 0, 0, 0);
    ObjectSetInteger(0, name, OBJPROP_XDISTANCE, 10);
    ObjectSetInteger(0, name, OBJPROP_YDISTANCE, int(fs*1.75*row));
    ObjectSetText(name, text, fs, "ＭＳ ゴシック", clrWhite);
    ChartRedraw();
}
