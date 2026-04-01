// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RemovePluginRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///   {
        ///     &quot;name&quot;: &quot;pluginName&quot;,
        ///     &quot;elasticsearchVersion&quot;: &quot;8.17.0&quot;,
        ///     &quot;version&quot;: &quot;8.17.0&quot;,
        ///     &quot;fileVersion&quot;: &quot;CAEQbxiBgIDMoJqe6hkiIGYzM****&quot;,
        ///     &quot;state&quot;: &quot;UNINSTALLED&quot;,
        ///     &quot;source&quot;: &quot;USER&quot;,
        ///     &quot;pluginType&quot;: &quot;CUSTOM_PLUGIN&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
