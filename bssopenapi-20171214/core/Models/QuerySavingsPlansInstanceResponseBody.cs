// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySavingsPlansInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansInstanceResponseBodyData Data { get; set; }
        public class QuerySavingsPlansInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of instance information.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansInstanceResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansInstanceResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The allocation status.</para>
                /// <list type="bullet">
                /// <item><description><para>unallocated: Not allocated.</para>
                /// </description></item>
                /// <item><description><para>allocated: Allocating.</para>
                /// </description></item>
                /// <item><description><para>beAllocated: Allocated to this account.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>unallocated</para>
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>savingplan_common_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The currency. Valid values: CNY: Chinese Yuan. USD: US Dollar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>For a savings plan with a monthly cycle, this is the commitment for the current cycle. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("CurrentPoolValue")]
                [Validation(Required=false)]
                public string CurrentPoolValue { get; set; }

                /// <summary>
                /// <para>The purchased duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1:Year</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                /// <summary>
                /// <para>The deduction cycle.
                /// HOUR: hourly
                /// DAY: daily
                /// ONCE: one-time (the total amount decreases over time)</para>
                /// 
                /// <b>Example:</b>
                /// <para>HOUR</para>
                /// </summary>
                [NameInMap("DeductCycleType")]
                [Validation(Required=false)]
                public string DeductCycleType { get; set; }

                /// <summary>
                /// <para>The expiration time of the instance. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The end timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1663135741039</para>
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// <para>For a compute-optimized savings plan, this parameter indicates the corresponding instance family or instance family package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6</para>
                /// </summary>
                [NameInMap("InstanceFamily")]
                [Validation(Required=false)]
                public string InstanceFamily { get; set; }

                /// <summary>
                /// <para>The ID of the savings plan instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spn-xxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The total deduction amount in the previous cycle. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("LastBillTotalUsage")]
                [Validation(Required=false)]
                public string LastBillTotalUsage { get; set; }

                /// <summary>
                /// <para>The utilization in the previous cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("LastBillUtilization")]
                [Validation(Required=false)]
                public string LastBillUtilization { get; set; }

                /// <summary>
                /// <para>The payment type.</para>
                /// <list type="bullet">
                /// <item><description><para>total: All Upfront</para>
                /// </description></item>
                /// <item><description><para>half: Partial Upfront</para>
                /// </description></item>
                /// <item><description><para>zero: No Upfront</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>total</para>
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// <para>The commitment. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.00</para>
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public string PoolValue { get; set; }

                /// <summary>
                /// <para>The upfront payment. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8760.00</para>
                /// </summary>
                [NameInMap("PrepayFee")]
                [Validation(Required=false)]
                public string PrepayFee { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou-na62-a01</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>For a flexible savings plan with a monthly or daily commitment, this is the remaining amount in the current cycle. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("RestPoolValue")]
                [Validation(Required=false)]
                public string RestPoolValue { get; set; }

                /// <summary>
                /// <para>The type of the savings plan.</para>
                /// <list type="bullet">
                /// <item><description><para>unversal: general-purpose</para>
                /// </description></item>
                /// <item><description><para>ecs: compute-optimized</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// <para>The effective time of the instance. The time is in the yyyy-MM-dd HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The start timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1663135741039</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <para>The current status.</para>
                /// <list type="bullet">
                /// <item><description><para>NORMAL: The instance is active.</para>
                /// </description></item>
                /// <item><description><para>LIMIT: The instance is suspended due to an overdue payment.</para>
                /// </description></item>
                /// <item><description><para>RELEASE: The instance is released.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of tag information.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<QuerySavingsPlansInstanceResponseBodyDataItemsTags> Tags { get; set; }
                public class QuerySavingsPlansInstanceResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标签1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>标签1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The total savings. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20.00</para>
                /// </summary>
                [NameInMap("TotalSave")]
                [Validation(Required=false)]
                public string TotalSave { get; set; }

                /// <summary>
                /// <para>The total utilization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Utilization")]
                [Validation(Required=false)]
                public string Utilization { get; set; }

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
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
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
