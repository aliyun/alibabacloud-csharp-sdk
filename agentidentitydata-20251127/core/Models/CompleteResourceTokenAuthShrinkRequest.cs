// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class CompleteResourceTokenAuthShrinkRequest : TeaModel {
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        [NameInMap("UserIdentifier")]
        [Validation(Required=false)]
        public string UserIdentifierShrink { get; set; }

    }

}
