# coding: utf-8

import ctypes


def main():
    lib = ctypes.windll.LoadLibrary('MM0423.dll')
    lib.SetMemString.argtypes = [ctypes.c_wchar_p, ctypes.c_wchar_p]
    lib.GetMemString.argtypes = [ctypes.c_wchar_p]
    lib.GetMemString.restype = ctypes.c_wchar_p
    
    tag_prefix = 'MM_TEST_'
    
    print lib.GetMemString(tag_prefix+'TIME')
    print lib.GetMemString(tag_prefix+'GETTICKCOUNT')
    print lib.GetMemString(tag_prefix+'RAND')
    
    
if __name__=='__main__':
    main()
