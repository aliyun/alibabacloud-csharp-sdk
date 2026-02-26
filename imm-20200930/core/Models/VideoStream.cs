// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoStream : TeaModel {
        /// <summary>
        /// <para>The average frame rate of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25/1</para>
        /// </summary>
        [NameInMap("AverageFrameRate")]
        [Validation(Required=false)]
        public string AverageFrameRate { get; set; }

        /// <summary>
        /// <para>The bit depth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("BitDepth")]
        [Validation(Required=false)]
        public long? BitDepth { get; set; }

        /// <summary>
        /// <para>The bitrate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407765</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The full name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10</para>
        /// </summary>
        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// <para>The tag of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0x31637661</para>
        /// </summary>
        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        /// <summary>
        /// <para>The description of the codec tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avc1</para>
        /// </summary>
        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        /// <summary>
        /// <para>The time base of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1373627/83160000</para>
        /// </summary>
        [NameInMap("CodecTimeBase")]
        [Validation(Required=false)]
        public string CodecTimeBase { get; set; }

        /// <summary>
        /// <para>The primary colors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bt709</para>
        /// </summary>
        [NameInMap("ColorPrimaries")]
        [Validation(Required=false)]
        public string ColorPrimaries { get; set; }

        /// <summary>
        /// <para>The color range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tv</para>
        /// </summary>
        [NameInMap("ColorRange")]
        [Validation(Required=false)]
        public string ColorRange { get; set; }

        /// <summary>
        /// <para>The color space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bt709</para>
        /// </summary>
        [NameInMap("ColorSpace")]
        [Validation(Required=false)]
        public string ColorSpace { get; set; }

        /// <summary>
        /// <para>The color transfer function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bt709</para>
        /// </summary>
        [NameInMap("ColorTransfer")]
        [Validation(Required=false)]
        public string ColorTransfer { get; set; }

        /// <summary>
        /// <para>The display aspect ratio of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16:9</para>
        /// </summary>
        [NameInMap("DisplayAspectRatio")]
        [Validation(Required=false)]
        public string DisplayAspectRatio { get; set; }

        /// <summary>
        /// <para>The duration of the video stream. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.88</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The number of frames.</para>
        /// 
        /// <b>Example:</b>
        /// <para>572</para>
        /// </summary>
        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

        /// <summary>
        /// <para>The frame rate of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25/1</para>
        /// </summary>
        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        /// <summary>
        /// <para>Specifies whether the video stream contains B frames.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HasBFrames")]
        [Validation(Required=false)]
        public long? HasBFrames { get; set; }

        /// <summary>
        /// <para>The image height of the video stream. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// <para>The index number of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// <para>The language used in the video stream. The language is indicated by using a BCP 47 language tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// <para>The pixel format of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yuv420p</para>
        /// </summary>
        [NameInMap("PixelFormat")]
        [Validation(Required=false)]
        public string PixelFormat { get; set; }

        /// <summary>
        /// <para>The profile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The image rotation angle of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("Rotate")]
        [Validation(Required=false)]
        public string Rotate { get; set; }

        /// <summary>
        /// <para>The sampling aspect ratio of the video stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1:1</para>
        /// </summary>
        [NameInMap("SampleAspectRatio")]
        [Validation(Required=false)]
        public string SampleAspectRatio { get; set; }

        /// <summary>
        /// <para>The start time of the video stream. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// <para>The time base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/12800</para>
        /// </summary>
        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

        /// <summary>
        /// <para>The image width of the video stream. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
