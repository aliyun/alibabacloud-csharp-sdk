// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class GenerateStsTokenRequest : TeaModel {
        [NameInMap("ExpireInSeconds")]
        [Validation(Required=false)]
        public long? ExpireInSeconds { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
