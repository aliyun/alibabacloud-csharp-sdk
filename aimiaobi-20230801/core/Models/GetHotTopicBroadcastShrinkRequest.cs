// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetHotTopicBroadcastShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CalcTotalToken")]
        [Validation(Required=false)]
        public bool? CalcTotalToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>分类筛选</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-10-11_13</para>
        /// </summary>
        [NameInMap("HotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

        [NameInMap("LocationQuery")]
        [Validation(Required=false)]
        public string LocationQuery { get; set; }

        [NameInMap("Locations")]
        [Validation(Required=false)]
        public string LocationsShrink { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("StepForCustomSummaryStyleConfig")]
        [Validation(Required=false)]
        public string StepForCustomSummaryStyleConfigShrink { get; set; }

        [NameInMap("StepForNewsBroadcastContentConfig")]
        [Validation(Required=false)]
        public string StepForNewsBroadcastContentConfigShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;主题1&quot;,&quot;主题2&quot;]</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

        /// <summary>
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
