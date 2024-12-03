// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceAmortizedCostByAmortizationPeriodRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member to which the bill belongs. The member ID is used to filter bills. If you specify a value for this parameter, you can query the bills of the specified member. If you leave this parameter empty, the bills of the current account and all members of the current account are queried. You can specify a maximum of 10 IDs.</para>
        /// </summary>
        [NameInMap("BillOwnerIdList")]
        [Validation(Required=false)]
        public List<string> BillOwnerIdList { get; set; }

        /// <summary>
        /// <para>The ID of the member that needs to settle the bill. The member ID is used to filter bills. If you specify a value for this parameter, you can query the bills of the specified member account. If you leave this parameter empty, the bills of the current account and all members of the current account are queried by default. You can specify a maximum of 10 IDs.</para>
        /// </summary>
        [NameInMap("BillUserIdList")]
        [Validation(Required=false)]
        public List<string> BillUserIdList { get; set; }

        /// <summary>
        /// <para>The allocation month. Format: YYYY-MM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing cycle that is used to filter bills. You can specify a maximum of 10 billing cycles.</para>
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
        /// <para>The instance ID that is used to filter bills. You can specify multiple instance IDs to query bills of multiple instances. If you leave this parameter empty, the bills of all instances are queried by default. You can specify a maximum of 10 instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

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
        /// <para>The position from which the query starts. The parameter must be left empty or set to the value of the NextToken parameter returned from the last call. Otherwise, an error is returned. If this parameter is left empty, data is queried from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The code of the service. You can obtain the value of this parameter by calling the QueryProductList operation or the DescribeResourcePackageProduct operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The specific service resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductDetail")]
        [Validation(Required=false)]
        public string ProductDetail { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: the subscription billing method</description></item>
        /// <item><description>PayAsYouGo: the pay-as-you-go billing method</description></item>
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
