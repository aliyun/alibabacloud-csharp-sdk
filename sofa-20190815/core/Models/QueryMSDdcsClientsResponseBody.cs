// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSDdcsClientsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<QueryMSDdcsClientsResponseBodyClients> Clients { get; set; }
        public class QueryMSDdcsClientsResponseBodyClients : TeaModel {
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
