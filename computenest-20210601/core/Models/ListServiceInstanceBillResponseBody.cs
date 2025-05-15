// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing information of the backup schedule.</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public List<ListServiceInstanceBillResponseBodyItem> Item { get; set; }
        public class ListServiceInstanceBillResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>The billing cycle. Format: YYYY-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The billing date. This parameter is required only if the <b>Granularity</b> parameter is set to DAILY. Format: YYYY-MM-DD.</para>
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
            /// <para>The currency unit.</para>
            /// <list type="bullet">
            /// <item><description>China site: <b>CNY</b>.</description></item>
            /// <item><description>International site: <b>USD</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The amount deducted with resource plans.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DeductedByResourcePackage")]
            [Validation(Required=false)]
            public string DeductedByResourcePackage { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
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
            /// <para>The unit price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.12</para>
            /// </summary>
            [NameInMap("ListPrice")]
            [Validation(Required=false)]
            public string ListPrice { get; set; }

            /// <summary>
            /// <para>The unit of the unit price.</para>
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
            /// <para>The code of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The specific service resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("ProductDetail")]
            [Validation(Required=false)]
            public string ProductDetail { get; set; }

            /// <summary>
            /// <para>The name of the cloud service or the name of the service-linked role with which the cloud service is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The billing cycle in which the bill is split.</para>
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
            /// <item><description>Subscription: the subscription billing method.</description></item>
            /// <item><description>PayAsYouGo: the pay-as-you-go billing method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("SubscriptionType")]
            [Validation(Required=false)]
            public string SubscriptionType { get; set; }

            /// <summary>
            /// <para>The amount of resource usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;EmbeddingTokens\&quot;: 314}</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

            /// <summary>
            /// <para>The unit of usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("UsageUnit")]
            [Validation(Required=false)]
            public string UsageUnit { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
