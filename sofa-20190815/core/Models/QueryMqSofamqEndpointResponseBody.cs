// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMqSofamqEndpointResponseBody : TeaModel {
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
        public QueryMqSofamqEndpointResponseBodyData Data { get; set; }
        public class QueryMqSofamqEndpointResponseBodyData : TeaModel {
            [NameInMap("Doc")]
            [Validation(Required=false)]
            public string Doc { get; set; }
            [NameInMap("HttpsInternet")]
            [Validation(Required=false)]
            public string HttpsInternet { get; set; }
            [NameInMap("HttpInternal")]
            [Validation(Required=false)]
            public string HttpInternal { get; set; }
            [NameInMap("HttpInternet")]
            [Validation(Required=false)]
            public string HttpInternet { get; set; }
            [NameInMap("Tcp")]
            [Validation(Required=false)]
            public string Tcp { get; set; }
        };

    }

}
