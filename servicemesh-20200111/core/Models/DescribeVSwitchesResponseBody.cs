// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the vSwitch is the default vSwitch. Valid values:
        /// 
        /// *   `true`: yes
        /// *   `false`: no
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The status of the vSwitch. Valid values:
        /// 
        /// *   `Pending`: The vSwitch is being configured.
        /// *   `Available`: The vSwitch is available for use.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the VPC in which the vSwitch is deployed.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The name of the vSwitch.
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<DescribeVSwitchesResponseBodyVSwitches> VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
