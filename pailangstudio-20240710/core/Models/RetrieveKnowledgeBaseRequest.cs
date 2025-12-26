// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class RetrieveKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Strategy&quot;: &quot;rrf&quot;,
        ///   &quot;RRFK&quot;:60,
        ///   &quot;Weight&quot;: 0.5
        /// }</para>
        /// </summary>
        [NameInMap("HybridStrategyConfig")]
        [Validation(Required=false)]
        public string HybridStrategyConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;FilterCondition&quot;: &quot;and&quot;, 
        ///     &quot;MetaDataFilters&quot;: [
        ///         {
        ///             &quot;Key&quot;: &quot;key1&quot;, 
        ///             &quot;Value&quot;: &quot;value1&quot;, 
        ///             &quot;Operator&quot;: &quot;==&quot;
        ///         },
        ///         {
        ///             &quot;Key&quot;: &quot;key2&quot;, 
        ///             &quot;Value&quot;: &quot;value2&quot;, 
        ///             &quot;Operator&quot;: &quot;!=&quot;
        ///         },
        ///         {
        ///             &quot;Key&quot;: &quot;file_name&quot;, 
        ///             &quot;Value&quot;: &quot;prefix&quot;, 
        ///             &quot;Operator&quot;: &quot;contains&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("MetaDataFilterConditions")]
        [Validation(Required=false)]
        public string MetaDataFilterConditions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dense</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///    &quot;ConnectionId&quot;:&quot;conn-xxx&quot;,
        ///     &quot;Model&quot;: &quot;qwen-max&quot;,
        ///     &quot;TopK&quot;: 5
        /// }</para>
        /// </summary>
        [NameInMap("RerankConfig")]
        [Validation(Required=false)]
        public string RerankConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ConnectionId&quot;:&quot;conn-xxx&quot;,
        ///     &quot;Model&quot;: &quot;qwen-max&quot;,
        ///     &quot;Temperature&quot;: 0.7,
        ///     &quot;TopP&quot;: 0.9,
        ///     &quot;PresencePenalty&quot;: 0.5,
        ///     &quot;FrequencyPenalty&quot;: 0.5,
        ///     &quot;Seed&quot;: 0,
        ///     &quot;MaxTokens&quot;: 1024,
        ///     &quot;Stop&quot;: [],
        ///     &quot;EnableThinking&quot;: true
        /// }</para>
        /// </summary>
        [NameInMap("RewriteConfig")]
        [Validation(Required=false)]
        public string RewriteConfig { get; set; }

        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public float? ScoreThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174***</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
