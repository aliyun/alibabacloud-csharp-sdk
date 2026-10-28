// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class QueryAutomaticWriteOffChangeRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the response. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAutomaticWriteOffChangeRecordsResponseBodyData> Data { get; set; }
        public class QueryAutomaticWriteOffChangeRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The content of the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable automatic write-off and select 500 USD</para>
            /// </summary>
            [NameInMap("ChangeContent")]
            [Validation(Required=false)]
            public string ChangeContent { get; set; }

            /// <summary>
            /// <para>The operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12312312</para>
            /// </summary>
            [NameInMap("OperateId")]
            [Validation(Required=false)]
            public string OperateId { get; set; }

            /// <summary>
            /// <para>The description of the operation source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("OperateSource")]
            [Validation(Required=false)]
            public string OperateSource { get; set; }

            /// <summary>
            /// <para>The time of the operation. Format: YYYY-MM-DD HH:mm:ss UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36 UTC+8</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

        }

        /// <summary>
        /// <para>The message of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8cd24f2917797624314748873d0096</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
