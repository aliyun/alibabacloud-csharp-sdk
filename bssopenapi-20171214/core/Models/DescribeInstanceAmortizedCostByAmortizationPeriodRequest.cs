// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceAmortizedCostByAmortizationPeriodRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition for the account to which the resource belongs.
        /// The resource ownership account is the account that actually uses the resource.
        /// Maximum number of elements: 10.</para>
        /// </summary>
        [NameInMap("BillOwnerIdList")]
        [Validation(Required=false)]
        public List<string> BillOwnerIdList { get; set; }

        /// <summary>
        /// <para>The filter condition for the ID of the bill owner.
        /// This parameter specifies the ID of a RAM user. You can set this parameter to query the bills of a RAM user. If you do not set this parameter, the bills of the current account and all RAM users of the current account are queried.
        /// Maximum number of elements: 10.</para>
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
        /// <para>The filter condition for the billing cycle.
        /// Maximum number of elements: 10.</para>
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
        /// <para>The filter condition for the instance ID.
        /// You can query multiple instances. If you do not set this parameter, all instances are queried.
        /// Maximum number of elements: 10.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to return. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position from which to start reading the current call. The value of this parameter must be empty or the value of NextToken that is returned in the last call. Otherwise, an error is reported. If this parameter is empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The product code. To obtain the value of this parameter, call QueryProductList or DescribeResourcePackageProduct.</para>
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
