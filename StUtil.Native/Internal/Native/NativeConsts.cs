﻿using System;

namespace StUtil.Internal.Native
{
    public static class NativeConsts
    {
        public const byte AC_SRC_ALPHA = 0x01;
        public const byte AC_SRC_OVER = 0x00;
        public const int CDDS_ITEM = 0x10000;
        public const int CDDS_ITEMPOSTPAINT = (CDDS_ITEM | CDDS_POSTPAINT);
        public const int CDDS_ITEMPREPAINT = (CDDS_ITEM | CDDS_PREPAINT);
        public const int CDDS_POSTPAINT = 0x2;
        public const int CDDS_PREPAINT = 0x1;
        public const int CDRF_DODEFAULT = 0x0;
        public const int CDRF_NOTIFYITEMDRAW = 0x20;
        public const int CDRF_NOTIFYPOSTPAINT = 0x10;
        public const int FILE_ATTRIBUTE_DIRECTORY = 0x10;
        public const int FILE_ATTRIBUTE_NORMAL = 0x80;
        public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 0x100;
        public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x2000;
        public const int FORMAT_MESSAGE_FROM_HMODULE = 0x800;
        public const int FORMAT_MESSAGE_FROM_STRING = 0x400;
        public const int FORMAT_MESSAGE_FROM_SYSTEM = 0x1000;
        public const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x200;
        public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 0xFF;
        public const int HC_ACTION = 0;
        public const long HSCROLL = 0x100000;
        public const int HTBOTTOM = 15;
        public const int HTBOTTOMLEFT = 16;
        public const int HTBOTTOMRIGHT = 17;
        public const int HTLEFT = 10;
        public const int HTRIGHT = 11;
        public const int HTTOP = 12;
        public const int HTTOPLEFT = 13;
        public const int HTTOPRIGHT = 14;
        public const int HTTRANSPARENT = -1;
        public const int LVM_FIRST = 0x1000;
        public const int LVM_SETIMAGELIST = (LVM_FIRST + 3);
        public const int LVSIL_NORMAL = 0;
        public const int LVSIL_SMALL = 1;
        public const int LVSIL_STATE = 2;
        public const int MAX_CAPTION_LENGTH = 100;
        public const int MAX_PATH = 260;
        public const int NM_CUSTOMDRAW = NM_FIRST - 12;
        public const int NM_FIRST = 0;
        public const string SE_DEBUG_NAME = "SeDebugPrivilege";
        public const uint SE_PRIVILEGE_ENABLED = 0x00000002;
        public const uint TB_BUTTONCOUNT = 0x0418;
        public const uint TB_GETBUTTON = 0x0417;
        public const uint TOKEN_ADJUST_PRIVILEGES = 0x0020;
        public const uint TOKEN_QUERY = 0x0008;
        public const int TV_FIRST = 0x1100;
        public const int TVM_SETIMAGELIST = (TV_FIRST + 9);
        public const int TVSIL_NORMAL = 0;
        public const int TVSIL_STATE = 2;
        public const int ULW_ALPHA = 0x00000002;
        public const int ULW_COLORKEY = 0x00000001;
        public const int ULW_OPAQUE = 0x00000004;
        public const byte VK_CAPITAL = 0x14;
        public const byte VK_CONTROL = 0x11;
        public const byte VK_MENU = 0x12;
        public const byte VK_SHIFT = 0x10;
        public const long VSCROLL = 0x200000;
        public const int WH_KEYBOARD = 2;
        public const int WH_KEYBOARD_LL = 13;
        public const int WH_MOUSE = 7;
        public const int WH_MOUSE_LL = 14;
        public const int WM_ACTIVATEAPP = 0x01C;
        public const int WM_ERASEBKGND = 0x0014;
        public const int WM_GETMINMAXINFO = 0x0024;
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;
        public const int WM_LBUTTONDBLCLK = 0x203;
        public const int WM_LBUTTONDOWN = 0x201;
        public const int WM_LBUTTONUP = 0x202;
        public const int WM_MBUTTONDBLCLK = 0x209;
        public const int WM_MBUTTONDOWN = 0x207;
        public const int WM_MBUTTONUP = 0x208;
        public const int WM_MOUSEMOVE = 0x200;
        public const int WM_MOUSEWHEEL = 0x020A;
        public const int WM_NCACTIVATE = 0x0086;
        public const int WM_NCHITTEST = 0x0084;
        public const int TVS_NOHSCROLL = 0x8000;
        public const int TVM_GETEXTENDEDSTYLE = TV_FIRST + 45;
        public const int TVM_SETAUTOSCROLLINFO = TV_FIRST + 59;
        public const int TVM_SETEXTENDEDSTYLE = TV_FIRST + 44;
        public const int PRF_CLIENT = 4;
        public const int TVS_EX_FADEINOUTEXPANDOS = 0x0040;
        public const int TVS_EX_AUTOHSCROLL = 0x0020;
        public const int WM_PRINTCLIENT = 0x0318;
        public const int WM_RBUTTONDBLCLK = 0x206;
        public const int WM_RBUTTONDOWN = 0x204;
        public const int WM_RBUTTONUP = 0x205;
        public const int WM_SETREDRAW = 11;
        public const int WM_SYSKEYDOWN = 0x104;
        public const int WM_SYSKEYUP = 0x105;
        public const int WM_XBUTTONDBLCLK = 0x20D;
        public const int WM_XBUTTONDOWN = 0x20B;
        public const int WM_XBUTTONUP = 0x20C;
        public const int WS_EX_LAYERED = 0x00080000;
        public const int WS_EX_NOACTIVATE = 0x08000000;
        public const int WS_EX_TOOLWINDOW = 0x00000080;
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public static IntPtr HWND_TOPMOST = IntPtr.Zero;
        public static Guid IID_IShellFolder = new Guid("000214E6-0000-0000-C000-000000000046");
    }
}