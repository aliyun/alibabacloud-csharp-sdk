// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateSessionNetworkConfig : TeaModel {
        [NameInMap("allowOut")]
        [Validation(Required=false)]
        public List<string> AllowOut { get; set; }

        [NameInMap("denyOut")]
        [Validation(Required=false)]
        public List<string> DenyOut { get; set; }

        /// <summary>
        /// <para>The request transform rules configured by exact target host. If omitted, existing rules are retained. An empty object clears all rules, and a non-empty object replaces all rules entirely. Null is not supported. The transform.headers and transform.headerValueReplacements fields are supported.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public Dictionary<string, List<SessionNetworkRule>> Rules { get; set; }

    }

}
