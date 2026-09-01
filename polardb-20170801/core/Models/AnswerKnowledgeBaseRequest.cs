// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AnswerKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The maximum number of context characters. Valid values: 1000 to 32000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16000</para>
        /// </summary>
        [NameInMap("MaxContextChars")]
        [Validation(Required=false)]
        public int? MaxContextChars { get; set; }

        /// <summary>
        /// <para>The user query text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Summarize this year\&quot;s financial report</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RerankEnabled")]
        [Validation(Required=false)]
        public bool? RerankEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to return citation sources. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReturnSources")]
        [Validation(Required=false)]
        public bool? ReturnSources { get; set; }

        /// <summary>
        /// <para>The similarity score threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values: knn, rrf, precise, semantic, and balanced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>semantic</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a minimal test prompt for security verification.</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The number of results to recall during retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The supplementary user instructions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Return a short summary and test result.</para>
        /// </summary>
        [NameInMap("UserInstructions")]
        [Validation(Required=false)]
        public string UserInstructions { get; set; }

    }

}
