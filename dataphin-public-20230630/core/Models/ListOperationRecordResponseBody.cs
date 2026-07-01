// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListOperationRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The operation log list response.</para>
        /// </summary>
        [NameInMap("OperationLogListResponse")]
        [Validation(Required=false)]
        public ListOperationRecordResponseBodyOperationLogListResponse OperationLogListResponse { get; set; }
        public class ListOperationRecordResponseBodyOperationLogListResponse : TeaModel {
            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The list of operation logs.</para>
            /// </summary>
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public List<ListOperationRecordResponseBodyOperationLogListResponseResultData> ResultData { get; set; }
            public class ListOperationRecordResponseBodyOperationLogListResponseResultData : TeaModel {
                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-15 10:30:00</para>
                /// </summary>
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                /// <summary>
                /// <para>The code type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CodeType")]
                [Validation(Required=false)]
                public int? CodeType { get; set; }

                /// <summary>
                /// <para>The execution duration, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试任务</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>onedata-ide</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The operation record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>987654321</para>
                /// </summary>
                [NameInMap("OperationId")]
                [Validation(Required=false)]
                public long? OperationId { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131211211</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The list of related tables.</para>
                /// </summary>
                [NameInMap("RelationTables")]
                [Validation(Required=false)]
                public List<string> RelationTables { get; set; }

                /// <summary>
                /// <para>The ID of the executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30231123</para>
                /// </summary>
                [NameInMap("Runner")]
                [Validation(Required=false)]
                public string Runner { get; set; }

                /// <summary>
                /// <para>The name of the executor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("RunnerName")]
                [Validation(Required=false)]
                public string RunnerName { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
