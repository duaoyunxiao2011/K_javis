﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;

namespace 语音
{
    public static class X在线播放
    {
        private static IX合成 _IX合成 = new X在线合成();

        public static void 播放(string 文本)
        {
            if (string.IsNullOrEmpty(文本.Trim()))
            {
                return;
            }
            var __wave = _IX合成.合成(文本);
            SoundPlayer soundPlayer = new SoundPlayer(__wave);
            soundPlayer.Stop();
            soundPlayer.PlaySync();
            soundPlayer.Dispose();
            __wave.Close();
        }

        public static void 播放(string appid, string 文本)
        {
            _IX合成.登录(appid);
            var __wave = _IX合成.合成(文本);
            SoundPlayer soundPlayer = new SoundPlayer(__wave);
            soundPlayer.Stop();
            soundPlayer.PlaySync();
            soundPlayer.Dispose();
            __wave.Close();
        }

    }
}
