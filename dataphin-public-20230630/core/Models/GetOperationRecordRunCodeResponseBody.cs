// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetOperationRecordRunCodeResponseBody : TeaModel {
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
        /// <para>The operation log code response.</para>
        /// </summary>
        [NameInMap("OperationLogCodeResponse")]
        [Validation(Required=false)]
        public GetOperationRecordRunCodeResponseBodyOperationLogCodeResponse OperationLogCodeResponse { get; set; }
        public class GetOperationRecordRunCodeResponseBodyOperationLogCodeResponse : TeaModel {
            /// <summary>
            /// <para>The code content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM test_table WHERE id = 1;</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The operator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public int? OperatorId { get; set; }

            /// <summary>
            /// <para>The operator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL查询节点</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The number of SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SqlNum")]
            [Validation(Required=false)]
            public int? SqlNum { get; set; }

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
