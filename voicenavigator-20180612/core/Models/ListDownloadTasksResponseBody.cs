// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
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
        /// <para>The download task data.</para>
        /// </summary>
        [NameInMap("DownloadTasks")]
        [Validation(Required=false)]
        public ListDownloadTasksResponseBodyDownloadTasks DownloadTasks { get; set; }
        public class ListDownloadTasksResponseBodyDownloadTasks : TeaModel {
            /// <summary>
            /// <para>A list of download tasks.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDownloadTasksResponseBodyDownloadTasksList> List { get; set; }
            public class ListDownloadTasksResponseBodyDownloadTasksList : TeaModel {
                /// <summary>
                /// <para>A list of download task files.</para>
                /// </summary>
                [NameInMap("DownloadTaskFiles")]
                [Validation(Required=false)]
                public List<ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles> DownloadTaskFiles { get; set; }
                public class ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles : TeaModel {
                    /// <summary>
                    /// <para>The file ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c32bf5675b704dc5b19200a89d2e85f1</para>
                    /// </summary>
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <para>The progress of the file download.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                    /// <summary>
                    /// <para>The status of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Published</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The title of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CBU阿里通信反馈-声音延迟</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1637119221702</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <para>The status of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Expired</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cb9aba69-f578-42b2-aa2f-3e5a41947db8</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The title of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>批量高阶内存整理_2022_02_17_10</para>
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
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D24E0148-6D40-550E-9471-B2C5A34C3D12</para>
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
