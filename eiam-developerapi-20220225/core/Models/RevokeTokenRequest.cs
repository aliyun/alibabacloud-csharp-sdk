// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class RevokeTokenRequest : TeaModel {
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("token_type_hint")]
        [Validation(Required=false)]
        public string TokenTypeHint { get; set; }

    }

}
