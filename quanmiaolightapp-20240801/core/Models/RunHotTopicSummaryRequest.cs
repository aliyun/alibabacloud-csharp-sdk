// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunHotTopicSummaryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16_8</para>
        /// </summary>
        [NameInMap("hotTopicVersion")]
        [Validation(Required=false)]
        public string HotTopicVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("stepForCustomSummaryStyleConfig")]
        [Validation(Required=false)]
        public RunHotTopicSummaryRequestStepForCustomSummaryStyleConfig StepForCustomSummaryStyleConfig { get; set; }
        public class RunHotTopicSummaryRequestStepForCustomSummaryStyleConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("summaryImageCount")]
            [Validation(Required=false)]
            public int? SummaryImageCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-max</para>
            /// </summary>
            [NameInMap("summaryModel")]
            [Validation(Required=false)]
            public string SummaryModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("summaryPrompt")]
            [Validation(Required=false)]
            public string SummaryPrompt { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("topicIds")]
        [Validation(Required=false)]
        public List<string> TopicIds { get; set; }

    }

}
