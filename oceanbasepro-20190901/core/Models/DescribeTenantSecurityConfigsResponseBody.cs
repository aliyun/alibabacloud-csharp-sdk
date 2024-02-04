// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantSecurityConfigsResponseBody : TeaModel {
        /// <summary>
        /// The list of parameters.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeTenantSecurityConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeTenantSecurityConfigsResponseBodyConfigs : TeaModel {
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
            /// The check result.
            /// </summary>
            [NameInMap("TenantSecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs> TenantSecurityConfigs { get; set; }
            public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs : TeaModel {
                /// <summary>
                /// The number of detected tenant security risks.
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// The list of risks.
                /// </summary>
                [NameInMap("SecurityConfigs")]
                [Validation(Required=false)]
                public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
                public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs : TeaModel {
                    /// <summary>
                    /// The name of the check item.
                    /// </summary>
                    [NameInMap("ConfigDescription")]
                    [Validation(Required=false)]
                    public string ConfigDescription { get; set; }

                    /// <summary>
                    /// The group of the risk.
                    /// </summary>
                    [NameInMap("ConfigGroup")]
                    [Validation(Required=false)]
                    public string ConfigGroup { get; set; }

                    /// <summary>
                    /// The name of the risk.
                    /// </summary>
                    [NameInMap("ConfigName")]
                    [Validation(Required=false)]
                    public string ConfigName { get; set; }

                    /// <summary>
                    /// Indicates whether the risk causes security issues.
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public bool? Risk { get; set; }

                    /// <summary>
                    /// The description of the risk.
                    /// </summary>
                    [NameInMap("RiskDescription")]
                    [Validation(Required=false)]
                    public string RiskDescription { get; set; }

                }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The name of the tenant.
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            /// <summary>
            /// The total number of security check items.
            /// </summary>
            [NameInMap("TotalCheckCount")]
            [Validation(Required=false)]
            public int? TotalCheckCount { get; set; }

            /// <summary>
            /// The total number of detected security risks.
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
