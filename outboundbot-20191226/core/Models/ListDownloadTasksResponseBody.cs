// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDownloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Download task list</para>
        /// </summary>
        [NameInMap("DownloadTasks")]
        [Validation(Required=false)]
        public ListDownloadTasksResponseBodyDownloadTasks DownloadTasks { get; set; }
        public class ListDownloadTasksResponseBodyDownloadTasks : TeaModel {
            /// <summary>
            /// <para>Download task array</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDownloadTasksResponseBodyDownloadTasksList> List { get; set; }
            public class ListDownloadTasksResponseBodyDownloadTasksList : TeaModel {
                /// <summary>
                /// <para>Download task file list</para>
                /// </summary>
                [NameInMap("DownloadTaskFiles")]
                [Validation(Required=false)]
                public List<ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles> DownloadTaskFiles { get; set; }
                public class ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles : TeaModel {
                    /// <summary>
                    /// <para>File ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>01f8d11abdb9406996c0c46e7*******</para>
                    /// </summary>
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <para>Completion progress [Deprecated]</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                    /// <summary>
                    /// <para>File status</para>
                    /// <list type="bullet">
                    /// <item><description><para>Pending: Pending</para>
                    /// </description></item>
                    /// <item><description><para>InProgress: In progress</para>
                    /// </description></item>
                    /// <item><description><para>Finished: Completed</para>
                    /// </description></item>
                    /// <item><description><para>Failed: Failed</para>
                    /// </description></item>
                    /// <item><description><para>Expired: Expired</para>
                    /// </description></item>
                    /// <item><description><para>Cancelled: Canceled</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Empty</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Title</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GUI-TEST-新建风险</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1646792941</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>Export status.</para>
                /// <list type="bullet">
                /// <item><description><para>Pending: Pending</para>
                /// </description></item>
                /// <item><description><para>InProgress: In progress</para>
                /// </description></item>
                /// <item><description><para>Finished: Completed</para>
                /// </description></item>
                /// <item><description><para>Failed: Failed</para>
                /// </description></item>
                /// <item><description><para>Expired: Expired</para>
                /// </description></item>
                /// <item><description><para>Cancelled: Canceled</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Empty</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Task ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>6b0e547e-501c-480a-812f-d27e28e74f9a</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>Title</para>
                /// 
                /// <b>Example:</b>
                /// <para>GUI-TEST-新建风险</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Count</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>904CFA7B-8AD9-50FF-9B3E-404B20B9EE31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
