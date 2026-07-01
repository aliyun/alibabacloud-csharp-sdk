// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetOperationRecordDetailResponseBody : TeaModel {
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
        /// <para>The execution record detail response.</para>
        /// </summary>
        [NameInMap("OperationRecordDetailResponse")]
        [Validation(Required=false)]
        public GetOperationRecordDetailResponseBodyOperationRecordDetailResponse OperationRecordDetailResponse { get; set; }
        public class GetOperationRecordDetailResponseBodyOperationRecordDetailResponse : TeaModel {
            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12113111</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task started...
            /// Executing SQL...
            /// Task finished successfully.</para>
            /// </summary>
            [NameInMap("LogContent")]
            [Validation(Required=false)]
            public string LogContent { get; set; }

            /// <summary>
            /// <para>The operation record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>987654321</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The list of execution results.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetOperationRecordDetailResponseBodyOperationRecordDetailResponseResults> Results { get; set; }
            public class GetOperationRecordDetailResponseBodyOperationRecordDetailResponseResults : TeaModel {
                /// <summary>
                /// <para>The result index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The result content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;count&quot;:100,&quot;data&quot;:[{&quot;id&quot;:1}]}</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>The result SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM test_table</para>
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task_123456</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The result title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>查询结果</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

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
