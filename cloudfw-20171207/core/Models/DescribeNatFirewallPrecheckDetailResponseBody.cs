// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeNatFirewallPrecheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        [NameInMap("PrecheckDetail")]
        [Validation(Required=false)]
        public DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetail PrecheckDetail { get; set; }
        public class DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vfw-tr-7a9c8901ed394****</para>
            /// </summary>
            [NameInMap("FirewallId")]
            [Validation(Required=false)]
            public string FirewallId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-m5emh0w6v2e15****</para>
            /// </summary>
            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            [NameInMap("PrecheckEntityGroups")]
            [Validation(Required=false)]
            public List<DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups> PrecheckEntityGroups { get; set; }
            public class DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public int? FailedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PrecheckEntities")]
                [Validation(Required=false)]
                public List<DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities> PrecheckEntities { get; set; }
                public class DescribeNatFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities : TeaModel {
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Precheck test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>passed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("PrecheckEntityGroupStatus")]
                [Validation(Required=false)]
                public string PrecheckEntityGroupStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1715136000</para>
            /// </summary>
            [NameInMap("PrecheckTimestamp")]
            [Validation(Required=false)]
            public string PrecheckTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99A65AA0-C5B5-5092-BFCF-8111B436****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
