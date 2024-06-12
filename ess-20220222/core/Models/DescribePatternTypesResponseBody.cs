// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribePatternTypesResponseBody : TeaModel {
        /// <summary>
        /// The instance types that meet the specified requirements.
        /// </summary>
        [NameInMap("PatternTypes")]
        [Validation(Required=false)]
        public List<DescribePatternTypesResponseBodyPatternTypes> PatternTypes { get; set; }
        public class DescribePatternTypesResponseBodyPatternTypes : TeaModel {
            /// <summary>
            /// The number of vCPUs that are assigned to the instance type.
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// The level of the instance family.
            /// 
            /// *   EntryLevel: entry level (shared instance types) Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for business scenarios in which the CPU utilization is low. For more information, see [Shared instance families](https://help.aliyun.com/document_detail/108489.html).
            /// *   EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources and are suitable for scenarios that require high stability. For more information, see [Overview of instance families](https://help.aliyun.com/document_detail/25378.html).
            /// *   CreditEntryLevel: credit-based entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// The name of the instance type.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The instance family.
            /// </summary>
            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            /// <summary>
            /// The memory size that are assigned to the instance type. Unit: GiB.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
