// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ExportHotTopicPlanningProposalsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>025c6cee437741368098b790c90166f8</para>
        /// </summary>
        [NameInMap("CustomViewPointIds")]
        [Validation(Required=false)]
        public string CustomViewPointIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>导出文档类型，word:导出为word,xmind:导处为xmind</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        [NameInMap("Titles")]
        [Validation(Required=false)]
        public string TitlesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜主题</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>热榜源</para>
        /// </summary>
        [NameInMap("TopicSource")]
        [Validation(Required=false)]
        public string TopicSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>选题策划类型：CustomViewPoints:自定义视角，HotViewPoints:热门视角、TimedViewPoints:时效性视角、WebReviewPoints:网友视角、FreshViewPoints:新颖视角</para>
        /// </summary>
        [NameInMap("ViewPointType")]
        [Validation(Required=false)]
        public string ViewPointType { get; set; }

    }

}
