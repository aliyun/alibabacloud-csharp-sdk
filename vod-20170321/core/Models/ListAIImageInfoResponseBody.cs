// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIImageInfoResponseBody : TeaModel {
        /// <summary>
        /// The image files that are uploaded for AI processing.
        /// </summary>
        [NameInMap("AIImageInfoList")]
        [Validation(Required=false)]
        public List<ListAIImageInfoResponseBodyAIImageInfoList> AIImageInfoList { get; set; }
        public class ListAIImageInfoResponseBodyAIImageInfoList : TeaModel {
            /// <summary>
            /// The ID of the image information.
            /// </summary>
            [NameInMap("AIImageInfoId")]
            [Validation(Required=false)]
            public string AIImageInfoId { get; set; }

            /// <summary>
            /// The time when the file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The URL of the image file.
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// The format of the image. Valid values: **gif** and **png**.
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The ID of the image AI processing job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The score of the image.
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// The data version ID.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
