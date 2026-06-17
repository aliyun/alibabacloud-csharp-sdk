// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>An array of diagnostic objects.</para>
        /// </summary>
        [NameInMap("Diagnostics")]
        [Validation(Required=false)]
        public List<DescribePolarClawPluginsResponseBodyDiagnostics> Diagnostics { get; set; }
        public class DescribePolarClawPluginsResponseBodyDiagnostics : TeaModel {
            /// <summary>
            /// <para>The severity level. Valid values: <c>error</c> and <c>warn</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The detailed diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loaded without install/load-path provenance; treat as untracked local code</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the associated plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openclaw-lark</para>
            /// </summary>
            [NameInMap("PluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>The source file path associated with the diagnostic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/extensions/openclaw-lark/index.js</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>An array of plugin objects.</para>
        /// </summary>
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public List<DescribePolarClawPluginsResponseBodyPlugins> Plugins { get; set; }
        public class DescribePolarClawPluginsResponseBodyPlugins : TeaModel {
            /// <summary>
            /// <para>A list of channel IDs, which can be empty.</para>
            /// </summary>
            [NameInMap("ChannelIds")]
            [Validation(Required=false)]
            public List<string> ChannelIds { get; set; }

            /// <summary>
            /// <para>The description of the plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lark/Feishu channel plugin with im/doc/wiki/drive/task/calendar tools</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The error message, or <c>null</c> if no error occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The format of the plugin, which can be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openclaw</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The plugin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openclaw-lark</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The display name of the plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Feishu</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The origin of the plugin. Valid values: <c>bundled</c>, <c>global</c>, and <c>user-install</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>A list of provider IDs, which can be empty.</para>
            /// </summary>
            [NameInMap("ProviderIds")]
            [Validation(Required=false)]
            public List<string> ProviderIds { get; set; }

            /// <summary>
            /// <para>The file path to the plugin\&quot;s entry point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/extensions/openclaw-lark/index.js</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the plugin. Valid values: <c>loaded</c>, <c>disabled</c>, and <c>error</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loaded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number of the plugin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026.4.7</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
