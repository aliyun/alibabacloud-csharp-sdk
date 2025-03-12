// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSecurityConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return result of the request.</para>
        /// </summary>
        [NameInMap("InstanceSecurityConfigs")]
        [Validation(Required=false)]
        public DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs InstanceSecurityConfigs { get; set; }
        public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs : TeaModel {
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
            /// <para>The list of check items.</para>
            /// </summary>
            [NameInMap("SecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
            public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs : TeaModel {
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
                /// <para>The group of the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WHITELIST</para>
                /// </summary>
                [NameInMap("ConfigGroup")]
                [Validation(Required=false)]
                public string ConfigGroup { get; set; }

                /// <summary>
                /// <para>The name of the specific check item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                /// <summary>
                /// <para>Specifies whether a risk is detected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Risk")]
                [Validation(Required=false)]
                public bool? Risk { get; set; }

                /// <summary>
                /// <para>Security recommendations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("RiskDescription")]
                [Validation(Required=false)]
                public string RiskDescription { get; set; }

            }

            /// <summary>
            /// <para>The total number of security check items for the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCheckCount")]
            [Validation(Required=false)]
            public int? TotalCheckCount { get; set; }

            /// <summary>
            /// <para>The total number of detected cluster security risks.</para>
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
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
