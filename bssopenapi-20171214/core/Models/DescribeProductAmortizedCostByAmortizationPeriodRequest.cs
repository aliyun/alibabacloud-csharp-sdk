// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeProductAmortizedCostByAmortizationPeriodRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of resource owners. The resource owner is the account that uses the resources.
        /// You can specify a maximum of 10 IDs.</para>
        /// </summary>
        [NameInMap("BillOwnerIdList")]
        [Validation(Required=false)]
        public List<string> BillOwnerIdList { get; set; }

        /// <summary>
        /// <para>The IDs of billable accounts. This parameter is used to filter bills by the RAM user who pays for the resources. If you specify this parameter, you can query the bills of the specified RAM user. If you leave this parameter empty, the bills of the current account and all its RAM users are queried.
        /// You can specify a maximum of 10 IDs.</para>
        /// </summary>
        [NameInMap("BillUserIdList")]
        [Validation(Required=false)]
        public List<string> BillUserIdList { get; set; }

        /// <summary>
        /// <para>The amortization month.
        /// Format: YYYY-MM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The filter for billing cycle months.
        /// You can specify a maximum of 10 elements.</para>
        /// </summary>
        [NameInMap("ConsumePeriodFilter")]
        [Validation(Required=false)]
        public List<string> ConsumePeriodFilter { get; set; }

        /// <summary>
        /// <para>The code of the cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123#</para>
        /// </summary>
        [NameInMap("CostUnitCode")]
        [Validation(Required=false)]
        public string CostUnitCode { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position to start the query. If you leave this parameter empty, the query starts from the beginning. Set this parameter to the value of NextToken that is returned in the last response to query the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The product code.
        /// For more information about how to obtain this parameter, see QueryProductList and DescribeResourcePackageProduct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The details of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public string ProductDetail { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Subscription: subscription.</para>
        /// </description></item>
        /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
