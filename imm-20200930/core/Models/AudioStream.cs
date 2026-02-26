// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AudioStream : TeaModel {
        /// <summary>
        /// <para>The bitrate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>320087</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The sound channel layout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stereo</para>
        /// </summary>
        [NameInMap("ChannelLayout")]
        [Validation(Required=false)]
        public string ChannelLayout { get; set; }

        /// <summary>
        /// <para>The number of sound channels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public long? Channels { get; set; }

        /// <summary>
        /// <para>The full name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAC (Advanced Audio Coding)</para>
        /// </summary>
        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aac</para>
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// <para>The tag of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0x6134706d</para>
        /// </summary>
        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        /// <summary>
        /// <para>The description of the codec tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp4a</para>
        /// </summary>
        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        /// <summary>
        /// <para>The time base of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/44100</para>
        /// </summary>
        [NameInMap("CodecTimeBase")]
        [Validation(Required=false)]
        public string CodecTimeBase { get; set; }

        /// <summary>
        /// <para>The duration of the audio stream in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.690667</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The number of frames.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173</para>
        /// </summary>
        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

        /// <summary>
        /// <para>The index number of the audio stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// <para>The audio language in the BCP 47 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The lyric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Lyric")]
        [Validation(Required=false)]
        public string Lyric { get; set; }

        /// <summary>
        /// <para>The sample format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fltp</para>
        /// </summary>
        [NameInMap("SampleFormat")]
        [Validation(Required=false)]
        public string SampleFormat { get; set; }

        /// <summary>
        /// <para>The sampling rate. Unit: Hz.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48000</para>
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public long? SampleRate { get; set; }

        /// <summary>
        /// <para>The start time of the audio stream in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0235</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// <para>The time base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/48000</para>
        /// </summary>
        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

    }

}
