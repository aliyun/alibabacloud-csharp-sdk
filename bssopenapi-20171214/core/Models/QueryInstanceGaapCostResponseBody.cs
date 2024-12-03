// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceGaapCostResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceGaapCostResponseBodyData Data { get; set; }
        public class QueryInstanceGaapCostResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("Modules")]
            [Validation(Required=false)]
            public QueryInstanceGaapCostResponseBodyDataModules Modules { get; set; }
            public class QueryInstanceGaapCostResponseBodyDataModules : TeaModel {
                [NameInMap("Module")]
                [Validation(Required=false)]
                public List<QueryInstanceGaapCostResponseBodyDataModulesModule> Module { get; set; }
                public class QueryInstanceGaapCostResponseBodyDataModulesModule : TeaModel {
                    [NameInMap("AccountingUnit")]
                    [Validation(Required=false)]
                    public string AccountingUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SubscriptionOrder</para>
                    /// </summary>
                    [NameInMap("BillType")]
                    [Validation(Required=false)]
                    public string BillType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-03</para>
                    /// </summary>
                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string DeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string GaapDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string GaapPaymentAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string GaapPricingDiscount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OSSBAG-cn-0xl0xxxxxx</para>
                    /// </summary>
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.75</para>
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MonthGaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MonthGaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPaymentAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MonthGaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.99</para>
                    /// </summary>
                    [NameInMap("MonthGaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.99</para>
                    /// </summary>
                    [NameInMap("MonthGaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0,.25</para>
                    /// </summary>
                    [NameInMap("MonthGaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string MonthGaapPricingDiscount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>213123213123</para>
                    /// </summary>
                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>New</para>
                    /// </summary>
                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123213123123</para>
                    /// </summary>
                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2018-06-15 15:59:57</para>
                    /// </summary>
                    [NameInMap("PayTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>23534534</para>
                    /// </summary>
                    [NameInMap("PayerAccount")]
                    [Validation(Required=false)]
                    public string PayerAccount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public string PaymentAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CNY</para>
                    /// </summary>
                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PricingDiscount")]
                    [Validation(Required=false)]
                    public string PricingDiscount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rds</para>
                    /// </summary>
                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12434345</para>
                    /// </summary>
                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PayAsYouGo</para>
                    /// </summary>
                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tag</para>
                    /// </summary>
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCashCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCoupons { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByPrepaidCard { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedPaymentAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPaymentAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedPretaxAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmountLocal { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxGrossAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UnallocatedPricingDiscount")]
                    [Validation(Required=false)]
                    public string UnallocatedPricingDiscount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2019-05-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("UsageEndDate")]
                    [Validation(Required=false)]
                    public string UsageEndDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2019-04-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("UsageStartDate")]
                    [Validation(Required=false)]
                    public string UsageStartDate { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCBB1BB9-22F1-4177-867B-7A75D665B488</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
