// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceBillRequest : TeaModel {
        /// <summary>
        /// The ID of the member. If you specify a value for this parameter, you can query the bills of the specified member. If you leave this parameter empty, the bills of the current account are queried by default.
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// The billing cycle. Format: YYYY-MM.
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The billing date. This parameter is required only if the **Granularity** parameter is set to DAILY. Format: YYYY-MM-DD.
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// The granularity at which bills are queried. Valid values:
        /// 
        /// *   MONTHLY: queries bills by month. The data queried is consistent with the data that is displayed for the specified billing cycle on the Billing Details tab of the Bill Details page in User Center.
        /// *   DAILY: queries bills by day. The data queried is consistent with the data that is displayed for the specified day on the Billing Details tab of the Bill Details page in User Center.
        /// 
        /// You must set the **BillingDate** parameter before you can set the Granularity parameter to DAILY.
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// Specifies whether to query data by billable item. Valid values:
        /// 
        /// *   false: does not query data by billable item. The data queried is consistent with the data that is displayed for the specified instance on the Billing Details tab of the Bill Details page in User Center.
        /// *   true: queries data by billable item. The data queried is consistent with the data that is displayed for the specified billable item on the Billing Details tab of the Bill Details page in User Center.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IsBillingItem")]
        [Validation(Required=false)]
        public bool? IsBillingItem { get; set; }

        /// <summary>
        /// Specifies whether to filter out a bill whose pretax gross amount and pretax amount are 0. Default value: false.******** Valid values:
        /// 
        /// *   false: does not filter the bill.
        /// *   true: filters the bill.
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. Maximum value: 300.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The code of the service.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The type of the service. This parameter is required if the ProductCode parameter is set to the service code of Alibaba Cloud Marketplace.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: the subscription billing method
        /// *   PayAsYouGo: the pay-as-you-go billing method
        /// 
        /// **
        /// 
        /// ****This parameter must be used together with the **ProductCode** parameter.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
