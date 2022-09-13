// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class TokenRequest : TeaModel {
        [NameInMap("assertion")]
        [Validation(Required=false)]
        public string Assertion { get; set; }

        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
