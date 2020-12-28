// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangesResponseBodyData Data { get; set; }
        public class ListExchangesResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("Exchanges")]
            [Validation(Required=false)]
            public List<ListExchangesResponseBodyDataExchanges> Exchanges { get; set; }
            public class ListExchangesResponseBodyDataExchanges : TeaModel {
                public bool? AutoDeleteState { get; set; }
                public long? CreateTime { get; set; }
                public Dictionary<string, string> Attributes { get; set; }
                public string VHostName { get; set; }
                public string Name { get; set; }
                public string ExchangeType { get; set; }
            }
        };

    }

}
