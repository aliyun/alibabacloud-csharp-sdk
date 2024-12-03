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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEvaluateListResponseBodyData Data { get; set; }
        public class QueryEvaluateListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data returned.</para>
            /// </summary>
            [NameInMap("EvaluateList")]
            [Validation(Required=false)]
            public QueryEvaluateListResponseBodyDataEvaluateList EvaluateList { get; set; }
            public class QueryEvaluateListResponseBodyDataEvaluateList : TeaModel {
                [NameInMap("Evaluate")]
                [Validation(Required=false)]
                public List<QueryEvaluateListResponseBodyDataEvaluateListEvaluate> Evaluate { get; set; }
                public class QueryEvaluateListResponseBodyDataEvaluateListEvaluate : TeaModel {
                    /// <summary>
                    /// <para>The billing cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>202002</para>
                    /// </summary>
                    [NameInMap("BillCycle")]
                    [Validation(Required=false)]
                    public string BillCycle { get; set; }

                    /// <summary>
                    /// <para>The ID of the bill.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>234543254325</para>
                    /// </summary>
                    [NameInMap("BillId")]
                    [Validation(Required=false)]
                    public long? BillId { get; set; }

                    /// <summary>
                    /// <para>The time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-10-10 18:05:44</para>
                    /// </summary>
                    [NameInMap("BizTime")]
                    [Validation(Required=false)]
                    public string BizTime { get; set; }

                    /// <summary>
                    /// <para>The market type in the invoice. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ALIYUN: Alibaba Cloud</description></item>
                    /// <item><description>MARKETPLACE: Alibaba Cloud Marketplace</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIYUN</para>
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// <para>The invoiceable amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123213</para>
                    /// </summary>
                    [NameInMap("CanInvoiceAmount")]
                    [Validation(Required=false)]
                    public long? CanInvoiceAmount { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-10-10 18:05:44</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-10-10 18:05:44</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <para>The ID of the invoice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1325321532</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The invoiced amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("InvoicedAmount")]
                    [Validation(Required=false)]
                    public long? InvoicedAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23453245</para>
                    /// </summary>
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// <para>The name of the object to be invoiced.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Refund of a voucher with denomination marked</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>If a refund is issued due to an order such as an unsubscription order or a configuration downgrade order, the refund amount is used to offset the amount of the invoice. The value is consistent with the value of the <b>OffsetCostAmount</b> parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("OffsetAcceptAmount")]
                    [Validation(Required=false)]
                    public long? OffsetAcceptAmount { get; set; }

                    /// <summary>
                    /// <para>The refund amount used to offset the amount of the invoice. If a refund is issued due to an order such as an unsubscription order or a configuration downgrade order, the refund amount is used to offset the amount of the invoice. The value is consistent with the value of the <b>OffsetAcceptAmount</b> parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("OffsetCostAmount")]
                    [Validation(Required=false)]
                    public long? OffsetCostAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the external object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12341</para>
                    /// </summary>
                    [NameInMap("OpId")]
                    [Validation(Required=false)]
                    public string OpId { get; set; }

                    /// <summary>
                    /// <para>The original amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-10000</para>
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public long? OriginalAmount { get; set; }

                    /// <summary>
                    /// <para>The ID of the external order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>124324213421</para>
                    /// </summary>
                    [NameInMap("OutBizId")]
                    [Validation(Required=false)]
                    public string OutBizId { get; set; }

                    /// <summary>
                    /// <para>The balance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-10000</para>
                    /// </summary>
                    [NameInMap("PresentAmount")]
                    [Validation(Required=false)]
                    public long? PresentAmount { get; set; }

                    /// <summary>
                    /// <para>The status of the invoiceable amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The type of orders that are queried. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: the orders in which the invoiceable amount is negative.</description></item>
                    /// <item><description>2: the orders in which the invoiceable amount is positive.</description></item>
                    /// <item><description>3: the orders in which the invoiceable amount is not 0.</description></item>
                    /// <item><description>4: the orders in which the amount that has been invoiced is greater than 0.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> By default, this parameter is left empty. If this parameter is left empty, all orders are queried.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2738543</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    /// <summary>
                    /// <para>The nickname of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// <para>The number of the page returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The invoiced amount that meets the query conditions. Unit: Cent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("TotalInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalInvoiceAmount { get; set; }

            /// <summary>
            /// <para>The invoiceable amount that meets the query conditions. Unit: Cent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("TotalUnAppliedInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalUnAppliedInvoiceAmount { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
