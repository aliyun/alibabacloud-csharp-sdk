// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitCustomHotTopicBroadcastJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotTopicBroadcastConfig")]
        [Validation(Required=false)]
        public SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfig HotTopicBroadcastConfig { get; set; }
        public class SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StepForCustomSummaryStyleConfig")]
            [Validation(Required=false)]
            public SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForCustomSummaryStyleConfig StepForCustomSummaryStyleConfig { get; set; }
            public class SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForCustomSummaryStyleConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SummaryImageCount")]
                [Validation(Required=false)]
                public int? SummaryImageCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("SummaryModel")]
                [Validation(Required=false)]
                public string SummaryModel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("SummaryPrompt")]
                [Validation(Required=false)]
                public string SummaryPrompt { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StepForNewsBroadcastContentConfig")]
            [Validation(Required=false)]
            public SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForNewsBroadcastContentConfig StepForNewsBroadcastContentConfig { get; set; }
            public class SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForNewsBroadcastContentConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;科技&quot;,&quot;经济&quot;,&quot;时政&quot;,&quot;娱乐&quot;]</para>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                [NameInMap("CustomHotValueWeights")]
                [Validation(Required=false)]
                public List<SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForNewsBroadcastContentConfigCustomHotValueWeights> CustomHotValueWeights { get; set; }
                public class SubmitCustomHotTopicBroadcastJobRequestHotTopicBroadcastConfigStepForNewsBroadcastContentConfigCustomHotValueWeights : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>views</para>
                    /// </summary>
                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public string Dimension { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>维度名称</para>
                    /// </summary>
                    [NameInMap("DimensionName")]
                    [Validation(Required=false)]
                    public string DimensionName { get; set; }

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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>热点版本</para>
        /// </summary>
        [NameInMap("HotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

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
