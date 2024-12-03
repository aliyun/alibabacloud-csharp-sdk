// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyData Data { get; set; }
        public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>185766xxxx</para>
            /// </summary>
            [NameInMap("AccountID")]
            [Validation(Required=false)]
            public string AccountID { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyDataItems> Items { get; set; }
            public class DescribeInstanceDeductAmortizedCostByAmortizationPeriodResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10</para>
                /// </summary>
                [NameInMap("AmortizationPeriod")]
                [Validation(Required=false)]
                public string AmortizationPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-10</para>
                /// </summary>
                [NameInMap("AmortizationPeriodDay")]
                [Validation(Required=false)]
                public string AmortizationPeriodDay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>amortized</para>
                /// </summary>
                [NameInMap("AmortizationStatus")]
                [Validation(Required=false)]
                public string AmortizationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("BillAccountID")]
                [Validation(Required=false)]
                public long? BillAccountID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("BillAccountName")]
                [Validation(Required=false)]
                public string BillAccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("BillOwnerID")]
                [Validation(Required=false)]
                public long? BillOwnerID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
                /// </summary>
                [NameInMap("BillOwnerName")]
                [Validation(Required=false)]
                public string BillOwnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>trusteeship</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10</para>
                /// </summary>
                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public string ConsumePeriod { get; set; }

                [NameInMap("CostUnit")]
                [Validation(Required=false)]
                public string CostUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("CostUnitCode")]
                [Validation(Required=false)]
                public string CostUnitCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? CurrentAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurrentAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? CurrentAmortizationRoundDownDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeductedByCoupons")]
                [Validation(Required=false)]
                public double? DeductedByCoupons { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CPU:12</para>
                /// </summary>
                [NameInMap("InstanceConfig")]
                [Validation(Required=false)]
                public string InstanceConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-kjhdskjgshfdlkjfdh</para>
                /// </summary>
                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34.xx.x.x</para>
                /// </summary>
                [NameInMap("InternetIP")]
                [Validation(Required=false)]
                public string InternetIP { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.xx.xx.xx</para>
                /// </summary>
                [NameInMap("IntranetIP")]
                [Validation(Required=false)]
                public string IntranetIP { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InvoiceDiscount")]
                [Validation(Required=false)]
                public double? InvoiceDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PretaxAmount")]
                [Validation(Required=false)]
                public double? PretaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PretaxGrossAmount")]
                [Validation(Required=false)]
                public double? PretaxGrossAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductDetail")]
                [Validation(Required=false)]
                public string ProductDetail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("ProductDetailCode")]
                [Validation(Required=false)]
                public string ProductDetailCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spn-001</para>
                /// </summary>
                [NameInMap("ReferFrInstanceID")]
                [Validation(Required=false)]
                public string ReferFrInstanceID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>185xxxxx489</para>
                /// </summary>
                [NameInMap("ReferFrOwnerID")]
                [Validation(Required=false)]
                public string ReferFrOwnerID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>savingplan_common_public_cn</para>
                /// </summary>
                [NameInMap("ReferFrProductDetailCode")]
                [Validation(Required=false)]
                public string ReferFrProductDetailCode { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RoundDownDiscount")]
                [Validation(Required=false)]
                public double? RoundDownDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:12@test.com">12@test.com</a></para>
                /// </summary>
                [NameInMap("SplitAccountName")]
                [Validation(Required=false)]
                public string SplitAccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-28bycvyb4</para>
                /// </summary>
                [NameInMap("SplitItemID")]
                [Validation(Required=false)]
                public string SplitItemID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iZ28bycvyb4Z</para>
                /// </summary>
                [NameInMap("SplitItemName")]
                [Validation(Required=false)]
                public string SplitItemName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SplitProductDetail")]
                [Validation(Required=false)]
                public string SplitProductDetail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PayAsYouGo</para>
                /// </summary>
                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>key:testKey value:testValue; key:testKey1 value:testValues1</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAmortizationDeductedByCoupons")]
                [Validation(Required=false)]
                public double? UnusedAmortizationDeductedByCoupons { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAmortizationInvoiceDiscount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationInvoiceDiscount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAmortizationPretaxAmount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationPretaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAmortizationPretaxGrossAmount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationPretaxGrossAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UnusedAmortizationRoundDownDiscount")]
                [Validation(Required=false)]
                public double? UnusedAmortizationRoundDownDiscount { get; set; }

                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CAESEgoQCg4KCmdtdF9jcmVhdGUEARgBIkgKCQBwhGmPcAEAAAo7AzYAAAAxTDgwMDcxMjg3ZDJhNmM3ZDguTDgwMDAwMDAwMDAwMzE1MTIuTDgwMDcyZDMyZTJkYzg3N2U</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EAE08A27-386C-579E-966D-8853EC3C5D0E</para>
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
