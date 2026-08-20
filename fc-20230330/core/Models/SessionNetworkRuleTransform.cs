// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SessionNetworkRuleTransform : TeaModel {
        /// <summary>
        /// <para>The list of rules for replacing placeholders in HTTP header values before the request is forwarded to the matched host.</para>
        /// </summary>
        [NameInMap("headerValueReplacements")]
        [Validation(Required=false)]
        public List<SessionNetworkHeaderValueReplacement> HeaderValueReplacements { get; set; }

        /// <summary>
        /// <para>The HTTP headers injected or overwritten before the request is forwarded to the matched host. Header values are returned in plaintext in GetSession and ListSessions.</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

    }

}
