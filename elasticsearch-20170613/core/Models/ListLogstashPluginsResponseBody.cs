// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashPluginsResponseBodyResult> Result { get; set; }
        public class ListLogstashPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The plugin description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The clone filter is for duplicating events.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The plugin name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logstash-filter-clone</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The plugin source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The URL of the plugin documentation.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.html">https://xxx.html</a></para>
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            /// <summary>
            /// <para>The plugin status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INSTALLED: installed</description></item>
            /// <item><description>UNINSTALLED: not installed</description></item>
            /// <item><description>INSTALLING: being installed</description></item>
            /// <item><description>UNINSTALLING: being uninstalled</description></item>
            /// <item><description>UPGRADING: being upgraded</description></item>
            /// <item><description>FAILED: installation failed</description></item>
            /// <item><description>UNKNOWN: the cluster is disconnected and the creation status cannot be retrieved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
