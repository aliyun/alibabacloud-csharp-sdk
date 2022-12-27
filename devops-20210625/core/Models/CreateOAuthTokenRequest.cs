// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateOAuthTokenRequest : TeaModel {
        /// <summary>
        /// clientId
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// client_secret
        /// </summary>
        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("grantType")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

        [NameInMap("login")]
        [Validation(Required=false)]
        public string Login { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
