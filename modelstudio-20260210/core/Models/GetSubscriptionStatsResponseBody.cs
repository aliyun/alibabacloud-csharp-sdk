// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetSubscriptionStatsResponseBody : TeaModel {
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
        public GetSubscriptionStatsResponseBodyData Data { get; set; }
        public class GetSubscriptionStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of seat information, grouped by specType.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetSubscriptionStatsResponseBodyDataItems> Items { get; set; }
            public class GetSubscriptionStatsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The number of assigned seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AssignedSeats")]
                [Validation(Required=false)]
                public long? AssignedSeats { get; set; }

                /// <summary>
                /// <para>The total credits quota for the seat.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SeatCredits")]
                [Validation(Required=false)]
                public double? SeatCredits { get; set; }

                /// <summary>
                /// <para>The refresh time of the current cycle, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1781422734</para>
                /// </summary>
                [NameInMap("SeatRefreshTime")]
                [Validation(Required=false)]
                public long? SeatRefreshTime { get; set; }

                /// <summary>
                /// <para>The remaining credits for the current cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SeatRemainingCredits")]
                [Validation(Required=false)]
                public double? SeatRemainingCredits { get; set; }

                /// <summary>
                /// <para>The seat type (specType). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: Standard seat.</description></item>
                /// <item><description>pro: Pro seat.</description></item>
                /// <item><description>max: Premium seat.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("SeatType")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// <para>The total number of seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalSeats")]
                [Validation(Required=false)]
                public long? TotalSeats { get; set; }

            }

            /// <summary>
            /// <para>The subscription end time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1781422734</para>
            /// </summary>
            [NameInMap("SubscriptionEndTime")]
            [Validation(Required=false)]
            public long? SubscriptionEndTime { get; set; }

            /// <summary>
            /// <para>The subscription start time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1781422733</para>
            /// </summary>
            [NameInMap("SubscriptionStartTime")]
            [Validation(Required=false)]
            public long? SubscriptionStartTime { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
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
