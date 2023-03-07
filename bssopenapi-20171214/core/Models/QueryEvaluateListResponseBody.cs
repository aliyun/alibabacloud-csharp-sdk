// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryEvaluateListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEvaluateListResponseBodyData Data { get; set; }
        public class QueryEvaluateListResponseBodyData : TeaModel {
            /// <summary>
            /// The data returned.
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
                    /// The billing cycle.
                    /// </summary>
                    [NameInMap("BillCycle")]
                    [Validation(Required=false)]
                    public string BillCycle { get; set; }

                    /// <summary>
                    /// The ID of the bill.
                    /// </summary>
                    [NameInMap("BillId")]
                    [Validation(Required=false)]
                    public long? BillId { get; set; }

                    /// <summary>
                    /// The time.
                    /// </summary>
                    [NameInMap("BizTime")]
                    [Validation(Required=false)]
                    public string BizTime { get; set; }

                    /// <summary>
                    /// The market type in the invoice. Valid values:
                    /// 
                    /// *   ALIYUN: Alibaba Cloud
                    /// *   MARKETPLACE: Alibaba Cloud Marketplace
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// The invoiceable amount.
                    /// </summary>
                    [NameInMap("CanInvoiceAmount")]
                    [Validation(Required=false)]
                    public long? CanInvoiceAmount { get; set; }

                    /// <summary>
                    /// The creation time.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The modification time.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// The ID of the invoice.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The invoiced amount.
                    /// </summary>
                    [NameInMap("InvoicedAmount")]
                    [Validation(Required=false)]
                    public long? InvoicedAmount { get; set; }

                    /// <summary>
                    /// The ID of the item.
                    /// </summary>
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// The name of the object to be invoiced.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// If a refund is issued due to an order such as an unsubscription order or a configuration downgrade order, the refund amount is used to offset the amount of the invoice. The value is consistent with the value of the **OffsetCostAmount** parameter.
                    /// </summary>
                    [NameInMap("OffsetAcceptAmount")]
                    [Validation(Required=false)]
                    public long? OffsetAcceptAmount { get; set; }

                    /// <summary>
                    /// The refund amount used to offset the amount of the invoice. If a refund is issued due to an order such as an unsubscription order or a configuration downgrade order, the refund amount is used to offset the amount of the invoice. The value is consistent with the value of the **OffsetAcceptAmount** parameter.
                    /// </summary>
                    [NameInMap("OffsetCostAmount")]
                    [Validation(Required=false)]
                    public long? OffsetCostAmount { get; set; }

                    /// <summary>
                    /// The ID of the external object.
                    /// </summary>
                    [NameInMap("OpId")]
                    [Validation(Required=false)]
                    public string OpId { get; set; }

                    /// <summary>
                    /// The original amount.
                    /// </summary>
                    [NameInMap("OriginalAmount")]
                    [Validation(Required=false)]
                    public long? OriginalAmount { get; set; }

                    /// <summary>
                    /// The ID of the external order.
                    /// </summary>
                    [NameInMap("OutBizId")]
                    [Validation(Required=false)]
                    public string OutBizId { get; set; }

                    /// <summary>
                    /// The balance.
                    /// </summary>
                    [NameInMap("PresentAmount")]
                    [Validation(Required=false)]
                    public long? PresentAmount { get; set; }

                    /// <summary>
                    /// The status of the invoiceable amount.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The type of orders that are queried. Valid values:
                    /// 
                    /// *   1: the orders in which the invoiceable amount is negative.
                    /// *   2: the orders in which the invoiceable amount is positive.
                    /// *   3: the orders in which the invoiceable amount is not 0.
                    /// *   4: the orders in which the amount that has been invoiced is greater than 0.
                    /// 
                    /// >  By default, this parameter is left empty. If this parameter is left empty, all orders are queried.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// The ID of the user.
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    /// <summary>
                    /// The nickname of the user.
                    /// </summary>
                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

            /// <summary>
            /// The ID of the host.
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The invoiced amount that meets the query conditions. Unit: Cent.
            /// </summary>
            [NameInMap("TotalInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalInvoiceAmount { get; set; }

            /// <summary>
            /// The invoiceable amount that meets the query conditions. Unit: Cent.
            /// </summary>
            [NameInMap("TotalUnAppliedInvoiceAmount")]
            [Validation(Required=false)]
            public long? TotalUnAppliedInvoiceAmount { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
