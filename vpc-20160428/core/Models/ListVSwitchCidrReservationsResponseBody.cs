// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVSwitchCidrReservationsResponseBody : TeaModel {
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

        /// <summary>
        /// A list of reserved CIDR blocks.
        /// </summary>
        [NameInMap("VSwitchCidrReservations")]
        [Validation(Required=false)]
        public List<ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservations> VSwitchCidrReservations { get; set; }
        public class ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservations : TeaModel {
            /// <summary>
            /// The number of used prefixes in the reserved CIDR block.
            /// </summary>
            [NameInMap("AssignedCidrCount")]
            [Validation(Required=false)]
            public int? AssignedCidrCount { get; set; }

            /// <summary>
            /// The number of available prefixes in the reserved CIDR block.
            /// </summary>
            [NameInMap("AvailableCidrCount")]
            [Validation(Required=false)]
            public int? AvailableCidrCount { get; set; }

            /// <summary>
            /// The time when the reserved CIDR block was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The IP version of the reserved CIDR block. Valid values:
            /// 
            /// *   **IPv4** (default)
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The status of the reserved CIDR block. Valid values:
            /// 
            /// *   **Assigning**
            /// *   **Assigned**
            /// *   **Releasing**
            /// *   **Released**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservationsTags> Tags { get; set; }
            public class ListVSwitchCidrReservationsResponseBodyVSwitchCidrReservationsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the reserved CIDR block. Valid value: **prefix**. CIDR blocks are allocated from the reserved CIDR block.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The reserved CIDR block.
            /// </summary>
            [NameInMap("VSwitchCidrReservationCidr")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationCidr { get; set; }

            /// <summary>
            /// The description of the reserved CIDR block.
            /// </summary>
            [NameInMap("VSwitchCidrReservationDescription")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationDescription { get; set; }

            /// <summary>
            /// The ID of the reserved CIDR block.
            /// </summary>
            [NameInMap("VSwitchCidrReservationId")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationId { get; set; }

            /// <summary>
            /// The name of the reserved CIDR block.
            /// </summary>
            [NameInMap("VSwitchCidrReservationName")]
            [Validation(Required=false)]
            public string VSwitchCidrReservationName { get; set; }

            /// <summary>
            /// The ID of the vSwitch to which the reserved CIDR block belongs.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) to which the reserved CIDR block belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
