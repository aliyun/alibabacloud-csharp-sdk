// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// <para><b>30</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11FDB5A0-84F5-5361-B729-5770B0AEB9D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of VPCs.</para>
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public List<DescribeVpcsResponseBodyVpcs> Vpcs { get; set; }
        public class DescribeVpcsResponseBodyVpcs : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1868512340232755</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is an Alibaba Finance Cloud account, an Alibaba Gov Cloud account, or a public cloud account.</para>
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
            /// <para>57.100.6.59/32</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The time when the VPC was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-18T15:02:37Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the VPC was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-18T15:02:37Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the VPC is the default VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The VPC is the default VPC.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The VPC is not the default VPC.</para>
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
            /// <para>The ID of the region to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-wt97-a01</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The status of the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Pending</c>: The VPC is being configured.</para>
            /// </description></item>
            /// <item><description><para><c>Available</c>: The VPC is active.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of vSwitches.</para>
            /// </summary>
            [NameInMap("VSwitchs")]
            [Validation(Required=false)]
            public List<DescribeVpcsResponseBodyVpcsVSwitchs> VSwitchs { get; set; }
            public class DescribeVpcsResponseBodyVpcsVSwitchs : TeaModel {
                /// <summary>
                /// <para>The IPv4 CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.118.126.0/25</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the vSwitch was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-18T15:02:37Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the vSwitch was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-18T15:02:37Z</para>
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
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The zone to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen-f</para>
                /// </summary>
                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                /// <summary>
                /// <para>The status of the vSwitch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Pending</b>: The vSwitch is being configured.</para>
                /// </description></item>
                /// <item><description><para><b>Available</b>: The vSwitch is active.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-uf6fus5py6hbvxqwzwnk8</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-sw</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html">DescribeVpcs</a> operation to query the details of VPCs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16efwqjzyumc23c647v</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-e2e-10341f3</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

    }

}
