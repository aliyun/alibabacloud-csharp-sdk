// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceBillResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of billing information for the service instance.</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public List<ListServiceInstanceBillResponseBodyItem> Item { get; set; }
        public class ListServiceInstanceBillResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>The billing cycle of the computing resources for the instance. This parameter is supported only for pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Day</b>: daily billing.</para>
            /// </description></item>
            /// <item><description><para><b>Month</b>: monthly billing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The billing date in YYYY-MM-DD format. This parameter is returned only when <b>Granularity</b> is set to DAILY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-23</para>
            /// </summary>
            [NameInMap("BillingDate")]
            [Validation(Required=false)]
            public string BillingDate { get; set; }

            /// <summary>
            /// <para>The billable item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bandwidth</para>
            /// </summary>
            [NameInMap("BillingItem")]
            [Validation(Required=false)]
            public string BillingItem { get; set; }

            /// <summary>
            /// <para>The code of the billable item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("BillingItemCode")]
            [Validation(Required=false)]
            public string BillingItemCode { get; set; }

            /// <summary>
            /// <para>The currency. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CNY: Chinese Yuan.</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar.</para>
            /// </description></item>
            /// <item><description><para>JPY: Japanese Yen.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RMB</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The amount deducted by a resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeductedByResourcePackage")]
            [Validation(Required=false)]
            public string DeductedByResourcePackage { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1z88pb48487907u</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>The discount amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InvoiceDiscount")]
            [Validation(Required=false)]
            public string InvoiceDiscount { get; set; }

            /// <summary>
            /// <para>The list price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("ListPrice")]
            [Validation(Required=false)]
            public string ListPrice { get; set; }

            /// <summary>
            /// <para>The unit of the list price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY/GB</para>
            /// </summary>
            [NameInMap("ListPriceUnit")]
            [Validation(Required=false)]
            public string ListPriceUnit { get; set; }

            /// <summary>
            /// <para>The pretax amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PretaxAmount")]
            [Validation(Required=false)]
            public string PretaxAmount { get; set; }

            /// <summary>
            /// <para>The pretax gross amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PretaxGrossAmount")]
            [Validation(Required=false)]
            public string PretaxGrossAmount { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("ProductDetail")]
            [Validation(Required=false)]
            public string ProductDetail { get; set; }

            /// <summary>
            /// <para>The name of the product to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The month of the split bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07</para>
            /// </summary>
            [NameInMap("SplitBillingCycle")]
            [Validation(Required=false)]
            public string SplitBillingCycle { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
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

            /// <summary>
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;EmbeddingTokens\&quot;: 314}</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

            /// <summary>
            /// <para>The unit of the usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("UsageUnit")]
            [Validation(Required=false)]
            public string UsageUnit { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbAx7BkQzyYC+ONO+WudHGKEdB0uWSY7AGnM3qCgm/Ynge7zU6NWdbj0Tegyajyqyc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2849EE73-AFFA-5AFD-9575-12FA886451DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
