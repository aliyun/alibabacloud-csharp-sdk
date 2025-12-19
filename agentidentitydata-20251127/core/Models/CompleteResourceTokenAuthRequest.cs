// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class CompleteResourceTokenAuthRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:3030cabc-<b><b>-</b></b>-****-d0054944102a</para>
        /// </summary>
        [NameInMap("SessionURI")]
        [Validation(Required=false)]
        public string SessionURI { get; set; }

        [NameInMap("UserIdentifier")]
        [Validation(Required=false)]
        public CompleteResourceTokenAuthRequestUserIdentifier UserIdentifier { get; set; }
        public class CompleteResourceTokenAuthRequestUserIdentifier : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>externalUser</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eyAgImFsZyI6ICJSU****</para>
            /// </summary>
            [NameInMap("UserJWT")]
            [Validation(Required=false)]
            public string UserJWT { get; set; }

        }

    }

}
