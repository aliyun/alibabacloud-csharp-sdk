// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeEtlJobLogsRequest : TeaModel {
        /// <summary>
        /// The ID of the ETL task. You can call the [DescribeDtsJobs](~~209702~~) operation to query the task ID.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the region in which the Data Transmission Service (DTS) instance resides. You can call the [DescribeRegions](~~25609~~) operation to query the available Alibaba Cloud regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
