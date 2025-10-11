// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunWritingV2ShrinkRequest : TeaModel {
        [NameInMap("Articles")]
        [Validation(Required=false)]
        public string ArticlesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DistributeWriting")]
        [Validation(Required=false)]
        public bool? DistributeWriting { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GcNumberSize")]
        [Validation(Required=false)]
        public int? GcNumberSize { get; set; }

        [NameInMap("GcNumberSizeTag")]
        [Validation(Required=false)]
        public string GcNumberSizeTag { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string KeywordsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MiniDocs")]
        [Validation(Required=false)]
        public string MiniDocsShrink { get; set; }

        [NameInMap("OutlineList")]
        [Validation(Required=false)]
        public string OutlineListShrink { get; set; }

        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public string OutlinesShrink { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Template</para>
        /// </summary>
        [NameInMap("PromptMode")]
        [Validation(Required=false)]
        public string PromptMode { get; set; }

        [NameInMap("SearchSources")]
        [Validation(Required=false)]
        public string SearchSourcesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("SourceTraceMethod")]
        [Validation(Required=false)]
        public string SourceTraceMethod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Writing</para>
        /// </summary>
        [NameInMap("Step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        [NameInMap("Summarization")]
        [Validation(Required=false)]
        public string SummarizationShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseSearch")]
        [Validation(Required=false)]
        public bool? UseSearch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WritingParams")]
        [Validation(Required=false)]
        public string WritingParamsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>media</para>
        /// </summary>
        [NameInMap("WritingScene")]
        [Validation(Required=false)]
        public string WritingScene { get; set; }

        [NameInMap("WritingStyle")]
        [Validation(Required=false)]
        public string WritingStyle { get; set; }

    }

}
