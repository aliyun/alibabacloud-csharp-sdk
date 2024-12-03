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
        /// <para>The return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySavingsPlansInstanceResponseBodyData Data { get; set; }
        public class QuerySavingsPlansInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details about the instances.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QuerySavingsPlansInstanceResponseBodyDataItems> Items { get; set; }
            public class QuerySavingsPlansInstanceResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The allocation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>unallocated</description></item>
                /// <item><description>allocated</description></item>
                /// <item><description>beAllocated</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>unallocated</para>
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>savingplan_common_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The currency. Valid values: CNY and USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("CurrentPoolValue")]
                [Validation(Required=false)]
                public string CurrentPoolValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1:Year</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public string Cycle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HOUR</para>
                /// </summary>
                [NameInMap("DeductCycleType")]
                [Validation(Required=false)]
                public string DeductCycleType { get; set; }

                /// <summary>
                /// <para>The time when the instance expires. The time is in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1663135741039</para>
                /// </summary>
                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public long? EndTimestamp { get; set; }

                /// <summary>
                /// <para>The instance family information. For an instance of the Elastic Compute Service (ECS) compute type, the value indicates the ECS instance family or the ECS instance family package.</para>
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
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("LastBillTotalUsage")]
                [Validation(Required=false)]
                public string LastBillTotalUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("LastBillUtilization")]
                [Validation(Required=false)]
                public string LastBillUtilization { get; set; }

                /// <summary>
                /// <para>The payment type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>total: All Upfront</description></item>
                /// <item><description>half: Partial Upfront</description></item>
                /// <item><description>zero: No Upfront</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>total</para>
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// <para>The commitment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.00</para>
                /// </summary>
                [NameInMap("PoolValue")]
                [Validation(Required=false)]
                public string PoolValue { get; set; }

                /// <summary>
                /// <para>The prepaid amount.</para>
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
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("RestPoolValue")]
                [Validation(Required=false)]
                public string RestPoolValue { get; set; }

                /// <summary>
                /// <para>The type of the savings plan. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>universal: general-purpose</description></item>
                /// <item><description>ecs: ECS compute</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("SavingsType")]
                [Validation(Required=false)]
                public string SavingsType { get; set; }

                /// <summary>
                /// <para>The time when the instance takes effect. The time is in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1663135741039</para>
                /// </summary>
                [NameInMap("StartTimestamp")]
                [Validation(Required=false)]
                public long? StartTimestamp { get; set; }

                /// <summary>
                /// <para>The status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: normal</description></item>
                /// <item><description>LIMIT: stopped due to overdue payment</description></item>
                /// <item><description>RELEASE: released</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The details about the tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<QuerySavingsPlansInstanceResponseBodyDataItemsTags> Tags { get; set; }
                public class QuerySavingsPlansInstanceResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the tag.</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The total amount that is saved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20.00</para>
                /// </summary>
                [NameInMap("TotalSave")]
                [Validation(Required=false)]
                public string TotalSave { get; set; }

                /// <summary>
                /// <para>The total usage.</para>
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
        /// <para>The message returned.</para>
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
