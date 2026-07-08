// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncEditTimelineRequest : TeaModel {
        /// <summary>
        /// <para>Enable automatic clip adjustment</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoClips")]
        [Validation(Required=false)]
        public bool? AutoClips { get; set; }

        /// <summary>
        /// <para>Unique identifier of the task</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0dbf1055f8a2475d99904c3b76a0ffba</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Array structure of video editing timelines</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Timelines")]
        [Validation(Required=false)]
        public List<AsyncEditTimelineRequestTimelines> Timelines { get; set; }
        public class AsyncEditTimelineRequestTimelines : TeaModel {
            /// <summary>
            /// <para>Array of video clips</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public List<AsyncEditTimelineRequestTimelinesClips> Clips { get; set; }
            public class AsyncEditTimelineRequestTimelinesClips : TeaModel {
                /// <summary>
                /// <para>Clip ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123jjdax
                /// 新增可为空</para>
                /// </summary>
                [NameInMap("ClipId")]
                [Validation(Required=false)]
                public string ClipId { get; set; }

                /// <summary>
                /// <para>Segmented voice-over script</para>
                /// 
                /// <b>Example:</b>
                /// <para>口播文案分段
                /// 不可为空</para>
                /// </summary>
                [NameInMap("ContentInner")]
                [Validation(Required=false)]
                public string ContentInner { get; set; }

                /// <summary>
                /// <para>Start time, in seconds. Deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0
                /// 不可为空</para>
                /// </summary>
                [NameInMap("In")]
                [Validation(Required=false)]
                public int? In { get; set; }

                /// <summary>
                /// <para>Clip start time, in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.45</para>
                /// </summary>
                [NameInMap("InEx")]
                [Validation(Required=false)]
                public float? InEx { get; set; }

                /// <summary>
                /// <para>End time, in seconds. Deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5
                /// 不可为空</para>
                /// </summary>
                [NameInMap("Out")]
                [Validation(Required=false)]
                public int? Out { get; set; }

                /// <summary>
                /// <para>Clip end time, in milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.66</para>
                /// </summary>
                [NameInMap("OutEx")]
                [Validation(Required=false)]
                public float? OutEx { get; set; }

                /// <summary>
                /// <para>Video ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>7036227ae3ab71efbb4a6733a68f0102
                /// 不可为空</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                /// <summary>
                /// <para>Video name</para>
                /// 
                /// <b>Example:</b>
                /// <para>123.mp4
                /// 不可为空</para>
                /// </summary>
                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

            }

            /// <summary>
            /// <para>Timeline ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>sdfjhks
            /// 新增可为空</para>
            /// </summary>
            [NameInMap("TimelineId")]
            [Validation(Required=false)]
            public string TimelineId { get; set; }

        }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">Model Studio workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-az2gglkjauwnnhpq</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
