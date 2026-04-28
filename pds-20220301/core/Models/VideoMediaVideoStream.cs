// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoMediaVideoStream : TeaModel {
        /// <summary>
        /// <para>The bitrate of the video stream. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>108420</para>
        /// </summary>
        [NameInMap("bitrate")]
        [Validation(Required=false)]
        public string Bitrate { get; set; }

        /// <summary>
        /// <para>The video encoding mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h264</para>
        /// </summary>
        [NameInMap("code_name")]
        [Validation(Required=false)]
        public string CodeName { get; set; }

        /// <summary>
        /// <para>The duration of the video stream. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22.88</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The number of video frames.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("frame_count")]
        [Validation(Required=false)]
        public string FrameCount { get; set; }

    }

}
