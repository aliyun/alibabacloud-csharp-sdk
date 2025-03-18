// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetHotTopicBroadcastRequest : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("StepForCustomSummaryStyleConfig")]
        [Validation(Required=false)]
        public GetHotTopicBroadcastRequestStepForCustomSummaryStyleConfig StepForCustomSummaryStyleConfig { get; set; }
        public class GetHotTopicBroadcastRequestStepForCustomSummaryStyleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("SummaryImageCount")]
            [Validation(Required=false)]
            public int? SummaryImageCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>摘要模型</para>
            /// </summary>
            [NameInMap("SummaryModel")]
            [Validation(Required=false)]
            public string SummaryModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>摘要-自定义Prompt</para>
            /// </summary>
            [NameInMap("SummaryPrompt")]
            [Validation(Required=false)]
            public string SummaryPrompt { get; set; }

        }

        [NameInMap("StepForNewsBroadcastContentConfig")]
        [Validation(Required=false)]
        public GetHotTopicBroadcastRequestStepForNewsBroadcastContentConfig StepForNewsBroadcastContentConfig { get; set; }
        public class GetHotTopicBroadcastRequestStepForNewsBroadcastContentConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;科技&quot;,&quot;经济&quot;,&quot;时政&quot;,&quot;娱乐&quot;]</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("CustomHotValueWeights")]
            [Validation(Required=false)]
            public List<GetHotTopicBroadcastRequestStepForNewsBroadcastContentConfigCustomHotValueWeights> CustomHotValueWeights { get; set; }
            public class GetHotTopicBroadcastRequestStepForNewsBroadcastContentConfigCustomHotValueWeights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>views</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopicCount")]
            [Validation(Required=false)]
            public int? TopicCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;主题1&quot;,&quot;主题2&quot;]</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

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
