// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PluginAnalysisRequest : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

    }

}
