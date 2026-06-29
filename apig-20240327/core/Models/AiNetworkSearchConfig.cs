// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiNetworkSearchConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether the plug-in feature is enabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("defaultEnable")]
        [Validation(Required=false)]
        public bool? DefaultEnable { get; set; }

        /// <summary>
        /// <para>The default search language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("defaultLang")]
        [Validation(Required=false)]
        public string DefaultLang { get; set; }

        /// <summary>
        /// <para>Specifies whether to add reference sources in the answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("needReference")]
        [Validation(Required=false)]
        public bool? NeedReference { get; set; }

        /// <summary>
        /// <para>The plug-in running status.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The format template for reference content. The template must contain at least one %s placeholder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>参考来源:\n%s</para>
        /// </summary>
        [NameInMap("referenceFormat")]
        [Validation(Required=false)]
        public string ReferenceFormat { get; set; }

        /// <summary>
        /// <para>The reference location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>head</para>
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
        /// <para>The list of search engines (multi-engine configuration).</para>
        /// </summary>
        [NameInMap("searchFrom")]
        [Validation(Required=false)]
        public List<AiNetworkConfigSearchEngine> SearchFrom { get; set; }

        /// <summary>
        /// <para>The search term rewriting configuration.</para>
        /// </summary>
        [NameInMap("searchRewrite")]
        [Validation(Required=false)]
        public AiNetworkSearchConfigSearchRewrite SearchRewrite { get; set; }
        public class AiNetworkSearchConfigSearchRewrite : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable search query rewriting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The maximum number of search queries after rewriting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("maxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            /// <summary>
            /// <para>The name of the model used for rewriting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The ID of the rewriting service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-xxx</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The timeout period for the rewriting request, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("timeoutMillisecond")]
            [Validation(Required=false)]
            public int? TimeoutMillisecond { get; set; }

        }

    }

}
