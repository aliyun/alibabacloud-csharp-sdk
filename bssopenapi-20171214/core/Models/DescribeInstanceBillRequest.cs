// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceBillRequest : TeaModel {
        /// <summary>
        /// The ID of the member. If you specify this parameter, the bills of the member are queried. If you do not specify this parameter, the bills of the current account are queried by default.
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// The billing cycle. Specify the parameter in the YYYY-MM format.
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The billing date. This parameter is required only when the Granularity parameter is set to DAILY. Format: YYYY-MM-DD.
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// The granularity at which bills are queried. Valid values:
        /// 
        /// *   MONTHLY: queries bills on a monthly basis. The data that you query is the same as the data searched by instances on the Billing Details tab of the Bill Details page in the User Center console.
        /// *   DAILY: queries bills on a daily basis. The data that you query is the same as the data searched by days on the Billing Details tab of the Bill Details page in the User Center console.
        /// 
        /// The BillingDate parameter is required if you set the Granularity parameter to DAILY.
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// Specifies whether to query data by billable items. Valid values:
        /// 
        /// *   false: The data that you query is the same as the data searched by instances on the Billing Details tab of the Bill Details page in the User Center console.
        /// *   true: The data that you query is the same as the data searched by billable items on the Billing Details tab of the Bill Details page in the User Center console.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IsBillingItem")]
        [Validation(Required=false)]
        public bool? IsBillingItem { get; set; }

        /// <summary>
        /// Specifies whether to filter bills if both the pretax gross amount and pretax amount are 0. Valid values:
        /// 
        /// *   false: does not filter bills.
        /// *   true: filters bills.
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
        /// The token that is used to indicate the position where the results for the current call start. The parameter must be left empty or set to the value of the NextToken parameter that is returned from the last call. Otherwise, an error is returned. If the parameter is left empty, data is queried from the first item.
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
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: the subscription billing method.
        /// *   PayAsYouGo: the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
