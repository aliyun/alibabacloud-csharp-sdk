// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The playback credential for the audio or video file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sstyYuew6789000000xtt7TYUh****</para>
        /// </summary>
        [NameInMap("PlayAuth")]
        [Validation(Required=false)]
        public string PlayAuth { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4EBD2BF-5EB0-4476-8829-9D94E1B1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the audio or video file.</para>
        /// </summary>
        [NameInMap("VideoMeta")]
        [Validation(Required=false)]
        public GetVideoPlayAuthResponseBodyVideoMeta VideoMeta { get; set; }
        public class GetVideoPlayAuthResponseBodyVideoMeta : TeaModel {
            /// <summary>
            /// <para>The thumbnail URL of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The duration of the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The status of the audio or video file. For valid values and descriptions, see <a href="~~52839#title-vqg-8cz-7p8~~">Status: audio and video status</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud VOD Video Title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dfde02284a5c46622a097adaf44a****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
