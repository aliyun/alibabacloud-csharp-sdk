// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member. If you specify this parameter, the bills of the member are queried. If you do not specify this parameter, the bills of the current account are queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing cycle. Specify the parameter in the YYYY-MM format.
        /// Only the latest 18 month billing cycle is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when the Granularity parameter is set to DAILY. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-02</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity at which bills are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MONTHLY: queries bills on a monthly basis. The data that you query is the same as the data searched by instances on the Billing Details tab of the Bill Details page in the User Center console.</description></item>
        /// <item><description>DAILY: queries bills on a daily basis. The data that you query is the same as the data searched by days on the Billing Details tab of the Bill Details page in the User Center console.</description></item>
        /// </list>
        /// <para>The BillingDate parameter is required if you set the Granularity parameter to DAILY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("InstanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        /// <summary>
        /// <para>Specifies whether to query data by billable items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The data that you query is the same as the data searched by instances on the Billing Details tab of the Bill Details page in the User Center console.</description></item>
        /// <item><description>true: The data that you query is the same as the data searched by billable items on the Billing Details tab of the Bill Details page in the User Center console.</description></item>
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
        /// <para>Specifies whether to filter bills if both the pretax gross amount and pretax amount are 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: does not filter bills.</description></item>
        /// <item><description>true: filters bills.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsHideZeroCharge")]
        [Validation(Required=false)]
        public bool? IsHideZeroCharge { get; set; }

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
        /// <para>The token that is used to indicate the position where the results for the current call start. The parameter must be left empty or set to the value of the NextToken parameter that is returned from the last call. Otherwise, an error is returned. If the parameter is left empty, data is queried from the first item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCm</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The code of the service. The code is the same as that in Cost Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("PipCode")]
        [Validation(Required=false)]
        public string PipCode { get; set; }

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
        /// <item><description>Subscription: the subscription billing method.</description></item>
        /// <item><description>PayAsYouGo: the pay-as-you-go billing method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
