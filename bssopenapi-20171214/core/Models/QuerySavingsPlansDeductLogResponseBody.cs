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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansDeductLogResponseBodyData Data { get; set; }
        public class QuerySavingsPlansDeductLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of deduction details.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansDeductLogResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansDeductLogResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The deducted billable item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云服务器配置</para>
                /// </summary>
                [NameInMap("BillModule")]
                [Validation(Required=false)]
                public string BillModule { get; set; }

                /// <summary>
                /// <para>The billing cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202312</para>
                /// </summary>
                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                /// <summary>
                /// <para>The list price of the deducted bill, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>375.35</para>
                /// </summary>
                [NameInMap("BillingOfficialPrice")]
                [Validation(Required=false)]
                public string BillingOfficialPrice { get; set; }

                /// <summary>
                /// <para>The deducted service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云服务器ECS-按量付费</para>
                /// </summary>
                [NameInMap("DeductCommodity")]
                [Validation(Required=false)]
                public string DeductCommodity { get; set; }

                /// <summary>
                /// <para>The deducted fee, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.52</para>
                /// </summary>
                [NameInMap("DeductFee")]
                [Validation(Required=false)]
                public string DeductFee { get; set; }

                /// <summary>
                /// <para>The ID of the deducted cloud service instance.</para>
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

                /// <summary>
                /// <para>The list price of the deducted amount, in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>375.37</para>
                /// </summary>
                [NameInMap("DeductedOfficialPrice")]
                [Validation(Required=false)]
                public string DeductedOfficialPrice { get; set; }

                /// <summary>
                /// <para>The discount that is used for the deduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.069</para>
                /// </summary>
                [NameInMap("DiscountRate")]
                [Validation(Required=false)]
                public string DiscountRate { get; set; }

                /// <summary>
                /// <para>The end time.</para>
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

                /// <summary>
                /// <para>The instance type of the deducted instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g7.xlarge</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The instance family of the deducted instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g7</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1906589291020438</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The region of the deducted instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai-eu13-a01</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The type of the savings plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>universal: general-purpose</para>
                /// </description></item>
                /// <item><description><para>ecs: compute-optimized</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
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
            /// <para>The number of entries per page.</para>
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请校验入参正确性</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61293E7A-3406-4447-8620-EC88B0AA66AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
