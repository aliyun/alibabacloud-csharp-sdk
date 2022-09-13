// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuthorizeShrinkRequest : TeaModel {
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("hide_consent")]
        [Validation(Required=false)]
        public bool? HideConsent { get; set; }

        [NameInMap("login_type")]
        [Validation(Required=false)]
        public string LoginType { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("response_type")]
        [Validation(Required=false)]
        public string ResponseType { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string ScopeShrink { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
