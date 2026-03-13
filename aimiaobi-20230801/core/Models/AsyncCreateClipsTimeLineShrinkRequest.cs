// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncCreateClipsTimeLineShrinkRequest : TeaModel {
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
        public string HighLightConfigShrink { get; set; }

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
