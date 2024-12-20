// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVSwitchsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B0BA251D-6854-5A99-A964-3C**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeRdsVSwitchsResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeRdsVSwitchsResponseBodyVSwitches : TeaModel {
            /// <summary>
            /// <para>Details of the vSwitch.</para>
            /// </summary>
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeRdsVSwitchsResponseBodyVSwitchesVSwitch : TeaModel {
                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <para>The CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.<b>.</b>.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Indicates whether the vSwitch is the default vSwitch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("IzNo")]
                [Validation(Required=false)]
                public string IzNo { get; set; }

                /// <summary>
                /// <para>An invalid parameter. It is no longer returned when you call this operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The state of the vSwitch. If <b>Available</b> is returned, the vSwitch is available.</para>
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
                /// <para>vsw-bp*******************</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The name of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-name</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

            }

        }

    }

}
