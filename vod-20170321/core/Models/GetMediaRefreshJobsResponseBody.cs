// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of audio or video purge or prefetch task information.</para>
        /// </summary>
        [NameInMap("MediaRefreshJobs")]
        [Validation(Required=false)]
        public List<GetMediaRefreshJobsResponseBodyMediaRefreshJobs> MediaRefreshJobs { get; set; }
        public class GetMediaRefreshJobsResponseBodyMediaRefreshJobs : TeaModel {
            /// <summary>
            /// <para>The error code. This field is returned when the purge or prefetch task fails to be submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PreloadQueueFull</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message. This field is returned when the purge or prefetch task fails to be submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Preload queue is full, please try again later!</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The filtering policy for playback streams. The value is in JSON format and contains the request parameters of the <a href="https://help.aliyun.com/document_detail/431095.html">SubmitMediaRefreshJob</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Formats&quot;:&quot;mp4,m3u8&quot;, &quot;Definitions&quot;:&quot;HD,SD&quot;,  &quot; StreamType&quot;:&quot;video&quot;,  &quot;ResultType&quot;:&quot;Single&quot;,  &quot; SliceFlag&quot;:false, &quot;SliceCount&quot;: 3}</para>
            /// </summary>
            [NameInMap("FilterPolicy")]
            [Validation(Required=false)]
            public string FilterPolicy { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-20 08:23:22</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-21 08:23:22</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca3a8f6e4957b658067095869****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The ID of the audio or video purge or prefetch task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41d465e31957****</para>
            /// </summary>
            [NameInMap("MediaRefreshJobId")]
            [Validation(Required=false)]
            public string MediaRefreshJobId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b>: succeeded</description></item>
            /// <item><description><b>fail</b>: failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The playback URLs that were successfully purged or prefetched.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://shenzhen.****.aliyuncdn.com/74401a4f546007bf845cd8840****.m3u8,https://shenzhen.****.aliyuncdn.com/24041e7d13582d86604d8****.m3u8">https://shenzhen.****.aliyuncdn.com/74401a4f546007bf845cd8840****.m3u8,https://shenzhen.****.aliyuncdn.com/24041e7d13582d86604d8****.m3u8</a></para>
            /// </summary>
            [NameInMap("SuccessPlayUrls")]
            [Validation(Required=false)]
            public string SuccessPlayUrls { get; set; }

            /// <summary>
            /// <para>The task IDs for the purge or prefetch of playback URLs. Each URL corresponds to one task ID. You can use the task ID to call the <a href="https://help.aliyun.com/document_detail/69214.html">DescribeVodRefreshTasks</a> operation to query the purge or prefetch status of each playback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70422****,9524****</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public string TaskIds { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Refresh</b>: purge</description></item>
            /// <item><description><b>Preload</b>: prefetch</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Preload</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The UserData information specified when the purge or prefetch task was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D">http://example.aliyundoc.com&quot;}</a>, &quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
