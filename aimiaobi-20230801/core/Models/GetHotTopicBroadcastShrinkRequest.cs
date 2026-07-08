// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetHotTopicBroadcastShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Whether to compute the total token count</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CalcTotalToken")]
        [Validation(Required=false)]
        public bool? CalcTotalToken { get; set; }

        /// <summary>
        /// <para>categorization Filter</para>
        /// 
        /// <b>Example:</b>
        /// <para>分类筛选</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>hot spot Version</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-11_13</para>
        /// </summary>
        [NameInMap("HotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

        /// <summary>
        /// <para>Full-text index for hot spot Regions (when this parameter is present, current does not take effect)</para>
        /// 
        /// <b>Example:</b>
        /// <para>重庆 成都 浙江 杭州</para>
        /// </summary>
        [NameInMap("LocationQuery")]
        [Validation(Required=false)]
        public string LocationQuery { get; set; }

        /// <summary>
        /// <para>List of Regions for news retrieval (keyword filtering)</para>
        /// </summary>
        [NameInMap("Locations")]
        [Validation(Required=false)]
        public string LocationsShrink { get; set; }

        /// <summary>
        /// <para>Full-text index (full-text retrieval for title, hot spot summary, and Region) (when this parameter is present, current does not take effect)</para>
        /// 
        /// <b>Example:</b>
        /// <para>重庆新闻</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Custom output style configuration</para>
        /// </summary>
        [NameInMap("StepForCustomSummaryStyleConfig")]
        [Validation(Required=false)]
        public string StepForCustomSummaryStyleConfigShrink { get; set; }

        /// <summary>
        /// <para>Hot Spot News Broadcast Content Configuration</para>
        /// </summary>
        [NameInMap("StepForNewsBroadcastContentConfig")]
        [Validation(Required=false)]
        public string StepForNewsBroadcastContentConfigShrink { get; set; }

        /// <summary>
        /// <para>topic Filter</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;主题1&quot;,&quot;主题2&quot;]</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        /// <summary>
        /// <para>UUID of the Alibaba Cloud Model Studio workspace: obtain the <a href="https://help.aliyun.com/document_detail/2587495.html">Workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
