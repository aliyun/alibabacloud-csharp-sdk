// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVSwitchCidrReservationUsageResponseBody : TeaModel {
        /// <summary>
        /// A list of reserved CIDR blocks that are in use.
        /// </summary>
        [NameInMap("CidrReservationUsages")]
        [Validation(Required=false)]
        public List<GetVSwitchCidrReservationUsageResponseBodyCidrReservationUsages> CidrReservationUsages { get; set; }
        public class GetVSwitchCidrReservationUsageResponseBodyCidrReservationUsages : TeaModel {
            /// <summary>
            /// The CIDR block allocated to the ENI from the reserved CIDR block.
            /// </summary>
            [NameInMap("IpPrefixCidr")]
            [Validation(Required=false)]
            public string IpPrefixCidr { get; set; }

            /// <summary>
            /// The ID of the reserved CIDR block.
            /// </summary>
            [NameInMap("IpPrefixId")]
            [Validation(Required=false)]
            public string IpPrefixId { get; set; }

            /// <summary>
            /// The ID of the elastic network interface (ENI) whose CIDR block is allocated from the reserved CIDR block.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource to which a CIDR block is allocated from the reserved CIDR block. Only **NetworkInterface** may be returned, which indicates an ENI.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The ID of the reserved CIDR block.
            /// </summary>
            [NameInMap("VSwitchCidrReservationId")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationId { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the reserved CIDR block belongs.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// The number of entries to return per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
