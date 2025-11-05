// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class QueryReversedDeductionHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryReversedDeductionHistoryResponseBodyData> Data { get; set; }
        public class QueryReversedDeductionHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.00</para>
            /// </summary>
            [NameInMap("OffsetAmount")]
            [Validation(Required=false)]
            public string OffsetAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationSubmitType")]
            [Validation(Required=false)]
            public string OperationSubmitType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-01 10:22:11 UTC+8</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>132</para>
            /// </summary>
            [NameInMap("OperationUid")]
            [Validation(Required=false)]
            public string OperationUid { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asda1231as</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
