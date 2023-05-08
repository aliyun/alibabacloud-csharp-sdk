// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIngressGatewaysResponseBody : TeaModel {
        /// <summary>
        /// The information about the ingress gateways of the ASM instance.
        /// </summary>
        [NameInMap("IngressGateways")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> IngressGateways { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
