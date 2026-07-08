// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitTopicSelectionPerspectiveAnalysisTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The list of documents to be analyzed. (Provide at least one of documents or topic)</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public string DocumentsShrink { get; set; }

        /// <summary>
        /// <para>The topic selection perspective tasks to be analyzed. By default, this parameter is empty, which means all tasks are analyzed. (TopicSummary: Topic event summary, HotViewPoints: Hot topic selection perspectives, TimedViewPoints: Timeliness topic selection perspectives, WebReviewPoints: Online review topic selection perspectives, FreshViewPoints: Novel topic selection perspectives)</para>
        /// 
        /// <b>Example:</b>
        /// <para>TimedViewPoints</para>
        /// </summary>
        [NameInMap("PerspectiveTypes")]
        [Validation(Required=false)]
        public string PerspectiveTypesShrink { get; set; }

        /// <summary>
        /// <para>The name of the topic to be analyzed. (Provide at least one of documents or topic)</para>
        /// 
        /// <b>Example:</b>
        /// <para>待分析的主题名（documents与topic二者至少传一个）</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
