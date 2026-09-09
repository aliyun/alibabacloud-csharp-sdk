// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTimerLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsTimerLogsResponseBodyData Data { get; set; }
        public class ListMmsTimerLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of logs.</para>
            /// </summary>
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsTimerLogsResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsTimerLogsResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <para>The logged action for the migration job created by the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>start job</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The creation time of the log entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 15:44:17</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the asynchronous task for the migration job created by the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1003476</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>A detailed message about the action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>start job success</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200018</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public long? SourceId { get; set; }

                /// <summary>
                /// <para>The status of the migration job created by the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DOING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b87b7e716665825896565060e87a4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
