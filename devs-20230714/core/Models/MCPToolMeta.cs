// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class MCPToolMeta : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Here is an example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("inputSchema")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-tool</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
