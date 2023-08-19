// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The Object Storage Service (OSS) URL of the watermark file. This parameter is required if you add image watermarks.
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// The name of the watermark. The name can contain only letters and digits.
        /// 
        /// *   The name can be up to 128 bytes in length.
        /// *   The value must be encoded in UTF-8.
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
        /// The configurations such as the position and effect of the text watermark or image watermark. The value must be a JSON string.
        /// 
        /// > The value of this parameter varies based on the watermark type. For more information about the data structure, see [WatermarkConfig](~~98618~~).
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

    }

}
