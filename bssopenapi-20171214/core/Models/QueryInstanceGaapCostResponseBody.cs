// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInstanceGaapCostResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInstanceGaapCostResponseBodyData Data { get; set; }
        public class QueryInstanceGaapCostResponseBodyData : TeaModel {
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

                    [NameInMap("BillType")]
                    [Validation(Required=false)]
                    public string BillType { get; set; }

                    [NameInMap("BillingCycle")]
                    [Validation(Required=false)]
                    public string BillingCycle { get; set; }

                    [NameInMap("Currency")]
                    [Validation(Required=false)]
                    public string Currency { get; set; }

                    [NameInMap("DeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCashCoupons { get; set; }

                    [NameInMap("DeductedByCoupons")]
                    [Validation(Required=false)]
                    public string DeductedByCoupons { get; set; }

                    [NameInMap("DeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string DeductedByPrepaidCard { get; set; }

                    [NameInMap("GaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCashCoupons { get; set; }

                    [NameInMap("GaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string GaapDeductedByCoupons { get; set; }

                    [NameInMap("GaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string GaapDeductedByPrepaidCard { get; set; }

                    [NameInMap("GaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string GaapPaymentAmount { get; set; }

                    [NameInMap("GaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmount { get; set; }

                    [NameInMap("GaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string GaapPretaxAmountLocal { get; set; }

                    [NameInMap("GaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string GaapPretaxGrossAmount { get; set; }

                    [NameInMap("GaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string GaapPricingDiscount { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("MonthGaapDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCashCoupons { get; set; }

                    [NameInMap("MonthGaapDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByCoupons { get; set; }

                    [NameInMap("MonthGaapDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string MonthGaapDeductedByPrepaidCard { get; set; }

                    [NameInMap("MonthGaapPaymentAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPaymentAmount { get; set; }

                    [NameInMap("MonthGaapPretaxAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmount { get; set; }

                    [NameInMap("MonthGaapPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxAmountLocal { get; set; }

                    [NameInMap("MonthGaapPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string MonthGaapPretaxGrossAmount { get; set; }

                    [NameInMap("MonthGaapPricingDiscount")]
                    [Validation(Required=false)]
                    public string MonthGaapPricingDiscount { get; set; }

                    [NameInMap("OrderId")]
                    [Validation(Required=false)]
                    public string OrderId { get; set; }

                    [NameInMap("OrderType")]
                    [Validation(Required=false)]
                    public string OrderType { get; set; }

                    [NameInMap("OwnerID")]
                    [Validation(Required=false)]
                    public string OwnerID { get; set; }

                    [NameInMap("PayTime")]
                    [Validation(Required=false)]
                    public string PayTime { get; set; }

                    [NameInMap("PayerAccount")]
                    [Validation(Required=false)]
                    public string PayerAccount { get; set; }

                    [NameInMap("PaymentAmount")]
                    [Validation(Required=false)]
                    public string PaymentAmount { get; set; }

                    [NameInMap("PaymentCurrency")]
                    [Validation(Required=false)]
                    public string PaymentCurrency { get; set; }

                    [NameInMap("PretaxAmount")]
                    [Validation(Required=false)]
                    public string PretaxAmount { get; set; }

                    [NameInMap("PretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string PretaxAmountLocal { get; set; }

                    [NameInMap("PretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string PretaxGrossAmount { get; set; }

                    [NameInMap("PricingDiscount")]
                    [Validation(Required=false)]
                    public string PricingDiscount { get; set; }

                    [NameInMap("ProductCode")]
                    [Validation(Required=false)]
                    public string ProductCode { get; set; }

                    [NameInMap("ProductType")]
                    [Validation(Required=false)]
                    public string ProductType { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("ResourceGroup")]
                    [Validation(Required=false)]
                    public string ResourceGroup { get; set; }

                    [NameInMap("SubOrderId")]
                    [Validation(Required=false)]
                    public string SubOrderId { get; set; }

                    [NameInMap("SubscriptionType")]
                    [Validation(Required=false)]
                    public string SubscriptionType { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("UnallocatedDeductedByCashCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCashCoupons { get; set; }

                    [NameInMap("UnallocatedDeductedByCoupons")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByCoupons { get; set; }

                    [NameInMap("UnallocatedDeductedByPrepaidCard")]
                    [Validation(Required=false)]
                    public string UnallocatedDeductedByPrepaidCard { get; set; }

                    [NameInMap("UnallocatedPaymentAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPaymentAmount { get; set; }

                    [NameInMap("UnallocatedPretaxAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmount { get; set; }

                    [NameInMap("UnallocatedPretaxAmountLocal")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxAmountLocal { get; set; }

                    [NameInMap("UnallocatedPretaxGrossAmount")]
                    [Validation(Required=false)]
                    public string UnallocatedPretaxGrossAmount { get; set; }

                    [NameInMap("UnallocatedPricingDiscount")]
                    [Validation(Required=false)]
                    public string UnallocatedPricingDiscount { get; set; }

                    [NameInMap("UsageEndDate")]
                    [Validation(Required=false)]
                    public string UsageEndDate { get; set; }

                    [NameInMap("UsageStartDate")]
                    [Validation(Required=false)]
                    public string UsageStartDate { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
