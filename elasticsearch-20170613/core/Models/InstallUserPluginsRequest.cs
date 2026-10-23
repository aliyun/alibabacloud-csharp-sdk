// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InstallUserPluginsRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom plugins.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;elasticsearchVersion&quot;: &quot;8.17.0&quot;,
        ///     &quot;pluginType&quot;: &quot;CUSTOM_PLUGIN&quot;,
        ///     &quot;name&quot;: &quot;analysis-stempel&quot;,
        ///     &quot;description&quot;: &quot;The Stempel Analysis plugin is <em><b>&quot;,
        ///     &quot;version&quot;: &quot;8.17.0&quot;,
        ///     &quot;fileVersion&quot;: &quot;CAEQnwIYgYDAzYfNj4oaI</b></em>&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly install custom user plugins. Default value: false. Instances with the legacy architecture do not support forced installation.</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
