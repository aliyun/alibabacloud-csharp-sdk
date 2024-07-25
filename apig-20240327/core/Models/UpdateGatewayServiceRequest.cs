// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayServiceRequest : TeaModel {
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

    }

}
