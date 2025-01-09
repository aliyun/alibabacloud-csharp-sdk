// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class CreateEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C5DAA30-****-5181-9B87-9D6181016197</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateEndpointResponseBodyResult Result { get; set; }
        public class CreateEndpointResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>essep-abd***dks</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

    }

}
