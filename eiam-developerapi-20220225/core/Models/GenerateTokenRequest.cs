// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenRequest : TeaModel {
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("code_verifier")]
        [Validation(Required=false)]
        public string CodeVerifier { get; set; }

        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("exclusive_tag")]
        [Validation(Required=false)]
        public string ExclusiveTag { get; set; }

        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
