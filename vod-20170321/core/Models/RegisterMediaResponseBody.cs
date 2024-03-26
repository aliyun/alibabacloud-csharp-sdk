// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RegisterMediaResponseBody : TeaModel {
        /// <summary>
        /// The URLs of the media files that failed to be registered.
        /// </summary>
        [NameInMap("FailedFileURLs")]
        [Validation(Required=false)]
        public List<string> FailedFileURLs { get; set; }

        /// <summary>
        /// The media files that are registered, including newly registered and repeatedly registered media files.
        /// </summary>
        [NameInMap("RegisteredMediaList")]
        [Validation(Required=false)]
        public List<RegisterMediaResponseBodyRegisteredMediaList> RegisteredMediaList { get; set; }
        public class RegisterMediaResponseBodyRegisteredMediaList : TeaModel {
            /// <summary>
            /// The URL of the media file.
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// The ID of the media file that is registered with ApsaraVideo VOD. If the registered media file is an audio or video file, the value of this parameter is the same as that of the VideoId parameter.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// Indicates whether the media file is newly registered or repeatedly registered. Valid values:
            /// 
            /// *   **true**: The media file is newly registered.
            /// *   **false**: The media file is repeatedly registered.
            /// </summary>
            [NameInMap("NewRegister")]
            [Validation(Required=false)]
            public bool? NewRegister { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
