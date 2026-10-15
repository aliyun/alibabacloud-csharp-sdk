// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryEvaluateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEvaluateListResponseBodyData Data { get; set; }
        public class QueryEvaluateListResponseBodyData : TeaModel {
            [NameInMap("EvaluateList")]
            [Validation(Required=false)]
            public QueryEvaluateListResponseBodyDataEvaluateList EvaluateList { get; set; }
            public class QueryEvaluateListResponseBodyDataEvaluateList : TeaModel {
                [NameInMap("Evaluate")]
                [Validation(Required=false)]
                public List<QueryEvaluateListResponseBodyDataEvaluateListEvaluate> Evaluate { get; set; }
                public class QueryEvaluateListResponseBodyDataEvaluateListEvaluate : TeaModel {
                    [NameInMap("BillCycle")]
                    [Validation(Required=false)]
                    public string BillCycle { get; set; }

                    [NameInMap("BillId")]
                    [Validation(Required=false)]
                    public long? BillId { get; set; }

                    [NameInMap("BizTime")]
                    [Validation(Required=false)]
                    public string BizTime { get; set; }

                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("CanInvoiceAmount")]
                    [Validation(Required=false)]
                    public long? CanInvoiceAmount { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InvoicedAmount")]
                    [Validation(Required=false)]
                    public long? InvoicedAmount { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OffsetAcceptAmount")]
                    [Validation(Required=false)]
                    public long? OffsetAcceptAmount { get; set; }

                    [NameInMap("OffsetCostAmount")]
                    [Validation(Required=false)]
                    public long? OffsetCostAmount { get; set; }

                    [NameInMap("OpId")]
                    [Validation(Required=false)]
                    public string OpId { get; set; }

                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public long? OriginalAmount { get; set; }

                    [NameInMap("OutBizId")]
                    [Validation(Required=false)]
                    public string OutBizId { get; set; }

                    [NameInMap("PresentAmount")]
                    [Validation(Required=false)]
                    public long? PresentAmount { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total invoiced amount that meets the filter criteria. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("TotalInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalInvoiceAmount { get; set; }

            /// <summary>
            /// <para>The total invoiceable amount that meets the filter criteria. Unit: cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("TotalUnAppliedInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalUnAppliedInvoiceAmount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D35FF10E-1B2E-4ABA-8401-0AE17725F50B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
