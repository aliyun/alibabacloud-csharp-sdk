// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySettleBillRequest : TeaModel {
        /// <summary>
        /// The ID of the member. If you specify a value for this parameter, you can query the bills of the specified member. If you leave this parameter empty, the bills of the current account are queried by default.
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// The billing cycle, in the YYYY-MM format.
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// Specifies whether to display local currency information in bills.
        /// </summary>
        [NameInMap("IsDisplayLocalCurrency")]
        [Validation(Required=false)]
        public bool? IsDisplayLocalCurrency { get; set; }

        /// <summary>
        /// Specifies whether to filter out a bill whose pretax gross amount is 0. By default, a bill whose pretax gross amount is 0 is not filtered out.
        /// 
        /// *   true: filters out a bill whose pretax gross amount is 0.
        /// *   false: does not filter out a bill whose pretax gross amount is 0.
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Default value: 20. Maximum value: 300.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The starting position of the query. If this parameter is left empty, the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The code of the service.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The type of the service.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The ID of the bill or order.
        /// </summary>
        [NameInMap("RecordID")]
        [Validation(Required=false)]
        public string RecordID { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: the subscription billing method
        /// *   PayAsYouGo: the pay-as-you-go billing method
        /// 
        /// **
        /// 
        /// ****This parameter must be used together with the ProductCode parameter.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// The type of the bill. Valid values:
        /// 
        /// *   SubscriptionOrder: subscription order
        /// *   PayAsYouGoBill: pay-as-you-go bill
        /// *   Refund: refund
        /// *   Adjustment: reconciliation
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
