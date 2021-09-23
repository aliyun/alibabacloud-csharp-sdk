// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeMountedClientsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Clients")]
        [Validation(Required=false)]
        public DescribeMountedClientsResponseBodyClients Clients { get; set; }
        public class DescribeMountedClientsResponseBodyClients : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public List<DescribeMountedClientsResponseBodyClientsClient> Client { get; set; }
            public class DescribeMountedClientsResponseBodyClientsClient : TeaModel {
                public string ClientIP { get; set; }
            }
        };

    }

}
