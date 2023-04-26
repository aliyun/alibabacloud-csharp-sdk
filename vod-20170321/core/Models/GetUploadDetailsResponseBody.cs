// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadDetailsResponseBody : TeaModel {
        /// <summary>
        /// The time when the information about the media file was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        /// <summary>
        /// The size of the uploaded file. Unit: byte.
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetUploadDetails**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The upload ratio.
        /// </summary>
        [NameInMap("UploadDetails")]
        [Validation(Required=false)]
        public List<GetUploadDetailsResponseBodyUploadDetails> UploadDetails { get; set; }
        public class GetUploadDetailsResponseBodyUploadDetails : TeaModel {
            /// <summary>
            /// Queries the upload details, such as the upload time, upload ratio, and upload source, about one or more media files based on the media IDs.
            /// </summary>
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// The title of the media file.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The time when the upload job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// The status of the video. For more information about the valid values and value description of the parameter, see the "Status: the status of a video" section of the [Basic structures](~~52839~~) topic.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The upload size. Unit: byte.
            /// </summary>
            [NameInMap("UploadIP")]
            [Validation(Required=false)]
            public string UploadIP { get; set; }

            [NameInMap("UploadRatio")]
            [Validation(Required=false)]
            public float? UploadRatio { get; set; }

            [NameInMap("UploadSize")]
            [Validation(Required=false)]
            public long? UploadSize { get; set; }

            /// <summary>
            /// The time when the upload job was complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UploadSource")]
            [Validation(Required=false)]
            public string UploadSource { get; set; }

            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public string UploadStatus { get; set; }

        }

    }

}
