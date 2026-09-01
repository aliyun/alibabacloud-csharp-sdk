// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AnswerKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkb-xxxxx</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16000</para>
        /// </summary>
        [NameInMap("MaxContextChars")]
        [Validation(Required=false)]
        public int? MaxContextChars { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>总结下今年财报</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RerankEnabled")]
        [Validation(Required=false)]
        public bool? RerankEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReturnSources")]
        [Validation(Required=false)]
        public bool? ReturnSources { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.7</para>
        /// </summary>
        [NameInMap("ScoreThreshold")]
        [Validation(Required=false)]
        public double? ScoreThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>semantic</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a minimal test prompt for security verification.</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Return a short summary and test result.</para>
        /// </summary>
        [NameInMap("UserInstructions")]
        [Validation(Required=false)]
        public string UserInstructions { get; set; }

    }

}
