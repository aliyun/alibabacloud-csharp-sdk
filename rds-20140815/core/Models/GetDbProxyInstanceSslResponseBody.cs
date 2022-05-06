// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDbProxyInstanceSslResponseBody : TeaModel {
        [NameInMap("DbProxyCertListItems")]
        [Validation(Required=false)]
        public GetDbProxyInstanceSslResponseBodyDbProxyCertListItems DbProxyCertListItems { get; set; }
        public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItems : TeaModel {
            [NameInMap("DbProxyCertListItems")]
            [Validation(Required=false)]
            public List<GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems> DbProxyCertListItems { get; set; }
            public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems : TeaModel {
                public string CertCommonName { get; set; }
                public string DbInstanceName { get; set; }
                public string EndpointName { get; set; }
                public string EndpointType { get; set; }
                public string SslExpiredTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
