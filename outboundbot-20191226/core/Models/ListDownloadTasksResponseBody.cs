// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDownloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DownloadTasks")]
        [Validation(Required=false)]
        public ListDownloadTasksResponseBodyDownloadTasks DownloadTasks { get; set; }
        public class ListDownloadTasksResponseBodyDownloadTasks : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDownloadTasksResponseBodyDownloadTasksList> List { get; set; }
            public class ListDownloadTasksResponseBodyDownloadTasksList : TeaModel {
                [NameInMap("DownloadTaskFiles")]
                [Validation(Required=false)]
                public List<ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles> DownloadTaskFiles { get; set; }
                public class ListDownloadTasksResponseBodyDownloadTasksListDownloadTaskFiles : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>UPLOADED/RECORDING/d5c651b3-3c0f-44b8-aafd-40526f2fb43d/dd33377f-abad-471b-84dd-04aed572ce60_2.wav</para>
                    /// </summary>
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public int? Progress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Empty</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1646792941</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Empty</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6b0e547e-501c-480a-812f-d27e28e74f9a</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>904CFA7B-8AD9-50FF-9B3E-404B20B9EE31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
