// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangesResponseBodyData Data { get; set; }
        public class ListExchangesResponseBodyData : TeaModel {
            /// <summary>
            /// Exchange。
            /// </summary>
            [NameInMap("Exchanges")]
            [Validation(Required=false)]
            public List<ListExchangesResponseBodyDataExchanges> Exchanges { get; set; }
            public class ListExchangesResponseBodyDataExchanges : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                [NameInMap("AutoDeleteState")]
                [Validation(Required=false)]
                public bool? AutoDeleteState { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("ExchangeType")]
                [Validation(Required=false)]
                public string ExchangeType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("VHostName")]
                [Validation(Required=false)]
                public string VHostName { get; set; }

            }

            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
