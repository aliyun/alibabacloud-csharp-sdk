// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaResponseBody : TeaModel {
        /// <summary>
        /// <para>The URLs of the media files that failed to be registered.</para>
        /// </summary>
        [NameInMap("FailedFileURLs")]
        [Validation(Required=false)]
        public List<string> FailedFileURLs { get; set; }

        /// <summary>
        /// <para>The media files that are registered, including newly registered and repeatedly registered media files.</para>
        /// </summary>
        [NameInMap("RegisteredMediaList")]
        [Validation(Required=false)]
        public List<RegisterMediaResponseBodyRegisteredMediaList> RegisteredMediaList { get; set; }
        public class RegisterMediaResponseBodyRegisteredMediaList : TeaModel {
            /// <summary>
            /// <para>The URL of the media file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://****.oss-cn-shanghai.aliyuncs.com/vod_sample_01.mp4</para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The ID of the media file that is registered with ApsaraVideo VOD. If the registered media file is an audio or video file, the value of this parameter is the same as that of the VideoId parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d97af32828084d1896683b1aa38****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>Indicates whether the media file is newly registered or repeatedly registered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The media file is newly registered.</description></item>
            /// <item><description><b>false</b>: The media file is repeatedly registered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NewRegister")]
            [Validation(Required=false)]
            public bool? NewRegister { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14F43C5C-8033-448B-AD04F64E5098****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
