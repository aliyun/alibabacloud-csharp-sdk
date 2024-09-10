// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeScanResultListRequest : TeaModel {
        /// <summary>
        /// The search conditions for assets. This parameter is in the JSON format. The value is case-sensitive.
        /// 
        /// >  A search condition can be the instance ID, instance name, VPC ID, region, or public IP address. You can call the [DescribeIdcAssetCriteria](https://help.aliyun.com/document_detail/2842671.html) operation to query supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end time of the scan.
        /// </summary>
        [NameInMap("FoundEndTime")]
        [Validation(Required=false)]
        public long? FoundEndTime { get; set; }

        /// <summary>
        /// The start time of the scan.
        /// </summary>
        [NameInMap("FoundStartTime")]
        [Validation(Required=false)]
        public long? FoundStartTime { get; set; }

        /// <summary>
        /// The logical operator that combines multiple search conditions. Valid values:
        /// 
        /// *   **OR******
        /// *   **AND******
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The statuses of the corresponding probes. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **0**: The probe is valid.
        /// *   **1**: The probe is ignored.
        /// *   **2**: The probe is invalid.
        /// *   **3**: The probe expired.
        /// *   **4**: The probe does not exist.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
