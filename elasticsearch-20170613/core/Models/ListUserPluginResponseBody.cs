// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListUserPluginResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;totalCount\&quot;: 1, \&quot;X-Total-Count\&quot;: 1}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Headers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5EEF8FAE-EEDD***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListUserPluginResponseBodyResult> Result { get; set; }
        public class ListUserPluginResponseBodyResult : TeaModel {
            [NameInMap("bingoPlugins")]
            [Validation(Required=false)]
            public List<ListUserPluginResponseBodyResultBingoPlugins> BingoPlugins { get; set; }
            public class ListUserPluginResponseBodyResultBingoPlugins : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>The plugin***</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("elasticsearchVersion")]
                [Validation(Required=false)]
                public string ElasticsearchVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAEQaRiBgIDI2tie6hkiIGIwM2I3MjZmNjk3YzR***</para>
                /// </summary>
                [NameInMap("fileVersion")]
                [Validation(Required=false)]
                public string FileVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dynamic-name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UNINSTALLED</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.17.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ct-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNINSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8.17.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
