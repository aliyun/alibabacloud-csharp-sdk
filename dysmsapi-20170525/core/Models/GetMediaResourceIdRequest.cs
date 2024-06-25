// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetMediaResourceIdRequest : TeaModel {
        /// <summary>
        /// The extended fields.
        /// 
        /// > If you set the ResourceType parameter to **2**, this parameter is required.
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// The size of the resource. Unit: bytes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// The description of the resource.
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// The address of the resource.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// *   **1**: text.
        /// *   **2**: image. A small image cannot exceed 100 KB in size, and a large image cannot exceed 2 MB in size. The image must be clear. Supported format: JPG, JPEG, and PNG.
        /// *   **3**: audio.
        /// *   **4**: video. Supported format: MP4.
        /// 
        /// > 
        /// 
        /// *   If you set the ResourceType parameter to 2, the **img_rate** required is required. Valid values:
        /// 
        /// *   1:1
        /// 
        /// *   16:9
        /// 
        /// *   3:1
        /// 
        /// *   48:65
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
