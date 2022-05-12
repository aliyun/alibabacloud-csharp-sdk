// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListIngressesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIngressesResponseBodyData Data { get; set; }
        public class ListIngressesResponseBodyData : TeaModel {
            [NameInMap("IngressList")]
            [Validation(Required=false)]
            public List<ListIngressesResponseBodyDataIngressList> IngressList { get; set; }
            public class ListIngressesResponseBodyDataIngressList : TeaModel {
                public string CertId { get; set; }
                public string Description { get; set; }
                public long? Id { get; set; }
                public string ListenerPort { get; set; }
                public string ListenerProtocol { get; set; }
                public string LoadBalanceType { get; set; }
                public string Name { get; set; }
                public string NamespaceId { get; set; }
                public string SlbId { get; set; }
                public string SlbType { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
