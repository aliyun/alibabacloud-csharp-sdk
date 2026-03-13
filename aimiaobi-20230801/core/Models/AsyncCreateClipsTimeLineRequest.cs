// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncCreateClipsTimeLineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>素材附加信息</para>
        /// </summary>
        [NameInMap("AdditionalContent")]
        [Validation(Required=false)]
        public string AdditionalContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自定义口播内容</para>
        /// </summary>
        [NameInMap("CustomContent")]
        [Validation(Required=false)]
        public string CustomContent { get; set; }

        [NameInMap("HighLightConfig")]
        [Validation(Required=false)]
        public AsyncCreateClipsTimeLineRequestHighLightConfig HighLightConfig { get; set; }
        public class AsyncCreateClipsTimeLineRequestHighLightConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HtAnalyzeRhythm")]
            [Validation(Required=false)]
            public bool? HtAnalyzeRhythm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[
            ///         &quot;高清演员近景特写镜头【高优】&quot;,
            ///         &quot;演出高潮-沉浸表演【高优】&quot;,
            ///         &quot;演出高潮-近景表情【高优】&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("HtHighQualityLabel")]
            [Validation(Required=false)]
            public List<string> HtHighQualityLabel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[
            ///         &quot;画面昏暗&quot;,
            ///         &quot;采访画面&quot;,
            ///         &quot;字幕画面&quot;
            /// ]</para>
            /// </summary>
            [NameInMap("HtLowQualityLabel")]
            [Validation(Required=false)]
            public List<string> HtLowQualityLabel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HtMaxTimeLength")]
            [Validation(Required=false)]
            public int? HtMaxTimeLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HtMinTimeLength")]
            [Validation(Required=false)]
            public int? HtMinTimeLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>请从输入的音乐演出视频中，自动识别并提取出「最具视觉冲击力、情感爆发力或独特吸引力」...</para>
            /// </summary>
            [NameInMap("HtPrompt")]
            [Validation(Required=false)]
            public string HtPrompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("HtSingleShotLen")]
            [Validation(Required=false)]
            public int? HtSingleShotLen { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>默认开启</para>
        /// </summary>
        [NameInMap("NoRefVideo")]
        [Validation(Required=false)]
        public bool? NoRefVideo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>口播内容是乌镇旅游宣传广告，口播内容时长约为1分钟，开头要描述乌镇是千年文化传承的江南水乡，之后要体现乌镇的传统手工艺、美食和美景，最后要号召大家来乌镇旅游</para>
        /// </summary>
        [NameInMap("ProcessPrompt")]
        [Validation(Required=false)]
        public string ProcessPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecommendAudio")]
        [Validation(Required=false)]
        public bool? RecommendAudio { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AA2AE16-D873-5C5F-9708-15396C382EB1</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null - 通用口播
        ///  0-通用口播
        ///  1- 高光</para>
        /// </summary>
        [NameInMap("TimelineScene")]
        [Validation(Required=false)]
        public int? TimelineScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
