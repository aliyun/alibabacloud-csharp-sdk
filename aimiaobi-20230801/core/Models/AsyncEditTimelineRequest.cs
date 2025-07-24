// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class AsyncEditTimelineRequest : TeaModel {
        [NameInMap("AutoClips")]
        [Validation(Required=false)]
        public bool? AutoClips { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0dbf1055f8a2475d99904c3b76a0ffba</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Timelines")]
        [Validation(Required=false)]
        public List<AsyncEditTimelineRequestTimelines> Timelines { get; set; }
        public class AsyncEditTimelineRequestTimelines : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Clips")]
            [Validation(Required=false)]
            public List<AsyncEditTimelineRequestTimelinesClips> Clips { get; set; }
            public class AsyncEditTimelineRequestTimelinesClips : TeaModel {
                [NameInMap("ClipId")]
                [Validation(Required=false)]
                public string ClipId { get; set; }

                [NameInMap("ContentInner")]
                [Validation(Required=false)]
                public string ContentInner { get; set; }

                [NameInMap("In")]
                [Validation(Required=false)]
                public int? In { get; set; }

                [NameInMap("InEx")]
                [Validation(Required=false)]
                public float? InEx { get; set; }

                [NameInMap("Out")]
                [Validation(Required=false)]
                public int? Out { get; set; }

                [NameInMap("OutEx")]
                [Validation(Required=false)]
                public float? OutEx { get; set; }

                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

                [NameInMap("VideoName")]
                [Validation(Required=false)]
                public string VideoName { get; set; }

            }

            [NameInMap("TimelineId")]
            [Validation(Required=false)]
            public string TimelineId { get; set; }

        }

        /// <summary>
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
