// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78BDC895-F7C0-5961-92BE-F1C3D12B4BB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried VPCs.</para>
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeVpcsResponseBodyVpcs : TeaModel {
            /// <summary>
            /// <para>The queried VPC.</para>
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeVpcsResponseBodyVpcsVpc : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1431771514176727</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>The user channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26842</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <para>The IPv4 CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the VPC was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1693217052000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the VPC was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724639118000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the VPC is the default VPC in the region. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The region in which the VPC resides.</para>
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
                /// <item><description>Pending</description></item>
                /// <item><description>Available</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vSwitches in the VPC.</para>
                /// </summary>
                [NameInMap("VSwitchs")]
                [Validation(Required=false)]
                public List<DescribeVpcsResponseBodyVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcVSwitchs : TeaModel {
                    /// <summary>
                    /// <para>The IPv4 CIDR block of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.17.0.0/24</para>
                    /// </summary>
                    [NameInMap("CidrBlock")]
                    [Validation(Required=false)]
                    public string CidrBlock { get; set; }

                    /// <summary>
                    /// <para>The time when the vSwitch was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1549012834000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The time when the vSwitch was modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1731031910000</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the vSwitch is the default vSwitch. Valid values: <b>true</b> <b>false</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <para>The zone ID of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-j</para>
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// <para>The status of the vSwitch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Pending</description></item>
                    /// <item><description>Available</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-8vbxk6ij0yz16bu4l3ijj</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The name of the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vs1</para>
                    /// </summary>
                    [NameInMap("VSwitchName")]
                    [Validation(Required=false)]
                    public string VSwitchName { get; set; }

                }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6m0r5pihw1r79od6990</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc1</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
