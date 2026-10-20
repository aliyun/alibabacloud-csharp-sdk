// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class CompleteResourceTokenAuthRequest : TeaModel {
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        [NameInMap("UserIdentifier")]
        [Validation(Required=false)]
        public CompleteResourceTokenAuthRequestUserIdentifier UserIdentifier { get; set; }
        public class CompleteResourceTokenAuthRequestUserIdentifier : TeaModel {
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserJWT")]
            [Validation(Required=false)]
            public string UserJWT { get; set; }

        }

    }

}
