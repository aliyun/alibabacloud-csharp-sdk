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
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                [NameInMap("SslExpiredTime")]
                [Validation(Required=false)]
                public string SslExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D330E60C-8AAA-4D63-8F64-5B78F4692F98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
