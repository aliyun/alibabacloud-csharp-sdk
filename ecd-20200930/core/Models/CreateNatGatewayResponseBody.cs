// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNatGatewayResponseBody : TeaModel {
        [NameInMap("ForwardTableIds")]
        [Validation(Required=false)]
        public List<string> ForwardTableIds { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnatTableIds")]
        [Validation(Required=false)]
        public List<string> SnatTableIds { get; set; }

    }

}
