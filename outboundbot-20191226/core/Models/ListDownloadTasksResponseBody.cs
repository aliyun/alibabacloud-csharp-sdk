// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDownloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of download tasks.</para>
        /// </summary>
        [NameInMap("DownloadTasks")]
        [Validation(Required=false)]
        public ListDownloadTasksResponseBodyDownloadTasks DownloadTasks { get; set; }
        public class ListDownloadTasksResponseBodyDownloadTasks : TeaModel {
            /// <summary>
            /// <para>The array of download tasks.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDownloadTasksResponseBodyDownloadTasksList> List { get; set; }
            public class ListDownloadTasksResponseBodyDownloadTasksList : TeaModel {
                /// <summary>
                /// <para>The list of files for the download task.</para>
                /// </summary>
                [NameInMap("DownloadTaskFiles")]
                [Validation(Required=false)]
                public List<ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles> DownloadTaskFiles { get; set; }
                public class ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles : TeaModel {
                    /// <summary>
                    /// <para>The file ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01f8d11abdb9406996c0c46e7*******</para>
                    /// </summary>
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <para><b>[Deprecated]</b> The completion progress.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                    /// <summary>
                    /// <para>The file status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Pending: Pending.</description></item>
                    /// <item><description>InProgress: In progress.</description></item>
                    /// <item><description>Finished: Finished.</description></item>
                    /// <item><description>Failed: Failed.</description></item>
                    /// <item><description>Expired: Expired.</description></item>
                    /// <item><description>Cancelled: Cancelled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Empty</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GUI-TEST-Create risk</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The expiration time. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1646792941</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The export status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pending: Pending.</description></item>
                /// <item><description>InProgress: In progress.</description></item>
                /// <item><description>Finished: Finished.</description></item>
                /// <item><description>Failed: Failed.</description></item>
                /// <item><description>Expired: Expired.</description></item>
                /// <item><description>Cancelled: Cancelled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Empty</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6b0e547e-501c-480a-812f-d27e28e74f9a</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GUI-TEST-Create risk</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>904CFA7B-8AD9-50FF-9B3E-404B20B9EE31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
