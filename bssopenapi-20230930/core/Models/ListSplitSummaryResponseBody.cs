// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListSplitSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of split bill summary records returned in this request. This array may be empty if no matching records are found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSplitSummaryResponseBodyData> Data { get; set; }
        public class ListSplitSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The amount after coupon deduction, which equals AmountAfterPromotionDeduction minus CouponAmount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("AmountAfterCouponDeduction")]
            [Validation(Required=false)]
            public string AmountAfterCouponDeduction { get; set; }

            /// <summary>
            /// <para>The amount after discount, which is the amount after official website discounts and contract discounts are applied, but before coupon deductions. When the savings plan deduction data is complete, this equals ListPrice minus SavingPlanDeductListPrice minus PromotionAmount. When the savings plan deduction list price is unavailable, this is calculated as ListPrice minus PromotionAmount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("AmountAfterPromotionDeduction")]
            [Validation(Required=false)]
            public string AmountAfterPromotionDeduction { get; set; }

            /// <summary>
            /// <para>The amount after savings plan deduction, which equals ListPrice minus SavingPlanDeductListPrice. This may be empty when there is no savings plan deduction data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AmountAfterSavingPlanDeduction")]
            [Validation(Required=false)]
            public string AmountAfterSavingPlanDeduction { get; set; }

            /// <summary>
            /// <para>The billing date, which is the date when the user consumed the cloud service. The format is yyyy-MM-dd. This has a value only when the data is summarized by day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01</para>
            /// </summary>
            [NameInMap("BillingDate")]
            [Validation(Required=false)]
            public string BillingDate { get; set; }

            /// <summary>
            /// <para>The billing item code, which is the billing item to which the cloud resource expense belongs. Whether this field has a value depends on the split bill records and summary data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_billing_item</para>
            /// </summary>
            [NameInMap("BillingItemCode")]
            [Validation(Required=false)]
            public string BillingItemCode { get; set; }

            /// <summary>
            /// <para>The billing item name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample billing item</para>
            /// </summary>
            [NameInMap("BillingItemName")]
            [Validation(Required=false)]
            public string BillingItemName { get; set; }

            /// <summary>
            /// <para>The billing month, which is the month to which the expense belongs. The format is yyyy-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09</para>
            /// </summary>
            [NameInMap("BillingMonth")]
            [Validation(Required=false)]
            public string BillingMonth { get; set; }

            /// <summary>
            /// <para>The usage, which is the total usage that is ultimately billed. This must be understood in combination with the product, billing item, and unit. Do not directly add up the values if the units or billing rules are different.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BillingQuantity")]
            [Validation(Required=false)]
            public string BillingQuantity { get; set; }

            /// <summary>
            /// <para>The unit of usage, used in conjunction with BillingQuantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("BillingQuantityUnit")]
            [Validation(Required=false)]
            public string BillingQuantityUnit { get; set; }

            /// <summary>
            /// <para>The total duration of purchasing or using cloud products. This field is used when the corresponding billing method includes a duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("ChargeDuration")]
            [Validation(Required=false)]
            public string ChargeDuration { get; set; }

            /// <summary>
            /// <para>The unit of duration, used in conjunction with ChargeDuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("ChargeDurationUnit")]
            [Validation(Required=false)]
            public string ChargeDurationUnit { get; set; }

            /// <summary>
            /// <para>The display name of the billing method, returned based on the request language, such as Subscription or Pay-as-you-go. Use Subscription or PayAsYouGo for filtering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code, which is the unique identifier of a specific commodity under a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample commodity</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The display name of the transaction type, which identifies the transaction corresponding to the bill, such as new purchase, renewal, upgrade, downgrade, unsubscription, pay-as-you-go, and adjustment. Do not use the display name as the ConsumeType filter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("ConsumeType")]
            [Validation(Required=false)]
            public string ConsumeType { get; set; }

            /// <summary>
            /// <para>The cost category, which indicates the cost category and category value to which the record belongs. It is returned as a string. The specific content is subject to the bill record and can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;business&quot;:&quot;commerce&quot;}</para>
            /// </summary>
            [NameInMap("CostCategories")]
            [Validation(Required=false)]
            public string CostCategories { get; set; }

            /// <summary>
            /// <para>The coupon deduction amount. This amount cannot be used for invoicing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CouponAmount")]
            [Validation(Required=false)]
            public string CouponAmount { get; set; }

            /// <summary>
            /// <para>The currency corresponding to the amounts and prices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The name of the financial unit. A financial unit is a unit used to group or classify expenses and must be maintained by the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>engineering</para>
            /// </summary>
            [NameInMap("FinanceUnitName")]
            [Validation(Required=false)]
            public string FinanceUnitName { get; set; }

            /// <summary>
            /// <para>The identifier of the summary record, used as an opaque string. This can be empty. The identifier may change when summary dimensions such as resource groups and tags change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-split-summary-key</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <para>The instance ID at the billing granularity, which is the dimension for expense statistics and summary when a cloud service generates a bill. This may be different from the resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou-example</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource name, which is the custom name given to the cloud resource by the user. Whether this field has a value depends on whether the product and resource information can be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-resource</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The specification, which describes the specification of the resource or billing item associated with this record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.spec</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }

            /// <summary>
            /// <para>The public IP address. This is returned only when the product supports it and the relevant resource information can be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.2.10</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address. This is returned only when the product supports it and the relevant resource information can be obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.10</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The display name of the expense type, which identifies the nature of the expense generated by the bill, such as subscription prepaid expense, subscription unsubscription expense, pay-as-you-go expense for cloud resources, adjustment expense, and round-down expense. Do not use the display name as the LineItemType filter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go expense for cloud resources</para>
            /// </summary>
            [NameInMap("LineItemType")]
            [Validation(Required=false)]
            public string LineItemType { get; set; }

            /// <summary>
            /// <para>The total list price, which is the total list price of the selected configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ListPrice")]
            [Validation(Required=false)]
            public string ListPrice { get; set; }

            /// <summary>
            /// <para>The price unit, used in conjunction with ListUnitPrice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY/GB</para>
            /// </summary>
            [NameInMap("ListPriceUnit")]
            [Validation(Required=false)]
            public string ListPriceUnit { get; set; }

            /// <summary>
            /// <para>The list price on the official website, which is the list unit price of the commodity. Whether this field has a value depends on the split bill and summary data. Do not multiply the total usage by a unit price to recalculate all bills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListUnitPrice")]
            [Validation(Required=false)]
            public string ListUnitPrice { get; set; }

            /// <summary>
            /// <para>The product code, which is the unique identifier of a specific cloud service on Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Object Storage Service (OSS)</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The discount amount, which is the total discount amount on the bill, including official website discounts and contract discounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PromotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

            /// <summary>
            /// <para>The purchase configuration of the billing item, which describes the configurations related to the billing item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample configuration</para>
            /// </summary>
            [NameInMap("PurchaseConfiguration")]
            [Validation(Required=false)]
            public string PurchaseConfiguration { get; set; }

            /// <summary>
            /// <para>The region code, which is the logical region code where the cloud resource is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>The region name, which indicates the region selected when the order was placed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The payable amount (tax-inclusive), which is the actual amount the user needs to pay after various discounts, savings plan deductions, and coupon deductions are applied. When all amount fields are complete, this equals ListPrice minus SavingPlanDeductListPrice minus PromotionAmount minus CouponAmount. Use this field for expense verification. If other amount fields are missing, do not treat empty values as zero to calculate the payable amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85</para>
            /// </summary>
            [NameInMap("RequireAmount")]
            [Validation(Required=false)]
            public string RequireAmount { get; set; }

            /// <summary>
            /// <para>The resource group, which is the group where cloud resources are located as configured by the user in the Resource Management console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The resource ID, which is the identifier used to uniquely identify a resource in a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bucket</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The ID of the resource ownership account, which is the ID of the account that actually uses the resource and may differ from the purchasing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountId")]
            [Validation(Required=false)]
            public string ResourceOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The name of the resource ownership account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:owner@example.com">owner@example.com</a></para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountName")]
            [Validation(Required=false)]
            public string ResourceOwnerAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the resource purchaser account, which is the ID of the account that purchases the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("ResourcePurchaseAccountId")]
            [Validation(Required=false)]
            public string ResourcePurchaseAccountId { get; set; }

            /// <summary>
            /// <para>The name of the resource purchaser account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:buyer@example.com">buyer@example.com</a></para>
            /// </summary>
            [NameInMap("ResourcePurchaseAccountName")]
            [Validation(Required=false)]
            public string ResourcePurchaseAccountName { get; set; }

            /// <summary>
            /// <para>The resource tag, which is the custom tag added by the user to Alibaba Cloud resources. It is returned as a string and can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env prod</para>
            /// </summary>
            [NameInMap("ResourceTag")]
            [Validation(Required=false)]
            public string ResourceTag { get; set; }

            /// <summary>
            /// <para>The savings plan deduction amount, which is the committed amount consumed by the savings plan itself. This has a different meaning from SavingPlanDeductListPrice, cannot be used interchangeably, and should not be deducted from the payable amount again.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SavingPlanDeductAmount")]
            [Validation(Required=false)]
            public string SavingPlanDeductAmount { get; set; }

            /// <summary>
            /// <para>The total list price deducted by the savings plan, which is the total list price of the pay-as-you-go cloud resources deducted when a savings plan is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SavingPlanDeductListPrice")]
            [Validation(Required=false)]
            public string SavingPlanDeductListPrice { get; set; }

            /// <summary>
            /// <para>The service entity, which is the name of the company that provides the product or service. Alibaba Cloud sells a wide range of products, and some products may be provided by different companies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample service entity</para>
            /// </summary>
            [NameInMap("ServiceEntity")]
            [Validation(Required=false)]
            public string ServiceEntity { get; set; }

            /// <summary>
            /// <para>The split item ID, which is the code corresponding to the specific split granularity of the bill. For example, when OSS is split by bucket, this is the bucket code. This field may be empty for records that are not split.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bucket</para>
            /// </summary>
            [NameInMap("SplitItemId")]
            [Validation(Required=false)]
            public string SplitItemId { get; set; }

            /// <summary>
            /// <para>The split item name, which is the name corresponding to the specific split granularity of the bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-bucket</para>
            /// </summary>
            [NameInMap("SplitItemName")]
            [Validation(Required=false)]
            public string SplitItemName { get; set; }

            /// <summary>
            /// <para>The zone. The display name may be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou) Zone I</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records per page used in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for querying the next page. If it is not empty, use it as the NextToken for the next request. If it is empty or not returned, the pagination ends. Even if the number of returned records is less than MaxResults or the current page is empty, you must continue to query as long as the token is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to locate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
