// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawMCPServersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;dev-mcp-server&quot;: &quot;{\&quot;args\&quot;:[\&quot;-y\&quot;,\&quot;@polarclaw/mcp-dev\&quot;],\&quot;command\&quot;:\&quot;node\&quot;}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Servers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Servers { get; set; }

    }

}
