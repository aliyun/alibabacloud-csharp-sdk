// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthResponseBody : TeaModel {
        /// <summary>
        /// <para>The credential for media playback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sstyYuew6789000000xtt7TYUh****</para>
        /// </summary>
        [NameInMap("PlayAuth")]
        [Validation(Required=false)]
        public string PlayAuth { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The thumbnail URL of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The duration of the media file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The status of the media file. For more information about the value range and description, see <a href="~~52839#title-vqg-8cz-7p8~~">Status: the status of a video</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VOD</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the media file.</para>
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
