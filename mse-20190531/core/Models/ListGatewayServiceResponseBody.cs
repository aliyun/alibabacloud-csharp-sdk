// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayServiceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayServiceResponseBodyData Data { get; set; }
        public class ListGatewayServiceResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayServiceResponseBodyDataResult> Result { get; set; }
            public class ListGatewayServiceResponseBodyDataResult : TeaModel {
                public long? GatewayId { get; set; }
                public string GatewayUniqueId { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string GroupName { get; set; }
                public string HealehStatus { get; set; }
                public long? Id { get; set; }
                public List<string> Ips { get; set; }
                public string MetaInfo { get; set; }
                public string Name { get; set; }
                public string Namespace { get; set; }
                public string ServiceNameInRegistry { get; set; }
                public long? ServicePort { get; set; }
                public string ServiceProtocol { get; set; }
                public long? SourceId { get; set; }
                public string SourceType { get; set; }
                public List<ListGatewayServiceResponseBodyDataResultVersions> Versions { get; set; }
                public class ListGatewayServiceResponseBodyDataResultVersions : TeaModel {
                    public string Name { get; set; }
                }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
