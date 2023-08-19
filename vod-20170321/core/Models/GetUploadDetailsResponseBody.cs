// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadDetailsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the media files that cannot be accessed.
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        /// <summary>
        /// The IDs of the media files that do not exist.
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The upload details.
        /// </summary>
        [NameInMap("UploadDetails")]
        [Validation(Required=false)]
        public List<GetUploadDetailsResponseBodyUploadDetails> UploadDetails { get; set; }
        public class GetUploadDetailsResponseBodyUploadDetails : TeaModel {
            /// <summary>
            /// The time when the upload job was complete. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// The time when the upload job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The device model.
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// The size of the uploaded file. Unit: byte.
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// The ID of the uploaded audio or video.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The time when the information about the media file was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
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

            /// <summary>
            /// The title of the media file.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The IP address of the server that uploads the media file.
            /// </summary>
            [NameInMap("UploadIP")]
            [Validation(Required=false)]
            public string UploadIP { get; set; }

            /// <summary>
            /// The upload ratio.
            /// </summary>
            [NameInMap("UploadRatio")]
            [Validation(Required=false)]
            public float? UploadRatio { get; set; }

            /// <summary>
            /// The upload size. Unit: byte.
            /// </summary>
            [NameInMap("UploadSize")]
            [Validation(Required=false)]
            public long? UploadSize { get; set; }

            /// <summary>
            /// The method that is used to upload the media file.
            /// </summary>
            [NameInMap("UploadSource")]
            [Validation(Required=false)]
            public string UploadSource { get; set; }

            /// <summary>
            /// The status of the upload job. For more information about the valid values and value description of the parameter, see the "Status: the status of a URL-based upload job" section of the [Basic structures](~~52839~~) topic.
            /// </summary>
            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public string UploadStatus { get; set; }

        }

    }

}
