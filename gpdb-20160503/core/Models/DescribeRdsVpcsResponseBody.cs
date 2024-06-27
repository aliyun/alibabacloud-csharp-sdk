// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeRdsVpcsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried VPCs.
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeRdsVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeRdsVpcsResponseBodyVpcs : TeaModel {
            /// <summary>
            /// The queried VPC.
            /// </summary>
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeRdsVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeRdsVpcsResponseBodyVpcsVpc : TeaModel {
                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// The CIDR block of the VPC.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// An invalid parameter. It is no longer returned when you call this operation.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// Indicates whether the VPC is the default VPC. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// The state of the VPC. If **Available** is returned, the VPC is available.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The queried vSwitches.
                /// </summary>
                [NameInMap("VSwitchs")]
                [Validation(Required=false)]
                public List<DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs : TeaModel {
                    /// <summary>
                    /// The CIDR block of the vSwitch.
                    /// </summary>
                    [NameInMap("CidrBlock")]
                    [Validation(Required=false)]
                    public string CidrBlock { get; set; }

                    /// <summary>
                    /// An invalid parameter. It is no longer returned when you call this operation.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// An invalid parameter. It is no longer returned when you call this operation.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// Indicates whether the vSwitch is the default vSwitch. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// The ID of the zone to which the vSwitch belongs.
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// The state of the vSwitch. If **Available** is returned, the vSwitch is available.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// The name of the vSwitch.
                    /// </summary>
                    [NameInMap("VSwitchName")]
                    [Validation(Required=false)]
                    public string VSwitchName { get; set; }

                }

                /// <summary>
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
