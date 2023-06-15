// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class GetDbProxyInstanceSslResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of SSL encryption settings.
        /// </summary>
        [NameInMap("DbProxyCertListItems")]
        [Validation(Required=false)]
        public GetDbProxyInstanceSslResponseBodyDbProxyCertListItems DbProxyCertListItems { get; set; }
        public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItems : TeaModel {
            [NameInMap("DbProxyCertListItems")]
            [Validation(Required=false)]
            public List<GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems> DbProxyCertListItems { get; set; }
            public class GetDbProxyInstanceSslResponseBodyDbProxyCertListItemsDbProxyCertListItems : TeaModel {
                /// <summary>
                /// The dedicated proxy endpoint for which SSL encryption is enabled.
                /// </summary>
                [NameInMap("CertCommonName")]
                [Validation(Required=false)]
                public string CertCommonName { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// The ID of the dedicated proxy endpoint.
                /// </summary>
                [NameInMap("EndpointName")]
                [Validation(Required=false)]
                public string EndpointName { get; set; }

                /// <summary>
                /// The default identifier of the dedicated proxy endpoint. The value is fixed as **RWSplit**.
                /// </summary>
                [NameInMap("EndpointType")]
                [Validation(Required=false)]
                public string EndpointType { get; set; }

                /// <summary>
                /// The time when the certificate expires.
                /// </summary>
                [NameInMap("SslExpiredTime")]
                [Validation(Required=false)]
                public string SslExpiredTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
