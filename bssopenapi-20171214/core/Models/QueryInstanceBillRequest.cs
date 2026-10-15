// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account that owns the resources. This account is the actual user of the resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle in YYYY-MM format. Data from the last 18 months is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when the <b>Granularity</b> parameter is set to DAILY. The value must be in the YYYY-MM-DD format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-03</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity at which to query bills. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MONTHLY: queries bills by month. The data is consistent with the bill details on the Billing Cycle tab of the Bills page in the User Center.</para>
        /// </description></item>
        /// <item><description><para>DAILY: queries bills by day. The data is consistent with the bill details on the By Day tab of the Bills page in the User Center.</para>
        /// </description></item>
        /// </list>
        /// <para>If you set this parameter to DAILY, you must also specify the <b>BillingDate</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Specifies whether to query data by billable item.</para>
        /// <list type="bullet">
        /// <item><description><para>false: The data is consistent with the bill details on the Instance tab of the Bills page in the User Center.</para>
        /// </description></item>
        /// <item><description><para>true: The data is consistent with the bill details on the Billable Item tab of the Bills page in the User Center.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsBillingItem")]
        [Validation(Required=false)]
        public bool? IsBillingItem { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out bills for which the pretax gross amount (<b>PretaxGrossAmount</b>) and pretax amount (<b>PretaxAmount</b>) are both 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false.</para>
        /// </description></item>
        /// <item><description><para>true.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the product. Required when the ProductCode parameter is set to the code of an Alibaba Cloud Marketplace product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Subscription: subscription.</para>
        /// </description></item>
        /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be used with the <b>ProductCode</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
