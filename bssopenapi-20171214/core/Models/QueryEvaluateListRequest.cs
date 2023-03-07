// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryEvaluateListRequest : TeaModel {
        /// <summary>
        /// The billing cycle.
        /// </summary>
        [NameInMap("BillCycle")]
        [Validation(Required=false)]
        public string BillCycle { get; set; }

        /// <summary>
        /// The market types in invoices.
        /// 
        /// >  By default, this parameter is left empty. If this parameter is left empty, all market types are queried.
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// The maximum amount to be queried.
        /// </summary>
        [NameInMap("EndAmount")]
        [Validation(Required=false)]
        public long? EndAmount { get; set; }

        /// <summary>
        /// The latest time when an order is paid Specify the time in the yyyy-mm-dd hh:mm:ss format.
        /// </summary>
        [NameInMap("EndBizTime")]
        [Validation(Required=false)]
        public string EndBizTime { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// </summary>
        [NameInMap("EndSearchTime")]
        [Validation(Required=false)]
        public string EndSearchTime { get; set; }

        /// <summary>
        /// The ID of the external order.
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the sort. Valid values:
        /// 
        /// *   1: Sort invoices by ID in descending order.
        /// *   2: Sort invoices by invoice type in descending order, and then sort invoices of the same type by ID in descending order.
        /// *   3: Sort invoices by invoice type in ascending order, and then sort invoices of the same type by ID in descending order.
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// The minimum amount to be queried.
        /// </summary>
        [NameInMap("StartAmount")]
        [Validation(Required=false)]
        public long? StartAmount { get; set; }

        /// <summary>
        /// The earliest time when an order is paid. Specify the time in the yyyy-mm-dd hh:mm:ss format.
        /// </summary>
        [NameInMap("StartBizTime")]
        [Validation(Required=false)]
        public string StartBizTime { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// </summary>
        [NameInMap("StartSearchTime")]
        [Validation(Required=false)]
        public string StartSearchTime { get; set; }

        /// <summary>
        /// The type of orders to be queried. Valid values:
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

    }

}
