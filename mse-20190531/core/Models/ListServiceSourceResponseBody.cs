// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListServiceSourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListServiceSourceResponseBodyData> Data { get; set; }
        public class ListServiceSourceResponseBodyData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("BindingWithGateway")]
            [Validation(Required=false)]
            public int? BindingWithGateway { get; set; }

            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public List<string> GroupList { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IngressOptions")]
            [Validation(Required=false)]
            public ListServiceSourceResponseBodyDataIngressOptions IngressOptions { get; set; }
            public class ListServiceSourceResponseBodyDataIngressOptions : TeaModel {
                [NameInMap("EnableIngress")]
                [Validation(Required=false)]
                public bool? EnableIngress { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public bool? EnableStatus { get; set; }

                [NameInMap("IngressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                [NameInMap("WatchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PathList")]
            [Validation(Required=false)]
            public List<string> PathList { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SourceUniqueId")]
            [Validation(Required=false)]
            public string SourceUniqueId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
