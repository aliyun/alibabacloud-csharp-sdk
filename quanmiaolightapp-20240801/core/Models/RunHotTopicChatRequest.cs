// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunHotTopicChatRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("generateOptions")]
        [Validation(Required=false)]
        public List<string> GenerateOptions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-09-13_12</para>
        /// </summary>
        [NameInMap("hotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

        [NameInMap("hotTopics")]
        [Validation(Required=false)]
        public List<string> HotTopics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("imageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("modelCustomPromptTemplate")]
        [Validation(Required=false)]
        public string ModelCustomPromptTemplate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3d1c2ac-f086-4a21-9069-f5631542f5ax</para>
        /// </summary>
        [NameInMap("originalSessionId")]
        [Validation(Required=false)]
        public string OriginalSessionId { get; set; }

        [NameInMap("prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("stepForBroadcastContentConfig")]
        [Validation(Required=false)]
        public RunHotTopicChatRequestStepForBroadcastContentConfig StepForBroadcastContentConfig { get; set; }
        public class RunHotTopicChatRequestStepForBroadcastContentConfig : TeaModel {
            [NameInMap("categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("customHotValueWeights")]
            [Validation(Required=false)]
            public List<RunHotTopicChatRequestStepForBroadcastContentConfigCustomHotValueWeights> CustomHotValueWeights { get; set; }
            public class RunHotTopicChatRequestStepForBroadcastContentConfigCustomHotValueWeights : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>comments</para>
                /// </summary>
                [NameInMap("dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("topicCount")]
            [Validation(Required=false)]
            public int? TopicCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a3d1c2ac-f086-4a21-9069-f5631542f5a2</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
