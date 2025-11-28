// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListMemberAuthorizedBizChainResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMemberAuthorizedBizChainResponseBodyData> Data { get; set; }
        public class ListMemberAuthorizedBizChainResponseBodyData : TeaModel {
            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            [NameInMap("BizChainId")]
            [Validation(Required=false)]
            public string BizChainId { get; set; }

            [NameInMap("BizChainName")]
            [Validation(Required=false)]
            public string BizChainName { get; set; }

            [NameInMap("BizChainType")]
            [Validation(Required=false)]
            public string BizChainType { get; set; }

            [NameInMap("PeerList")]
            [Validation(Required=false)]
            public List<ListMemberAuthorizedBizChainResponseBodyDataPeerList> PeerList { get; set; }
            public class ListMemberAuthorizedBizChainResponseBodyDataPeerList : TeaModel {
                [NameInMap("Authorized")]
                [Validation(Required=false)]
                public bool? Authorized { get; set; }

                [NameInMap("PeerName")]
                [Validation(Required=false)]
                public string PeerName { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
