// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PluginAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// <pre><code class="language-[">  {
        ///     &quot;name&quot;: &quot;plugin_name.zip&quot;,// plugin name
        ///     &quot;ossObject&quot;: {
        ///       &quot;bucketName&quot;: &quot;bucketName&quot;,// oss bucket name
        ///       &quot;key&quot;: &quot;my_plugin_dir/plugin_name.zip&quot; // oss file name 
        ///     }
        ///   }
        /// ]
        /// `
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;name&quot;: &quot;plugin_name.zip&quot;,// plugin name
        ///     &quot;ossObject&quot;: {
        ///       &quot;bucketName&quot;: &quot;bucketName&quot;,// oss bucket name
        ///       &quot;key&quot;: &quot;my_plugin_dir/plugin_name.zip&quot; // oss file name 
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a pre-upload check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only performs the check.</description></item>
        /// <item><description>false: Directly uploads the plug-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
