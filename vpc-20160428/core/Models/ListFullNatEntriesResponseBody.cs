// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesResponseBody : TeaModel {
        /// <summary>
        /// The information about the FULLNAT entries that are queried.
        /// </summary>
        [NameInMap("FullNatEntries")]
        [Validation(Required=false)]
        public List<ListFullNatEntriesResponseBodyFullNatEntries> FullNatEntries { get; set; }
        public class ListFullNatEntriesResponseBodyFullNatEntries : TeaModel {
            /// <summary>
            /// The backend IP address that is used for FULLNAT address translation in FULLNAT entries.
            /// </summary>
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            /// <summary>
            /// The backend port that is used for port mapping in FULLNAT entries. Valid values: **1** to **65535**.
            /// </summary>
            [NameInMap("AccessPort")]
            [Validation(Required=false)]
            public string AccessPort { get; set; }

            /// <summary>
            /// The time when the FULLNAT entry was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the FULLNAT entry.
            /// 
            /// The name must be 2 to 128 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
            /// </summary>
            [NameInMap("FullNatEntryDescription")]
            [Validation(Required=false)]
            public string FullNatEntryDescription { get; set; }

            /// <summary>
            /// The ID of the FULLNAT entry.
            /// </summary>
            [NameInMap("FullNatEntryId")]
            [Validation(Required=false)]
            public string FullNatEntryId { get; set; }

            /// <summary>
            /// The name of the FULLNAT entry.
            /// 
            /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
            /// </summary>
            [NameInMap("FullNatEntryName")]
            [Validation(Required=false)]
            public string FullNatEntryName { get; set; }

            /// <summary>
            /// The status of the FULLNAT entry. Valid values:
            /// 
            /// *   **Pending**: The FULLNAT entry is being configured.
            /// *   **Available**: The FULLNAT entry is available.
            /// *   **Deleting**: The FULLNAT entry is being deleted.
            /// *   **Deleted**: The FULLNAT entry is deleted.
            /// </summary>
            [NameInMap("FullNatEntryStatus")]
            [Validation(Required=false)]
            public string FullNatEntryStatus { get; set; }

            /// <summary>
            /// The ID of the FULLNAT table to which the FULLNAT entry belongs.
            /// </summary>
            [NameInMap("FullNatTableId")]
            [Validation(Required=false)]
            public string FullNatTableId { get; set; }

            /// <summary>
            /// The protocol of the packets that are forwarded. Valid values:
            /// 
            /// *   **TCP**
            /// *   **UDP**
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// The NAT IP address that is used for address translation in FULLNAT entries.
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// The frontend port that is used for port mapping in FULLNAT entries. Valid values: **1** to **65535**.
            /// </summary>
            [NameInMap("NatIpPort")]
            [Validation(Required=false)]
            public string NatIpPort { get; set; }

            /// <summary>
            /// The ID of the ENI.
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The type of the ENI. The value is set to **Endpoint**, which indicates a reverse endpoint.
            /// </summary>
            [NameInMap("NetworkInterfaceType")]
            [Validation(Required=false)]
            public string NetworkInterfaceType { get; set; }

        }

        /// <summary>
        /// The ID of the FULLNAT table to which the queried FULLNAT entries belong.
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The ID of the VPC NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// Indicates whether the token for the next query exists. Valid values:
        /// 
        /// *   If the value of **NextToken** is empty, no next queries are sent.
        /// *   If the value of **NextToken** is returned, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of FULLNAT entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
