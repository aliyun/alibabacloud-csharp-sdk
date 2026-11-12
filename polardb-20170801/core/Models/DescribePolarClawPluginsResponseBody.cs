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
        /// <para>The list of diagnostic information.</para>
        /// </summary>
        [NameInMap("Diagnostics")]
        [Validation(Required=false)]
        public List<DescribePolarClawPluginsResponseBodyDiagnostics> Diagnostics { get; set; }
        public class DescribePolarClawPluginsResponseBodyDiagnostics : TeaModel {
            /// <summary>
            /// <para>The diagnostic level. Valid values: <c>error</c> and <c>warn</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The details of the diagnostic message.</para>
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
            /// <para>The path to the source file of the associated plugin.</para>
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
        /// <para>The list of plugins.</para>
        /// </summary>
        [NameInMap("Plugins")]
        [Validation(Required=false)]
        public List<DescribePolarClawPluginsResponseBodyPlugins> Plugins { get; set; }
        public class DescribePolarClawPluginsResponseBodyPlugins : TeaModel {
            /// <summary>
            /// <para>The list of provided channel IDs. An empty array indicates that no channel IDs are available.</para>
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
            /// <para>The error message. If this field is missing, no error occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The format of the plugin. This field can be an empty string.</para>
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
            /// <para>The origin of the plugin. Valid values: <c>bundled</c> (built-in), <c>global</c> (global), and <c>user-install</c> (user-installed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("Origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <para>The list of provided provider IDs. An empty array indicates that no provider IDs are available.</para>
            /// </summary>
            [NameInMap("ProviderIds")]
            [Validation(Required=false)]
            public List<string> ProviderIds { get; set; }

            /// <summary>
            /// <para>The path to the plugin entry file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/extensions/openclaw-lark/index.js</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the plugin. Valid values: <c>loaded</c> (loaded), <c>disabled</c> (disabled), and <c>error</c> (failed to load).</para>
            /// 
            /// <b>Example:</b>
            /// <para>loaded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number.</para>
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
