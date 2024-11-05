// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CustomerQuotaRecordListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code of returning result, 200 means success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Listed data of returning result</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CustomerQuotaRecordListResponseBodyData> Data { get; set; }
        public class CustomerQuotaRecordListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The way to submit the quota adjustment operation. API/ACPN</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationSubmitType")]
            [Validation(Required=false)]
            public string OperationSubmitType { get; set; }

            /// <summary>
            /// <para>The time of submit the quota adjustment operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36 UTC+8</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>Operation Type Enum</br>
            /// all All types</br>
            /// quota_create Create quota</br>
            /// quota_amount_adjust Adjust the amount of quota</br></para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_amount_adjust</para>
            /// </summary>
            [NameInMap("OperationTypeCode")]
            [Validation(Required=false)]
            public string OperationTypeCode { get; set; }

            /// <summary>
            /// <para>The description of submitted quota adjustment operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Quota Adjustment</para>
            /// </summary>
            [NameInMap("OperationTypeDesc")]
            [Validation(Required=false)]
            public string OperationTypeDesc { get; set; }

            /// <summary>
            /// <para>The UID of operator(Partner\&quot;s UID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5113766248601929</para>
            /// </summary>
            [NameInMap("OperationUid")]
            [Validation(Required=false)]
            public string OperationUid { get; set; }

            /// <summary>
            /// <para>Updated quota amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.00</para>
            /// </summary>
            [NameInMap("UpdateAfterAmount")]
            [Validation(Required=false)]
            public string UpdateAfterAmount { get; set; }

            /// <summary>
            /// <para>The difference amount between updated quota and original quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-100.00</para>
            /// </summary>
            [NameInMap("UpdateAmount")]
            [Validation(Required=false)]
            public string UpdateAmount { get; set; }

            /// <summary>
            /// <para>Original quota amount</para>
            /// 
            /// <b>Example:</b>
            /// <para>221.00</para>
            /// </summary>
            [NameInMap("UpdateBeforeAmount")]
            [Validation(Required=false)]
            public string UpdateBeforeAmount { get; set; }

        }

        /// <summary>
        /// <para>Description of returning data</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Record number on each page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>ID of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a0ae16849855284594613d874e</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total volume</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
