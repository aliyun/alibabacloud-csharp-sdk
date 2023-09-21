// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudProductFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics of cloud services that are protected by Security Center.
        /// </summary>
        [NameInMap("GroupedFields")]
        [Validation(Required=false)]
        public DescribeCloudProductFieldStatisticsResponseBodyGroupedFields GroupedFields { get; set; }
        public class DescribeCloudProductFieldStatisticsResponseBodyGroupedFields : TeaModel {
            /// <summary>
            /// The statistics of different types of assets. **MachineType** indicates the type of the asset. **Count** indicates the number of assets of a specific type.
            /// 
            /// Valid values of **MachineType**:
            /// 
            /// *   **1**: Server Load Balancer (SLB) instance
            /// *   **2**: NAT gateway instance
            /// *   **3**: ApsaraDB RDS instance
            /// *   **4**: ApsaraDB for MongoDB instance
            /// </summary>
            [NameInMap("CategoryCount")]
            [Validation(Required=false)]
            public string CategoryCount { get; set; }

            /// <summary>
            /// The total number of cloud services that are protected by Security Center.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The number of cloud services that are at risk.
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
