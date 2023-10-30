// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationTicketsResponseBody : TeaModel {
        [NameInMap("OperationTickets")]
        [Validation(Required=false)]
        public List<ListOperationTicketsResponseBodyOperationTickets> OperationTickets { get; set; }
        public class ListOperationTicketsResponseBodyOperationTickets : TeaModel {
            [NameInMap("ApplyUserId")]
            [Validation(Required=false)]
            public string ApplyUserId { get; set; }

            [NameInMap("ApplyUsername")]
            [Validation(Required=false)]
            public string ApplyUsername { get; set; }

            [NameInMap("AssetAccountId")]
            [Validation(Required=false)]
            public string AssetAccountId { get; set; }

            [NameInMap("AssetAccountName")]
            [Validation(Required=false)]
            public string AssetAccountName { get; set; }

            [NameInMap("AssetAddress")]
            [Validation(Required=false)]
            public string AssetAddress { get; set; }

            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            [NameInMap("AssetNetworkDomainId")]
            [Validation(Required=false)]
            public string AssetNetworkDomainId { get; set; }

            [NameInMap("AssetOs")]
            [Validation(Required=false)]
            public string AssetOs { get; set; }

            [NameInMap("AssetSource")]
            [Validation(Required=false)]
            public string AssetSource { get; set; }

            [NameInMap("AssetSourceInstanceId")]
            [Validation(Required=false)]
            public string AssetSourceInstanceId { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("OperationTicketId")]
            [Validation(Required=false)]
            public string OperationTicketId { get; set; }

            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
