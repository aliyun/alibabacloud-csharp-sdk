// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member. If you specify a value for this parameter, you can query the bills of the specified member. If you leave this parameter empty, the bills of the current account are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle. Format: YYYY-MM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only if the <b>Granularity</b> parameter is set to DAILY. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-03</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity at which bills are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTHLY: queries bills by month. The data queried is consistent with the data that is displayed for the specified billing cycle on the Billing Details tab of the Bill Details page in User Center.</description></item>
        /// <item><description>DAILY: queries bills by day. The data queried is consistent with the data that is displayed for the specified day on the Billing Details tab of the Bill Details page in User Center.</description></item>
        /// </list>
        /// <para>You must set the <b>BillingDate</b> parameter before you can set the Granularity parameter to DAILY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Specifies whether to query data by billable item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: does not query data by billable item. The data queried is consistent with the data that is displayed for the specified instance on the Billing Details tab of the Bill Details page in User Center.</description></item>
        /// <item><description>true: queries data by billable item. The data queried is consistent with the data that is displayed for the specified billable item on the Billing Details tab of the Bill Details page in User Center.</description></item>
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
        /// <para>Specifies whether to filter out a bill whose pretax gross amount and pretax amount are 0. Default value: false.******** Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: does not filter the bill.</description></item>
        /// <item><description>true: filters the bill.</description></item>
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
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The code of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The type of the service. This parameter is required if the ProductCode parameter is set to the service code of Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: the subscription billing method</description></item>
        /// <item><description>PayAsYouGo: the pay-as-you-go billing method</description></item>
        /// </list>
        /// <para>**</para>
        /// <para>****This parameter must be used together with the <b>ProductCode</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
