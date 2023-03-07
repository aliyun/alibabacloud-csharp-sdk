// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeProductAmortizedCostByAmortizationPeriodRequest : TeaModel {
        /// <summary>
        /// The instance ID that is used to filter bills. You can specify multiple instance IDs to query bills of multiple instances. If you leave this parameter empty, the bills of all instances are queried by default. You can specify a maximum of 10 instance IDs.
        /// </summary>
        [NameInMap("BillOwnerIdList")]
        [Validation(Required=false)]
        public List<string> BillOwnerIdList { get; set; }

        /// <summary>
        /// The ID of the member that needs to settle the bill. The member ID is used to filter bills. If you specify a value for this parameter, you can query the bills of the specified member. If you leave this parameter empty, the bills of the current account and all members of the current account are queried by default. You can specify a maximum of 10 IDs.
        /// </summary>
        [NameInMap("BillUserIdList")]
        [Validation(Required=false)]
        public List<string> BillUserIdList { get; set; }

        /// <summary>
        /// The allocation month. Format: YYYY-MM.
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The billing cycle that is used to filter bills. You can specify a maximum of 10 billing cycles.
        /// </summary>
        [NameInMap("ConsumePeriodFilter")]
        [Validation(Required=false)]
        public List<string> ConsumePeriodFilter { get; set; }

        /// <summary>
        /// The code of the cost center.
        /// </summary>
        [NameInMap("CostUnitCode")]
        [Validation(Required=false)]
        public string CostUnitCode { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Default value: 20. Maximum value: 300.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The position from which the query starts. The parameter must be left empty or set to the value of the NextToken parameter returned from the last call. Otherwise, an error is returned. If this parameter is left empty, data is queried from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The code of the service. You can obtain the value of this parameter by calling the QueryProductList operation or the DescribeResourcePackageProduct operation.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The specific service resource.
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public string ProductDetail { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: the subscription billing method
        /// *   PayAsYouGo: the pay-as-you-go billing method
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
