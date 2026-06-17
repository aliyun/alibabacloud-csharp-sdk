// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeVSwitchListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A2EE5B4-CC9F-46E1-A747-E43BC9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitchs")]
        [Validation(Required=false)]
        public List<DescribeVSwitchListResponseBodyVSwitchs> VSwitchs { get; set; }
        public class DescribeVSwitchListResponseBodyVSwitchs : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses in the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AvailableIpAddressCount")]
            [Validation(Required=false)]
            public long? AvailableIpAddressCount { get; set; }

            /// <summary>
            /// <para>The vSwitch CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The description of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vSwitchDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The ID of the zone where the vSwitch resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>177563751276****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-************</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The sharing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The status of the vSwitch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: The vSwitch is being configured.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The vSwitch is available.</para>
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
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-25bcdxs7pv1****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The name of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vSwitch</para>
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1vbkkyt7apvy4j*****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
