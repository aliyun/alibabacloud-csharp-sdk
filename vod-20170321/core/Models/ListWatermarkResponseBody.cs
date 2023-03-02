// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListWatermarkResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the watermarks.
        /// </summary>
        [NameInMap("WatermarkInfos")]
        [Validation(Required=false)]
        public List<ListWatermarkResponseBodyWatermarkInfos> WatermarkInfos { get; set; }
        public class ListWatermarkResponseBodyWatermarkInfos : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The time when the watermark was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The Object Storage Service (OSS) URL or CDN URL of the watermark file. A text watermark does not have a file URL.
            /// </summary>
            [NameInMap("FileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

            /// <summary>
            /// Indicates whether the default watermark was used. Valid values:
            /// 
            /// *   **Default**
            /// *   **NotDefault**
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public string IsDefault { get; set; }

            /// <summary>
            /// The name of the watermark.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the watermark. Valid values:
            /// 
            /// *   **Image**
            /// *   **Text**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The configuration information such as the position and effect about the text watermark or image watermark. The value is a JSON string. For more information about the data structure, see the "WatermarkConfig: specifies the watermark configurations" section of the [Parameters for media processing](~~98618~~) topic.
            /// </summary>
            [NameInMap("WatermarkConfig")]
            [Validation(Required=false)]
            public string WatermarkConfig { get; set; }

            /// <summary>
            /// The ID of the watermark.
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

        }

    }

}
