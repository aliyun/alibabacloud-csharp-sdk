// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListUserPluginResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;totalCount\&quot;: 1, \&quot;X-Total-Count\&quot;: 1}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Headers { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EEF8FAE-EEDD***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result array.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListUserPluginResponseBodyResult> Result { get; set; }
        public class ListUserPluginResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of plug-ins with the same name.</para>
            /// </summary>
            [NameInMap("bingoPlugins")]
            [Validation(Required=false)]
            public List<ListUserPluginResponseBodyResultBingoPlugins> BingoPlugins { get; set; }
            public class ListUserPluginResponseBodyResultBingoPlugins : TeaModel {
                /// <summary>
                /// <para>The plug-in description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The plugin***</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The Elasticsearch version of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("elasticsearchVersion")]
                [Validation(Required=false)]
                public string ElasticsearchVersion { get; set; }

                /// <summary>
                /// <para>The unique identifier of the plug-in.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CAEQaRiBgIDI2tie6hkiIGIwM2I3MjZmNjk3YzR***</para>
                /// </summary>
                [NameInMap("fileVersion")]
                [Validation(Required=false)]
                public string FileVersion { get; set; }

                /// <summary>
                /// <para>The plug-in name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dynamic-name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The plug-in source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>USER: custom plug-in.</description></item>
                /// <item><description>SYSTEM: system preset plug-in.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The plug-in status. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>INSTALLED</description></item>
                /// <item><description>UNINSTALLED</description></item>
                /// <item><description>INSTALLING</description></item>
                /// <item><description>UNINSTALLING</description></item>
                /// <item><description>UPGRADING</description></item>
                /// <item><description>FAILED</description></item>
                /// <item><description>UNKNOWN</description></item>
                /// <item><description>UPLOADING</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UNINSTALLED</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The plug-in version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The plug-in name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ct-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The plug-in source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The plug-in status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNINSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The plug-in version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.17.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
