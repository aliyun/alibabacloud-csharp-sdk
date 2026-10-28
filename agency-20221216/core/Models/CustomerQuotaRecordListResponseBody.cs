// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CustomerQuotaRecordListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the returned result. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CustomerQuotaRecordListResponseBodyData> Data { get; set; }
        public class CustomerQuotaRecordListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The method used to submit the operation, such as API or ACPN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACPN</para>
            /// </summary>
            [NameInMap("OperationSubmitType")]
            [Validation(Required=false)]
            public string OperationSubmitType { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. Format: YYYY-MM-DD HH:mm:ss UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-15 10:34:36 UTC+8</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The code of the change type. Valid values: all: All, quota_create: Create, quota_amount_adjust: Quota adjustment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota_amount_adjust</para>
            /// </summary>
            [NameInMap("OperationTypeCode")]
            [Validation(Required=false)]
            public string OperationTypeCode { get; set; }

            /// <summary>
            /// <para>The description of the change type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Quota Adjustment</para>
            /// </summary>
            [NameInMap("OperationTypeDesc")]
            [Validation(Required=false)]
            public string OperationTypeDesc { get; set; }

            /// <summary>
            /// <para>The UID of the operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5113766248601929</para>
            /// </summary>
            [NameInMap("OperationUid")]
            [Validation(Required=false)]
            public string OperationUid { get; set; }

            /// <summary>
            /// <para>The amount after the update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.00</para>
            /// </summary>
            [NameInMap("UpdateAfterAmount")]
            [Validation(Required=false)]
            public string UpdateAfterAmount { get; set; }

            /// <summary>
            /// <para>The changed amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-100.00</para>
            /// </summary>
            [NameInMap("UpdateAmount")]
            [Validation(Required=false)]
            public string UpdateAmount { get; set; }

            /// <summary>
            /// <para>The amount before the update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>221.00</para>
            /// </summary>
            [NameInMap("UpdateBeforeAmount")]
            [Validation(Required=false)]
            public string UpdateBeforeAmount { get; set; }

        }

        /// <summary>
        /// <para>The description of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a0ae16849855284594613d874e</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
