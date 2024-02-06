// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries in the list.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the vSwitches. For more information, see the array of vSwitches in the response examples in the JSON format.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                /// <summary>
                /// The IPv4 CIDR block of the vSwitch.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The time when the vSwitch was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The description of the vSwitch.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the edge node.
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// The number of available IP addresses.
                /// </summary>
                [NameInMap("FreeIpCount")]
                [Validation(Required=false)]
                public long? FreeIpCount { get; set; }

                /// <summary>
                /// The ID of the network.
                /// </summary>
                [NameInMap("NetworkId")]
                [Validation(Required=false)]
                public string NetworkId { get; set; }

                /// <summary>
                /// The status of the vSwitch. Valid values:
                /// 
                /// *   Pending
                /// *   Available
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
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

        }

    }

}
