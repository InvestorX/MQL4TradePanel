# coding: utf-8

import sys
import random
import ctypes

from PySide.QtGui import * 
from PySide.QtCore import * 


lib = ctypes.windll.LoadLibrary('MM0423.dll')
lib.SetMemString.argtypes = [ctypes.c_wchar_p, ctypes.c_wchar_p]
lib.GetMemString.argtypes = [ctypes.c_wchar_p]
lib.GetMemString.restype = ctypes.c_wchar_p

tag_prefix = 'MM_TEST_'


class TestTable(QTableWidget):
    def __init__(self, xsize=400, ysize=600, row=15, col=5):
        super(TestTable, self).__init__()
        self.row = row
        self.col = col
        self.resize(xsize, ysize)
        self.set_ui()
    
    def set_ui(self):
        self.setWindowTitle('test table')
        self.setRowCount(self.row)
        self.setColumnCount(self.col)
        self.hheader = self.horizontalHeader()
        self.hheader.setResizeMode(QHeaderView.Stretch)
        self.vheader = self.verticalHeader()
        self.vheader.setResizeMode(QHeaderView.Stretch)
    
    def set(self, r, c, v):
        if 0 <= r <self.row and 0 <= c <self.col:
            self.setItem(r, c, QTableWidgetItem(str(v)))
    
    def get(self, r, c):
        if 0 <= r <self.row and 0 <= c <self.col:
            return self.item(r, c).text()
        return None
    
    def start_timer(self):
        self.timer = QTimer()
        self.timer.timeout.connect(self.timerevent)
        self.timer.start(10)
    
    def timerevent(self):
        """
        MT4がメモリマップドファイルに書いたやつを読み取って見ます
        それとpythonからもなんか書いてみます
        """
        mm_time = lib.GetMemString(tag_prefix+'TIME').split(',')
        for i,e in enumerate(mm_time):
            self.set(0, i, e)
        
        mm_gettickcount = lib.GetMemString(tag_prefix+'GETTICKCOUNT').split(',')
        for i,e in enumerate(mm_gettickcount):
            self.set(1, i, e)
        
        mm_rand = lib.GetMemString(tag_prefix+'RAND').split('\n')
        for i,e in enumerate(mm_rand):
            for j,v in enumerate(e.split(',')):
                self.set(2+i, j, v)
        
        s = '\n'.join([' '*random.randint(0,20)+'(^q^)' for i in range(10)])
        lib.SetMemString(tag_prefix+'PY', s)


def main():
    app = QApplication(sys.argv)
    table = TestTable()
    table.start_timer()
    table.show()
    sys.exit(app.exec_())


if __name__ == '__main__':
    main()
