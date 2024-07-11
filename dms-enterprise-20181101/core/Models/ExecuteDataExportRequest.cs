// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataExportRequest : TeaModel {
        /// <summary>
        /// The parameters that are required to perform the operation:
        /// 
        /// ```json
        /// {
        ///    "fileType": "CSV", // The format of the exported file.
        ///    "encoding": "" // The encoding format.
        ///  }
        /// ```
        /// </summary>
        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> ActionDetail { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > : To view the ID of the tenant, log on to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see [Manage DMS tenants](https://help.aliyun.com/document_detail/181330.html).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
