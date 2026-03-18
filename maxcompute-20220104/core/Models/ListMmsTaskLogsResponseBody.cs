// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsTaskLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of logs.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMmsTaskLogsResponseBodyData> Data { get; set; }
        public class ListMmsTaskLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The operation performed by the migration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create schema if not exists mms_test.default;</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The time when the log was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-17 15:44:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The log ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The result of the migration task operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000015</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            /// <summary>
            /// <para>The migration task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_DOING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The migration task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4023</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3AE5649-EF90-54BD-86D0-C632FA950988</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
