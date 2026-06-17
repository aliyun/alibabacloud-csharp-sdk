// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeRdsVpcsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B45E8D29-EA17-5141-AE09-F7A399760C9E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of VPCs.</para>
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeRdsVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeRdsVpcsResponseBodyVpcs : TeaModel {
            /// <summary>
            /// <para>The VPC details.</para>
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeRdsVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeRdsVpcsResponseBodyVpcsVpc : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1485293698******</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>The business type of the account. This parameter indicates whether the account is an Alibaba Finance Cloud account, an Alibaba Gov Cloud account, or a public cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26842</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <para>The CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.21.0.0/16</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the VPC was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-28T02:25:41Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the VPC was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-30T09:41:14+08:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the VPC is the default VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The status of the VPC. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: The VPC is being configured.</para>
                /// </description></item>
                /// <item><description><para>Available: The VPC is available.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The details of the vSwitches in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchs")]
                [Validation(Required=false)]
                public List<DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs : TeaModel {
                    /// <summary>
                    /// <para>The vSwitch CIDR block.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.7.0/24</para>
                    /// </summary>
                    [NameInMap("CidrBlock")]
                    [Validation(Required=false)]
                    public string CidrBlock { get; set; }

                    /// <summary>
                    /// <para>The time when the vSwitch was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-05-12 18:17:25</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The time when the vSwitch was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-07T15:10:32+08:00</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the vSwitch is the default vSwitch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>true</b>: The vSwitch is the default vSwitch.</para>
                    /// </description></item>
                    /// <item><description><para><b>false</b>: The vSwitch is not the default vSwitch.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <para>The ID of the zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-k</para>
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// <para>The status of the vSwitch. <b>Available</b> indicates that the vSwitch is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-**********</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The name of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("VSwitchName")]
                    [Validation(Required=false)]
                    public string VSwitchName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-*************</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fc-webide</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
