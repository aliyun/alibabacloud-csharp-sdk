// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetSubscriptionSeatDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSubscriptionSeatDetailsResponseBodyData Data { get; set; }
        public class GetSubscriptionSeatDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetSubscriptionSeatDetailsResponseBodyDataItems> Items { get; set; }
            public class GetSubscriptionSeatDetailsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The email address of the member account.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@email.com">test@email.com</a></para>
                /// </summary>
                [NameInMap("AccountEmail")]
                [Validation(Required=false)]
                public string AccountEmail { get; set; }

                /// <summary>
                /// <para>The ID of the attached member account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc_123456789</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The name of the member account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExampleName</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The assignment status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ASSIGNED</description></item>
                /// <item><description>UNASSIGNED.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ASSIGNED</para>
                /// </summary>
                [NameInMap("AssignedStatus")]
                [Validation(Required=false)]
                public string AssignedStatus { get; set; }

                /// <summary>
                /// <para>The expiration time of the seat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1781422733</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The currently active equity instances. For the TokenPlan product, this list contains only one active equity instance.</para>
                /// </summary>
                [NameInMap("EquityList")]
                [Validation(Required=false)]
                public List<GetSubscriptionSeatDetailsResponseBodyDataItemsEquityList> EquityList { get; set; }
                public class GetSubscriptionSeatDetailsResponseBodyDataItemsEquityList : TeaModel {
                    /// <summary>
                    /// <para>The end time of the current cycle, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1755273600</para>
                    /// </summary>
                    [NameInMap("CycleEndTime")]
                    [Validation(Required=false)]
                    public long? CycleEndTime { get; set; }

                    /// <summary>
                    /// <para>The equity code (subscription code). This does not need to be consumed in the CREDITS scenario.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("CycleInstanceId")]
                    [Validation(Required=false)]
                    public string CycleInstanceId { get; set; }

                    /// <summary>
                    /// <para>The start time of the current cycle, in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1775232000</para>
                    /// </summary>
                    [NameInMap("CycleStartTime")]
                    [Validation(Required=false)]
                    public long? CycleStartTime { get; set; }

                    /// <summary>
                    /// <para>The remaining quota of the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40.00000000</para>
                    /// </summary>
                    [NameInMap("CycleSurplusValue")]
                    [Validation(Required=false)]
                    public double? CycleSurplusValue { get; set; }

                    /// <summary>
                    /// <para>The total quota of the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.00000000</para>
                    /// </summary>
                    [NameInMap("CycleTotalValue")]
                    [Validation(Required=false)]
                    public double? CycleTotalValue { get; set; }

                    /// <summary>
                    /// <para>The sequential version of the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CycleVersion")]
                    [Validation(Required=false)]
                    public long? CycleVersion { get; set; }

                    /// <summary>
                    /// <para>The equity type, such as CREDITS, SPN, or resource plan.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREDITS</para>
                    /// </summary>
                    [NameInMap("EquityType")]
                    [Validation(Required=false)]
                    public string EquityType { get; set; }

                }

                /// <summary>
                /// <para>The instance code of the seat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subs-1234567</para>
                /// </summary>
                [NameInMap("InstanceCode")]
                [Validation(Required=false)]
                public string InstanceCode { get; set; }

                /// <summary>
                /// <para>The seat ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>seat_123456</para>
                /// </summary>
                [NameInMap("SeatId")]
                [Validation(Required=false)]
                public string SeatId { get; set; }

                /// <summary>
                /// <para>The seat type. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>standard</description></item>
                /// <item><description>pro</description></item>
                /// <item><description>max.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// <para>The start time of the seat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1781422733</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The seat status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATING: being created.</description></item>
                /// <item><description>NORMAL: active.</description></item>
                /// <item><description>LIMIT: restricted due to overdue payment.</description></item>
                /// <item><description>RELEASE: released upon expiration.</description></item>
                /// <item><description>STOP: stopped upon expiration.</description></item>
                /// <item><description>REFUNDED: refunded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value is greater than 0 and does not exceed the maximum value of the Integer data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of seats.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
