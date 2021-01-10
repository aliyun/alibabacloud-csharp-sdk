// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqConsumerConnectionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMqSofamqConsumerConnectionResponseBodyData Data { get; set; }
        public class QueryMqSofamqConsumerConnectionResponseBodyData : TeaModel {
            [NameInMap("ConnectionList")]
            [Validation(Required=false)]
            public List<QueryMqSofamqConsumerConnectionResponseBodyDataConnectionList> ConnectionList { get; set; }
            public class QueryMqSofamqConsumerConnectionResponseBodyDataConnectionList : TeaModel {
                public string ClientAddr { get; set; }
                public string ClientId { get; set; }
                public string Language { get; set; }
                public string RemoteIp { get; set; }
                public string Version { get; set; }
            }
        };

    }

}
