// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulExportInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

    }

}
