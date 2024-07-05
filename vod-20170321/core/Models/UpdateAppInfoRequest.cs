// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAppInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// 
        /// *   Default value: **app-1000000**.
        /// *   For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the application.
        /// 
        /// *   The name can contain up to 128 characters in length, including Chinese letters, digits, and periods (.), dash (-), and at character (@).
        /// *   The name can contain only UTF-8 characters.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The description of the application.
        /// 
        /// *   The description can contain up to 512 characters in length.
        /// *   The description can contain only UTF-8 characters.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The status of the application. Valid values:
        /// 
        /// *   **Normal**
        /// *   **Disable**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
