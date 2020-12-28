// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListExchangeUpStreamBindingsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExchangeUpStreamBindingsResponseBodyData Data { get; set; }
        public class ListExchangeUpStreamBindingsResponseBodyData : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("Bindings")]
            [Validation(Required=false)]
            public List<ListExchangeUpStreamBindingsResponseBodyDataBindings> Bindings { get; set; }
            public class ListExchangeUpStreamBindingsResponseBodyDataBindings : TeaModel {
                public string SourceExchange { get; set; }
                public string BindingKey { get; set; }
                public string BindingType { get; set; }
                public string Argument { get; set; }
                public string DestinationName { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
