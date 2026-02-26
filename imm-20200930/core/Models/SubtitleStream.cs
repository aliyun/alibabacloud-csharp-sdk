// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SubtitleStream : TeaModel {
        /// <summary>
        /// <para>The bitrate. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The full name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MOV text</para>
        /// </summary>
        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mov_text</para>
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// <para>The tag of the codec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0x67337874</para>
        /// </summary>
        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        /// <summary>
        /// <para>The description of the codec tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tx3g</para>
        /// </summary>
        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        /// <summary>
        /// <para>The subtitle content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The duration of the subtitle stream in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71.378</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The height of the subtitles. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// <para>The index number of the subtitle stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// <para>The subtitle language in the BCP 47 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The start time of the subtitle stream in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// <para>The width of the subtitles. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
