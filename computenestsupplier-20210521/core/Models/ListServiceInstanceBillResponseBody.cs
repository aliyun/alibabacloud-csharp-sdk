// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the item.</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public List<ListServiceInstanceBillResponseBodyItem> Item { get; set; }
        public class ListServiceInstanceBillResponseBodyItem : TeaModel {
            /// <summary>
            /// <para>The billing cycle. The format is YYYY-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public string BillingCycle { get; set; }

            /// <summary>
            /// <para>The billing date. The format is YYYY-MM-DD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-05</para>
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
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The deduction by a resource plan.</para>
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
            /// <para>rm-wz9k051l23j3o3xa9</para>
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
            /// <para>oss</para>
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
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The ID of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-bc5d6ac7022647d3a3bd</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The month of the split bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06</para>
            /// </summary>
            [NameInMap("SplitBillingCycle")]
            [Validation(Required=false)]
            public string SplitBillingCycle { get; set; }

            /// <summary>
            /// <para>The billing method:</para>
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
            /// <para>The resource usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B68C6D1-0C22-53F7-997C-F95D109C31AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
