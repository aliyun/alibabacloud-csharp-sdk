// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetOperationRecordByIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OperationLogDTO")]
        [Validation(Required=false)]
        public GetOperationRecordByIdResponseBodyOperationLogDTO OperationLogDTO { get; set; }
        public class GetOperationRecordByIdResponseBodyOperationLogDTO : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-15 10:30:00</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CodeType")]
            [Validation(Required=false)]
            public int? CodeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试任务</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>onedata-ide</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>987654321</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public long? OperationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>131211211</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("RelationTables")]
            [Validation(Required=false)]
            public List<string> RelationTables { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30231123</para>
            /// </summary>
            [NameInMap("Runner")]
            [Validation(Required=false)]
            public string Runner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("RunnerName")]
            [Validation(Required=false)]
            public string RunnerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
