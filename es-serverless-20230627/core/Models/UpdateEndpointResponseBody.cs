// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class UpdateEndpointResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FBAD8493-87FA-583E-8A4C-D487F2DE90FC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateEndpointResponseBodyResult Result { get; set; }
        public class UpdateEndpointResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ep-bp1i98bcbb1540d0****</para>
            /// </summary>
            [NameInMap("endpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

        }

    }

}
