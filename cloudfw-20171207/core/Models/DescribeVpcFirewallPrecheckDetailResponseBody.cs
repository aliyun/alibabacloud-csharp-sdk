// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPrecheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        [NameInMap("PrecheckDetail")]
        [Validation(Required=false)]
        public DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetail PrecheckDetail { get; set; }
        public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetail : TeaModel {
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
            public List<DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups> PrecheckEntityGroups { get; set; }
            public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
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
                public List<DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities> PrecheckEntities { get; set; }
                public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities : TeaModel {
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
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4FB718F0-CC04-5A12-B17B-188CFC3F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
