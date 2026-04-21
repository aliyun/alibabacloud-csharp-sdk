// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketAuthCodeConfig : TeaModel {
        [NameInMap("authorizationEndpoint")]
        [Validation(Required=false)]
        public string AuthorizationEndpoint { get; set; }

        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("jwkSetUri")]
        [Validation(Required=false)]
        public string JwkSetUri { get; set; }

        [NameInMap("redirectUri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        [NameInMap("tokenEndpoint")]
        [Validation(Required=false)]
        public string TokenEndpoint { get; set; }

        [NameInMap("userInfoEndpoint")]
        [Validation(Required=false)]
        public string UserInfoEndpoint { get; set; }

    }

}
