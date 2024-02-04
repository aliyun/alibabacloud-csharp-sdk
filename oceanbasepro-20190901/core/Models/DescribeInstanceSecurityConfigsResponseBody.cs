// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSecurityConfigsResponseBody : TeaModel {
        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("InstanceSecurityConfigs")]
        [Validation(Required=false)]
        public DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs InstanceSecurityConfigs { get; set; }
        public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs : TeaModel {
            /// <summary>
            /// The unique identifier of the check.
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            /// <summary>
            /// The time when the check was performed.
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The list of check items.
            /// </summary>
            [NameInMap("SecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
            public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs : TeaModel {
                /// <summary>
                /// The name of the check item.
                /// </summary>
                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                /// <summary>
                /// The group of the check.
                /// </summary>
                [NameInMap("ConfigGroup")]
                [Validation(Required=false)]
                public string ConfigGroup { get; set; }

                /// <summary>
                /// The name of the specific check item.
                /// </summary>
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// Specifies whether a risk is detected.
                /// </summary>
                [NameInMap("Risk")]
                [Validation(Required=false)]
                public bool? Risk { get; set; }

                /// <summary>
                /// Security recommendations.
                /// </summary>
                [NameInMap("RiskDescription")]
                [Validation(Required=false)]
                public string RiskDescription { get; set; }

            }

            /// <summary>
            /// The total number of security check items for the cluster.
            /// </summary>
            [NameInMap("TotalCheckCount")]
            [Validation(Required=false)]
            public int? TotalCheckCount { get; set; }

            /// <summary>
            /// The total number of detected cluster security risks.
            /// </summary>
            [NameInMap("TotalRiskCount")]
            [Validation(Required=false)]
            public int? TotalRiskCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
