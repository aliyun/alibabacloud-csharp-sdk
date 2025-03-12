// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantSecurityConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameters.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeTenantSecurityConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeTenantSecurityConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            /// <summary>
            /// <para>The time when the check was performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-07 15:30:00</para>
            /// </summary>
            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The check result.</para>
            /// </summary>
            [NameInMap("TenantSecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs> TenantSecurityConfigs { get; set; }
            public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs : TeaModel {
                /// <summary>
                /// <para>The number of detected tenant security risks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                /// <summary>
                /// <para>The list of risks.</para>
                /// </summary>
                [NameInMap("SecurityConfigs")]
                [Validation(Required=false)]
                public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
                public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs : TeaModel {
                    /// <summary>
                    /// <para>The name of the check item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check whether the scope of the cluster allowlist is too big</para>
                    /// </summary>
                    [NameInMap("ConfigDescription")]
                    [Validation(Required=false)]
                    public string ConfigDescription { get; set; }

                    /// <summary>
                    /// <para>The group of the risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WHITELIST</para>
                    /// </summary>
                    [NameInMap("ConfigGroup")]
                    [Validation(Required=false)]
                    public string ConfigGroup { get; set; }

                    /// <summary>
                    /// <para>The name of the risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WHITELIST_RANGE_LARGE</para>
                    /// </summary>
                    [NameInMap("ConfigName")]
                    [Validation(Required=false)]
                    public string ConfigName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the risk causes security issues.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Risk")]
                    [Validation(Required=false)]
                    public bool? Risk { get; set; }

                    /// <summary>
                    /// <para>The description of the risk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The scope of the allowlist is too big.</para>
                    /// </summary>
                    [NameInMap("RiskDescription")]
                    [Validation(Required=false)]
                    public string RiskDescription { get; set; }

                }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The name of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            /// <summary>
            /// <para>The total number of security check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCheckCount")]
            [Validation(Required=false)]
            public int? TotalCheckCount { get; set; }

            /// <summary>
            /// <para>The total number of detected security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalRiskCount")]
            [Validation(Required=false)]
            public int? TotalRiskCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>523E7183-<b><b>-590D-</b></b>-12DFD316614B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
