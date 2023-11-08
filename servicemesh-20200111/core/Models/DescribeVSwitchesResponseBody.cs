// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of vSwitches that are deployed in the VPC in the region. This parameter is optional and is not returned by default.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The available vSwitches.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<DescribeVSwitchesResponseBodyVSwitches> VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            /// <summary>
            /// Indicates whether the vSwitch is the default vSwitch. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The state of the vSwitch. Valid values:
            /// 
            /// *   `Pending`: The vSwitch is being configured.
            /// *   `Available`: The vSwitch is available.
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

            /// <summary>
            /// The ID of the VPC to which the vSwitch belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// The zone to which the switch belongs.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
