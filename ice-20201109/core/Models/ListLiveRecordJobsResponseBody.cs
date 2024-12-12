// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of live stream recording jobs.</para>
        /// </summary>
        [NameInMap("LiveRecordJobs")]
        [Validation(Required=false)]
        public List<ListLiveRecordJobsResponseBodyLiveRecordJobs> LiveRecordJobs { get; set; }
        public class ListLiveRecordJobsResponseBodyLiveRecordJobs : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T03:26:36Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the recording job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab0e3e76-1e9d-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the recording job.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/imsnotify">https://example.com/imsnotify</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            /// <summary>
            /// <para>The storage address of the recording.</para>
            /// </summary>
            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public ListLiveRecordJobsResponseBodyLiveRecordJobsRecordOutput RecordOutput { get; set; }
            public class ListLiveRecordJobsResponseBodyLiveRecordJobsRecordOutput : TeaModel {
                /// <summary>
                /// <para>The bucket name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imsbucket1</para>
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// <para>The endpoint of the storage service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss-cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The type of the storage address.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>vod</description></item>
                /// <item><description>oss</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The state of the recording job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paused</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The URL of the live stream.</para>
            /// </summary>
            [NameInMap("StreamInput")]
            [Validation(Required=false)]
            public ListLiveRecordJobsResponseBodyLiveRecordJobsStreamInput StreamInput { get; set; }
            public class ListLiveRecordJobsResponseBodyLiveRecordJobsStreamInput : TeaModel {
                /// <summary>
                /// <para>The type of the live stream URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URL of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://example-live.com/live/stream1</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The ID of the recording template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the recording template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A27DFFA4-F272-5563-8363-CB0BC42740BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
