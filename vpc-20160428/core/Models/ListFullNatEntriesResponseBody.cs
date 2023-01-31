// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesResponseBody : TeaModel {
        [NameInMap("FullNatEntries")]
        [Validation(Required=false)]
        public List<ListFullNatEntriesResponseBodyFullNatEntries> FullNatEntries { get; set; }
        public class ListFullNatEntriesResponseBodyFullNatEntries : TeaModel {
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            [NameInMap("AccessPort")]
            [Validation(Required=false)]
            public string AccessPort { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("FullNatEntryDescription")]
            [Validation(Required=false)]
            public string FullNatEntryDescription { get; set; }

            [NameInMap("FullNatEntryId")]
            [Validation(Required=false)]
            public string FullNatEntryId { get; set; }

            [NameInMap("FullNatEntryName")]
            [Validation(Required=false)]
            public string FullNatEntryName { get; set; }

            [NameInMap("FullNatEntryStatus")]
            [Validation(Required=false)]
            public string FullNatEntryStatus { get; set; }

            [NameInMap("FullNatTableId")]
            [Validation(Required=false)]
            public string FullNatTableId { get; set; }

            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            [NameInMap("NatIpPort")]
            [Validation(Required=false)]
            public string NatIpPort { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("NetworkInterfaceType")]
            [Validation(Required=false)]
            public string NetworkInterfaceType { get; set; }

        }

        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
