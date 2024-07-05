// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AddVodTemplateRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Multi-application service](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the template.
        /// 
        /// *   The name cannot exceed 128 bytes.
        /// *   The value must be encoded in UTF-8.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The configurations of the snapshot template. The value must be a JSON string. For more information about the data structure, see [SnapshotTemplateConfig](https://help.aliyun.com/document_detail/98618.html) and [DynamicImageTemplateConfig](https://help.aliyun.com/document_detail/98618.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// The type of the template. Set the value to **Snapshot**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
