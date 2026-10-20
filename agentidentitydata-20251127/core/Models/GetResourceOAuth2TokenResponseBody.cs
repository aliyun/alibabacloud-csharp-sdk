// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceOAuth2TokenResponseBody : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("AuthorizationURL")]
        [Validation(Required=false)]
        public string AuthorizationURL { get; set; }

        [NameInMap("ExpiresIn")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionStatus")]
        [Validation(Required=false)]
        public string SessionStatus { get; set; }

        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

    }

}
