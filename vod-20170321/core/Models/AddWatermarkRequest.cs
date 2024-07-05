// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddWatermarkRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. If you have activated the multi-application service, specify the ID of the application to add the watermark template in the specified application. For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The URL of the watermark file. The URL must be an Object Storage Service (OSS) URL and cannot contain the information used for URL signing.
        /// 
        /// > *   This parameter is required if you set `Type` to `Image`.
        /// > *  You can obtain the URL from the `FileURL` parameter in the response to the [CreateUploadAttachedMedia](~~CreateUploadAttachedMedia~~) operation that you call to upload the watermark image to ApsaraVideo VOD.
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// The name of the watermark template.
        /// 
        /// *   Only letters and digits are supported.
        /// *   The name cannot exceed 128 bytes.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the watermark template. Valid values:
        /// 
        /// *   **Image** (default): image watermark template
        /// *   **Text**: text watermark template
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The configuration information of the watermark such as the display position and special effects. The value must be a JSON string. The configuration parameters for image and text watermarks are different. For more information about the parameter structure, see [WatermarkConfig](~~98618#section-h01-44s-2lr~~).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WatermarkConfig")]
        [Validation(Required=false)]
        public string WatermarkConfig { get; set; }

    }

}
