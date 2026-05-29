// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class QueryAutomaticWriteOffChangeRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAutomaticWriteOffChangeRecordsResponseBodyData> Data { get; set; }
        public class QueryAutomaticWriteOffChangeRecordsResponseBodyData : TeaModel {
            [NameInMap("ChangeContent")]
            [Validation(Required=false)]
            public string ChangeContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12312312</para>
            /// </summary>
            [NameInMap("OperateId")]
            [Validation(Required=false)]
            public string OperateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>API</para>
            /// </summary>
            [NameInMap("OperateSource")]
            [Validation(Required=false)]
            public string OperateSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36 UTC+8</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8cd24f2917797624314748873d0096</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
