// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class BuildCacheConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ 	&quot;3C75C832-0EAD-40D6-8FA1-2BA9171C926B&quot;: &quot;<del>/.npm&quot;, 	&quot;D256BB7A-1886-4A19-A75B-A1FDC23D5A00&quot;: &quot;</del>/.cache&quot; }</para>
        /// </summary>
        [NameInMap("keyPath")]
        [Validation(Required=false)]
        public Dictionary<string, object> KeyPath { get; set; }

        [NameInMap("paths")]
        [Validation(Required=false)]
        public List<string> Paths { get; set; }

    }

}
