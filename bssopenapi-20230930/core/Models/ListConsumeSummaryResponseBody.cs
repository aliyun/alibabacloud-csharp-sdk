// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListConsumeSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The consumption summary records returned in this request. An empty array is returned if no matching records are found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListConsumeSummaryResponseBodyData> Data { get; set; }
        public class ListConsumeSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The amount after coupon deduction, which is the result of deducting coupons from the amount after discount. When all related fields are available, it equals AmountAfterPromotionDeduction - CouponAmount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("AmountAfterCouponDeduction")]
            [Validation(Required=false)]
            public string AmountAfterCouponDeduction { get; set; }

            /// <summary>
            /// <para>The amount after discount, which represents the amount after applying discounts such as website promotions and contract discounts. Coupons are not deducted at this point. When all related fields are available, it equals AmountAfterSavingPlanDeduction - PromotionAmount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("AmountAfterPromotionDeduction")]
            [Validation(Required=false)]
            public string AmountAfterPromotionDeduction { get; set; }

            /// <summary>
            /// <para>The amount after savings plan deduction, which is the remaining amount after deducting the list price portion covered by the savings plan. When all related fields are available, it equals ListPrice - SavingPlanDeductListPrice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AmountAfterSavingPlanDeduction")]
            [Validation(Required=false)]
            public string AmountAfterSavingPlanDeduction { get; set; }

            /// <summary>
            /// <para>The billing date, which is the consumption date of the cloud product, in the format of yyyy-MM-dd. It has a value only when summarized by day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01</para>
            /// </summary>
            [NameInMap("BillingDate")]
            [Validation(Required=false)]
            public string BillingDate { get; set; }

            /// <summary>
            /// <para>The billing formula, which describes how the total list price is calculated. It should be understood in conjunction with the list price on the Alibaba Cloud website, usage, duration, and other billing factors.</para>
            /// 
            /// <b>Example:</b>
            /// <para>List price × Usage × Duration</para>
            /// </summary>
            [NameInMap("BillingFormula")]
            [Validation(Required=false)]
            public string BillingFormula { get; set; }

            /// <summary>
            /// <para>The billing item code, which identifies the billing item to which the fee belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_billing_item</para>
            /// </summary>
            [NameInMap("BillingItemCode")]
            [Validation(Required=false)]
            public string BillingItemCode { get; set; }

            /// <summary>
            /// <para>The billing item name, which is the display name of the billing item to which the fee belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample billing item</para>
            /// </summary>
            [NameInMap("BillingItemName")]
            [Validation(Required=false)]
            public string BillingItemName { get; set; }

            /// <summary>
            /// <para>The billing month, which represents the billing month to which the fee belongs, in the format of yyyy-MM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10</para>
            /// </summary>
            [NameInMap("BillingMonth")]
            [Validation(Required=false)]
            public string BillingMonth { get; set; }

            /// <summary>
            /// <para>The usage that is ultimately used for fee calculation. If usage deduction is applied, this value is the usage before deduction minus the usage deducted by resource plans, free quotas, and other deductions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BillingQuantity")]
            [Validation(Required=false)]
            public string BillingQuantity { get; set; }

            /// <summary>
            /// <para>The usage unit, used in conjunction with BillingQuantity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GB</para>
            /// </summary>
            [NameInMap("BillingQuantityUnit")]
            [Validation(Required=false)]
            public string BillingQuantityUnit { get; set; }

            /// <summary>
            /// <para>The duration, which represents the purchase or usage duration involved in billing. It has a value only when the billing formula involves time. If duration deduction is applied, this value is the duration before deduction minus the deducted duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeDuration")]
            [Validation(Required=false)]
            public string ChargeDuration { get; set; }

            /// <summary>
            /// <para>The duration unit, used in conjunction with ChargeDuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hour</para>
            /// </summary>
            [NameInMap("ChargeDurationUnit")]
            [Validation(Required=false)]
            public string ChargeDurationUnit { get; set; }

            /// <summary>
            /// <para>The billing method. The display name such as prepaid or pay-as-you-go is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code, used to uniquely identify a specific commodity under a cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name, which is the display name of a specific commodity under a cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample commodity</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The transaction type, which describes the transaction behavior that generated the bill, such as new purchase, renewal, upgrade, downgrade, unsubscription, pay-as-you-go, or adjustment. The display name is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("ConsumeType")]
            [Validation(Required=false)]
            public string ConsumeType { get; set; }

            /// <summary>
            /// <para>The coupon deduction amount, which is the fee covered by coupons. This amount cannot be used for invoicing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("CouponAmount")]
            [Validation(Required=false)]
            public string CouponAmount { get; set; }

            /// <summary>
            /// <para>The currency, which represents the currency used for the list price and amounts in this record. For example, CNY indicates Chinese Yuan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The summary record identifier, used as an opaque string. It can be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-summary-key</para>
            /// </summary>
            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            /// <summary>
            /// <para>The instance ID at the billing granularity, which represents the instance identity used to aggregate fees when a cloud product generates a bill. The billing granularity may differ from the resource management granularity, so it may be different from ResourceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-example001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource name, which is the name set by the user for the cloud resource. Whether it is returned depends on whether the product supports querying and whether the resource information is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-resource</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The specification, used to describe the specification information corresponding to the billing item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.spec</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }

            /// <summary>
            /// <para>The line item type, which describes the nature of the fee, such as subscription prepaid fee, subscription postpaid fee, subscription unsubscription fee, pay-as-you-go fee for cloud resources, adjustment fee, or rounding fee. The display name is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pay-as-you-go</para>
            /// </summary>
            [NameInMap("LineItemType")]
            [Validation(Required=false)]
            public string LineItemType { get; set; }

            /// <summary>
            /// <para>The total list price, which represents the total amount calculated based on the list price for the purchased cloud resource configuration. Savings plan deductions, discounts, and coupons are not deducted yet. Note that ListPrice in this API is the total amount. For the list unit price, see ListUnitPrice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ListPrice")]
            [Validation(Required=false)]
            public string ListPrice { get; set; }

            /// <summary>
            /// <para>The price unit, which is the unit corresponding to the list unit price ListUnitPrice, such as CNY/GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY/GB/Hour</para>
            /// </summary>
            [NameInMap("ListPriceUnit")]
            [Validation(Required=false)]
            public string ListPriceUnit { get; set; }

            /// <summary>
            /// <para>The list price on the Alibaba Cloud website, which is the list unit price of the commodity. It differs in meaning from the total list price ListPrice. In scenarios such as tiered pricing, you cannot recalculate the fee by simply multiplying a single unit price by the total usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ListUnitPrice")]
            [Validation(Required=false)]
            public string ListUnitPrice { get; set; }

            /// <summary>
            /// <para>The product code, used to uniquely identify a specific cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name, which is the display name of the cloud product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Elastic Compute Service</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The discount amount, which represents the total discounts such as website promotions and contract discounts. Coupon deductions are separately recorded in CouponAmount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PromotionAmount")]
            [Validation(Required=false)]
            public string PromotionAmount { get; set; }

            /// <summary>
            /// <para>The configuration, used to describe the configuration options corresponding to the billing item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample configuration</para>
            /// </summary>
            [NameInMap("PurchaseConfiguration")]
            [Validation(Required=false)]
            public string PurchaseConfiguration { get; set; }

            /// <summary>
            /// <para>The region code, which represents the code of the logical region where the cloud resource is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>The region, which represents the display name of the region where the cloud resource is located. For products sold by region, it usually corresponds to the region selected when placing the order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The payable amount, which is the fee to be paid after savings plan deductions, discounts, and coupon deductions. In the new version of bills, this corresponds to the payable amount (tax-inclusive) definition. For fee verification, refer to the actual return value of this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("RequireAmount")]
            [Validation(Required=false)]
            public string RequireAmount { get; set; }

            /// <summary>
            /// <para>The resource ID, used to uniquely identify a cloud resource in the corresponding cloud product or service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-example001</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource ownership account ID, which is the ID of the account that actually uses the cloud resource instance. It may be different from the purchasing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountId")]
            [Validation(Required=false)]
            public string ResourceOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The resource ownership account, which is the name of the account that actually uses the cloud resource instance. It may be different from the purchasing account.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:owner@example.com">owner@example.com</a></para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountName")]
            [Validation(Required=false)]
            public string ResourceOwnerAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the resource purchasing account, which is the ID of the account that placed the order to purchase the cloud resource instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123456</para>
            /// </summary>
            [NameInMap("ResourcePurchaseAccountId")]
            [Validation(Required=false)]
            public string ResourcePurchaseAccountId { get; set; }

            /// <summary>
            /// <para>The resource purchasing account, which is the name of the account that placed the order to purchase the cloud resource instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:buyer@example.com">buyer@example.com</a></para>
            /// </summary>
            [NameInMap("ResourcePurchaseAccountName")]
            [Validation(Required=false)]
            public string ResourcePurchaseAccountName { get; set; }

            /// <summary>
            /// <para>The savings plan deduction amount, which is the committed spend of the savings plan consumed to complete this deduction. It is not the list price amount of the deducted resource and cannot replace SavingPlanDeductListPrice for deduction from the total list price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("SavingPlanDeductAmount")]
            [Validation(Required=false)]
            public string SavingPlanDeductAmount { get; set; }

            /// <summary>
            /// <para>The savings plan deduction list price, which is the amount calculated based on the list price for the pay-as-you-go resource fees deducted by the savings plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SavingPlanDeductListPrice")]
            [Validation(Required=false)]
            public string SavingPlanDeductListPrice { get; set; }

            /// <summary>
            /// <para>The service entity, which is the name of the company that actually provides the product or service. Different products may correspond to different companies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample service entity</para>
            /// </summary>
            [NameInMap("ServiceEntity")]
            [Validation(Required=false)]
            public string ServiceEntity { get; set; }

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
        /// <para>The query token for the next page. If a non-empty value is returned, pass it as is to the next request and keep other query conditions unchanged. If it is not returned or is empty, pagination ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-token</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
