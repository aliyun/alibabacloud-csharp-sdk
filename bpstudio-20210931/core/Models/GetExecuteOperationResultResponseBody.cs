// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetExecuteOperationResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed result of the queried operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetExecuteOperationResultResponseBodyData Data { get; set; }
        public class GetExecuteOperationResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The output of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("Arguments")]
            [Validation(Required=false)]
            public string Arguments { get; set; }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“ ”</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>op_xxxxxxxx</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The status of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot; &quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
