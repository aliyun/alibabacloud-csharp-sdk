// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the watermark.
        /// </summary>
        [NameInMap("WatermarkInfo")]
        [Validation(Required=false)]
        public AddWatermarkResponseBodyWatermarkInfo WatermarkInfo { get; set; }
        public class AddWatermarkResponseBodyWatermarkInfo : TeaModel {
            /// <summary>
            /// The time when the watermark was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The OSS URL or Alibaba Cloud CDN URL of the watermark file. This parameter does not apply to text watermarks.
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
            /// *   **Image** (default)
            /// *   **Text**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The configurations such as the position and effect of the text watermark or image watermark. The value is a JSON string.
            /// 
            /// > The value of this parameter varies based on the watermark type. For more information about the data structure, see [WatermarkConfig](~~98618~~).
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
