// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMsConfigClientsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<QueryMsConfigClientsResponseBodyClients> Clients { get; set; }
        public class QueryMsConfigClientsResponseBodyClients : TeaModel {
            [NameInMap("Cell")]
            [Validation(Required=false)]
            public string Cell { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("PushData")]
            [Validation(Required=false)]
            public string PushData { get; set; }

        }

    }

}
