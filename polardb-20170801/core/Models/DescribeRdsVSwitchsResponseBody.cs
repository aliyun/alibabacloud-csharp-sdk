// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeRdsVSwitchsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0450B18-BBD4-5DF9-8E71-610F1A921CDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The vSwitch information.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeRdsVSwitchsResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeRdsVSwitchsResponseBodyVSwitches : TeaModel {
            /// <summary>
            /// <para>The vSwitch information.</para>
            /// </summary>
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>175358919****</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>Identifies the cloud service type, such as Alibaba Finance Cloud, Alibaba Gov Cloud, or public cloud.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26842</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <para>The CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.8.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the vSwitch was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-23 10:15:38</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the vSwitch was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-30T09:41:14+08:00</para>
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
                /// <para>The ID of the zone to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ch-hangzhou-g</para>
                /// </summary>
                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The status of the vSwitch. Valid values: <em><b>Pending</b></em>\<em>: The vSwitch is being configured.\</em> <b>Available</b>: The vSwitch is available.</para>
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
                /// <para>vsw-**************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sw01</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

            }

        }

    }

}
