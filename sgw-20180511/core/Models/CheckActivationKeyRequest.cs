// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CheckActivationKeyRequest : TeaModel {
        [NameInMap("CryptKey")]
        [Validation(Required=false)]
        public string CryptKey { get; set; }

        [NameInMap("CryptText")]
        [Validation(Required=false)]
        public string CryptText { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
