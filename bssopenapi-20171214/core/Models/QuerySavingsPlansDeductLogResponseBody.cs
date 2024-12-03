// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansDeductLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDeductLogResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDeductLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deduction details.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDeductLogResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDeductLogResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The billable item for which the fee is deducted.</para>
                /// </summary>
                [NameInMap("BillModule")]
                [Validation(Required=false)]
                public string BillModule { get; set; }

                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                [NameInMap("BillingOfficialPrice")]
                [Validation(Required=false)]
                public string BillingOfficialPrice { get; set; }

                /// <summary>
                /// <para>The service for which the fee is deducted.</para>
                /// </summary>
                [NameInMap("DeductCommodity")]
                [Validation(Required=false)]
                public string DeductCommodity { get; set; }

                /// <summary>
                /// <para>The deducted amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.52</para>
                /// </summary>
                [NameInMap("DeductFee")]
                [Validation(Required=false)]
                public string DeductFee { get; set; }

                /// <summary>
                /// <para>The ID of the instance for which the fee is deducted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-XXXXXXXXX</para>
                /// </summary>
                [NameInMap("DeductInstanceId")]
                [Validation(Required=false)]
                public string DeductInstanceId { get; set; }

                /// <summary>
                /// <para>The deduction rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("DeductRate")]
                [Validation(Required=false)]
                public string DeductRate { get; set; }

                [NameInMap("DeductedOfficialPrice")]
                [Validation(Required=false)]
                public string DeductedOfficialPrice { get; set; }

                /// <summary>
                /// <para>The discount used for the current deduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.069</para>
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// <para>The end of the billing cycle for which the fee is deducted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01 01:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The ID of the savings plan instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spn-xxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1906589291020438</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The type of the savings plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>universal: general-purpose</description></item>
                /// <item><description>ecs: ECS compute</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// <para>The beginning of the billing cycle for which the fee is deducted. The time is in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1906589291020438</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61293E7A-3406-4447-8620-EC88B0AA66AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
