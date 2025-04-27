// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListLogstashPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The address of the documentation for the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the plug-in. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INSTALLED: Installed</description></item>
        /// <item><description>UNINSTALLED: Not installed</description></item>
        /// <item><description>INSTALLING: The instance is being installed.</description></item>
        /// <item><description>UNINSTALLING: The instance is being uninstalled.</description></item>
        /// <item><description>UPGRADING: The backup gateway is being upgraded.</description></item>
        /// <item><description>FAILED: Installation failed</description></item>
        /// <item><description>UNKNOWN: The cluster is lost and cannot be created.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLogstashPluginsResponseBodyResult> Result { get; set; }
        public class ListLogstashPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The source of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The clone filter is for duplicating events.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logstash-filter-clone</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.html">https://xxx.html</a></para>
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
