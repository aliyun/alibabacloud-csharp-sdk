// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle, in the YYYY-MM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>Specifies whether to display local currency information in bills. The parameter will be discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDisplayLocalCurrency")]
        [Validation(Required=false)]
        public bool? IsDisplayLocalCurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out a bill whose pretax gross amount is 0. By default, a bill whose pretax gross amount is 0 is not filtered out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: filters out a bill whose pretax gross amount is 0.</description></item>
        /// <item><description>false: does not filter out a bill whose pretax gross amount is 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>The type of the service.</para>
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
        /// <item><description>Subscription</description></item>
        /// <item><description>PayAsYouGo</description></item>
        /// </list>
        /// <para>This parameter must be used together with the ProductCode parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// <para>The type of the bill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SubscriptionOrder</description></item>
        /// <item><description>PayAsYouGoBill</description></item>
        /// <item><description>Refund</description></item>
        /// <item><description>Adjustment</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SubscriptionOrder</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
