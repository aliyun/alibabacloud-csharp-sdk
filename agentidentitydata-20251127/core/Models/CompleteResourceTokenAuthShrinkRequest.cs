// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class CompleteResourceTokenAuthShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:3030cabc-<b><b>-</b></b>-****-d0054944102a</para>
        /// </summary>
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        [NameInMap("UserIdentifier")]
        [Validation(Required=false)]
        public string UserIdentifierShrink { get; set; }

    }

}
