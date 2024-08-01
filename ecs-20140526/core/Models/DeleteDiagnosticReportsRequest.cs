// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteDiagnosticReportsRequest : TeaModel {
        /// <summary>
        /// The region ID of the diagnostic report. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of diagnostic reports. You can specify up to 100 report IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public List<string> ReportIds { get; set; }

    }

}
