// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The historical task list within the last 6 months.</para>
        /// </summary>
        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public List<ListJobInfoResponseBodyJobInfoList> JobInfoList { get; set; }
        public class ListJobInfoResponseBodyJobInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the task was completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:34Z</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the task was created, in UTC. Format: YYYY-MM-DDTHH:MM:SSZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-14T07:39:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5c9dff751ba**********59d50a967f5</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TranscodeSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the user who initiated the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139109*****84930</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>transcode</para>
        /// </description></item>
        /// <item><description><para>snapshot</para>
        /// </description></item>
        /// <item><description><para>ai</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>transcode</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The media asset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30e5d7**********bd900764de7c0102</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6708D849-F109-1A6C-AC91-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
