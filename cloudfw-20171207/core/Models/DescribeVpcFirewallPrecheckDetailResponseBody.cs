// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPrecheckDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a task exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsFound")]
        [Validation(Required=false)]
        public bool? IsFound { get; set; }

        /// <summary>
        /// <para>The details of the precheck.</para>
        /// </summary>
        [NameInMap("PrecheckDetail")]
        [Validation(Required=false)]
        public DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetail PrecheckDetail { get; set; }
        public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetail : TeaModel {
            /// <summary>
            /// <para>The ID of the firewall instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vfw-tr-7a9c8901ed394****</para>
            /// </summary>
            [NameInMap("FirewallId")]
            [Validation(Required=false)]
            public string FirewallId { get; set; }

            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-m5emh0w6v2e15****</para>
            /// </summary>
            [NameInMap("NetworkInstanceId")]
            [Validation(Required=false)]
            public string NetworkInstanceId { get; set; }

            /// <summary>
            /// <para>The list of precheck item groups.</para>
            /// </summary>
            [NameInMap("PrecheckEntityGroups")]
            [Validation(Required=false)]
            public List<DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups> PrecheckEntityGroups { get; set; }
            public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroups : TeaModel {
                /// <summary>
                /// <para>The number of rules that failed the precheck.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public int? FailedCount { get; set; }

                /// <summary>
                /// <para>The name of the precheck instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The execution status of each precheck item.</para>
                /// </summary>
                [NameInMap("PrecheckEntities")]
                [Validation(Required=false)]
                public List<DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities> PrecheckEntities { get; set; }
                public class DescribeVpcFirewallPrecheckDetailResponseBodyPrecheckDetailPrecheckEntityGroupsPrecheckEntities : TeaModel {
                    /// <summary>
                    /// <para>The information about the failed precheck.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC Firewall Quota Full</para>
                    /// </summary>
                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    /// <summary>
                    /// <para>The name of the precheck item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Precheck test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The status of the precheck item. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>running</b>: The precheck is in progress.</para>
                    /// </description></item>
                    /// <item><description><para><b>passed</b>: The precheck is passed.</para>
                    /// </description></item>
                    /// <item><description><para><b>failed</b>: The precheck failed.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>passed</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The suggested solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The VPC firewall quota is full. We recommend that you increase the firewall quota</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The status of the precheck group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>running</b></para>
                /// </description></item>
                /// <item><description><para><b>passed</b></para>
                /// </description></item>
                /// <item><description><para><b>failed</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("PrecheckEntityGroupStatus")]
                [Validation(Required=false)]
                public string PrecheckEntityGroupStatus { get; set; }

            }

            /// <summary>
            /// <para>The status of the precheck. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>running</b>: The precheck is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>passed</b>: The precheck is passed.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The precheck failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>failed</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public string PrecheckStatus { get; set; }

            /// <summary>
            /// <para>The timestamp of the precheck.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715136000</para>
            /// </summary>
            [NameInMap("PrecheckTimestamp")]
            [Validation(Required=false)]
            public string PrecheckTimestamp { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FB718F0-CC04-5A12-B17B-188CFC3F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
