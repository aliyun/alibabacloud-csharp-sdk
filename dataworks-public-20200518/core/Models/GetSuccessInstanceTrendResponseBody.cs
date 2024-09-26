// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetSuccessInstanceTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The trend of statistics on the instance status in different time periods.</para>
        /// </summary>
        [NameInMap("InstanceStatusTrend")]
        [Validation(Required=false)]
        public GetSuccessInstanceTrendResponseBodyInstanceStatusTrend InstanceStatusTrend { get; set; }
        public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrend : TeaModel {
            /// <summary>
            /// <para>The average trend.</para>
            /// </summary>
            [NameInMap("AvgTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend> AvgTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendAvgTrend : TeaModel {
                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The point in time. Valid values: 00:00 to 23:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// <para>The trend on the current day.</para>
            /// </summary>
            [NameInMap("TodayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend> TodayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendTodayTrend : TeaModel {
                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The point in time. Valid values: 00:00 to 23:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00</para>
                /// </summary>
                [NameInMap("TimePoint")]
                [Validation(Required=false)]
                public string TimePoint { get; set; }

            }

            /// <summary>
            /// <para>The trend on the previous day.</para>
            /// </summary>
            [NameInMap("YesterdayTrend")]
            [Validation(Required=false)]
            public List<GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend> YesterdayTrend { get; set; }
            public class GetSuccessInstanceTrendResponseBodyInstanceStatusTrendYesterdayTrend : TeaModel {
                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The point in time. Valid values: 00:00 to 23:00.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795279527ab****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
