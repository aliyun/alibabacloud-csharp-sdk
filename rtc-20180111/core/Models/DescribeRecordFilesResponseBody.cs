// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRecordFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The file list.</para>
        /// </summary>
        [NameInMap("RecordFiles")]
        [Validation(Required=false)]
        public List<DescribeRecordFilesResponseBodyRecordFiles> RecordFiles { get; set; }
        public class DescribeRecordFilesResponseBodyRecordFiles : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourAppId</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourChannelId</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>The creation time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-02T17:36:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The duration of the recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1800</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-01T17:36:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The end time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-02T17:36:00Z</para>
            /// </summary>
            [NameInMap("StopTime")]
            [Validation(Required=false)]
            public string StopTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourTaskId</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The OSS URL of the recording file.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>760bad53276431c499e30dc36f6b****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
