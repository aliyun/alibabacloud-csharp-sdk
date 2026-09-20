// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListSuccessInstanceAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The trend data of successfully completed instance counts at different hours on the business date.</para>
        /// </summary>
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public ListSuccessInstanceAmountResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrend : TeaModel {
            /// <summary>
            /// <para>The historical average trend.</para>
            /// </summary>
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                /// <summary>
                /// <para>The number of successfully completed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time point. Valid values: hours on the hour from 00:00 to 23:00, such as 00:00, 01:00, and 02:00.</para>
                /// <para>Format: <c>HH:mm</c>. Example: <c>01:00</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// <para>The trend for the current business date.</para>
            /// </summary>
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                /// <summary>
                /// <para>The number of successfully completed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time point. Valid values: hours on the hour from 00:00 to 23:00, such as 00:00, 01:00, and 02:00.</para>
                /// <para>Format: <c>HH:mm</c>. Example: <c>01:00</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// <para>The trend for the day before the business date.</para>
            /// </summary>
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class ListSuccessInstanceAmountResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                /// <summary>
                /// <para>The number of successfully completed instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time point. Valid values: hours on the hour from 00:00 to 23:00, such as 00:00, 01:00, and 02:00.</para>
                /// <para>Format: <c>HH:mm</c>. Example: <c>01:00</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795279527ab****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
