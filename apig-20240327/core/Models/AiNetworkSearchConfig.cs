// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkSearchConfig : TeaModel {
        /// <summary>
        /// <para>Whether the network search feature is enabled by default.</para>
        /// </summary>
        [NameInMap("defaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        /// <summary>
        /// <para>The default language for the search query.</para>
        /// </summary>
        [NameInMap("defaultLang")]
        [Validation(Required=false)]
        public string DefaultLang { get; set; }

        /// <summary>
        /// <para>Whether to include references in the search results.</para>
        /// </summary>
        [NameInMap("needReference")]
        [Validation(Required=false)]
        public bool? NeedReference { get; set; }

        /// <summary>
        /// <para>The status of the AI plugin.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The format of the references.</para>
        /// </summary>
        [NameInMap("referenceFormat")]
        [Validation(Required=false)]
        public string ReferenceFormat { get; set; }

        /// <summary>
        /// <para>The location of the references in the response.</para>
        /// </summary>
        [NameInMap("referenceLocation")]
        [Validation(Required=false)]
        public string ReferenceLocation { get; set; }

        /// <summary>
        /// <para>The search engine configuration.</para>
        /// </summary>
        [NameInMap("searchEngineConfig")]
        [Validation(Required=false)]
        public AiNetworkConfigSearchEngine SearchEngineConfig { get; set; }

        /// <summary>
        /// <para>A list of search engine configurations for the network search.</para>
        /// </summary>
        [NameInMap("searchFrom")]
        [Validation(Required=false)]
        public List<AiNetworkConfigSearchEngine> SearchFrom { get; set; }

        /// <summary>
        /// <para>Configuration for search query rewriting.</para>
        /// </summary>
        [NameInMap("searchRewrite")]
        [Validation(Required=false)]
        public AiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
        public class AiNetworkSearchConfigSearchRewrite : TeaModel {
            /// <summary>
            /// <para>Whether to enable the search query rewrite feature.</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The maximum number of rewritten queries to generate.</para>
            /// </summary>
            [NameInMap("maxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            /// <summary>
            /// <para>The name of the model to use for query rewriting.</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The ID of the query rewriting service.</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Timeout for the query rewriting operation, in milliseconds.</para>
            /// </summary>
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

    }

}
