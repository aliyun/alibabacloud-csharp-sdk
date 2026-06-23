// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class InvokePluginRequest : TeaModel {
        /// <summary>
        /// <para>Request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;query&quot;: &quot;介绍一下贵金属业务&quot;,
        ///         &quot;filters&quot;: [
        ///             {
        ///                 &quot;libraryId&quot;: &quot;9xznrxw&quot;
        ///             }
        ///         ],
        ///         &quot;topK&quot;: 1
        ///     }</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// <para>The plugin ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3mj87da7zr</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

    }

}
