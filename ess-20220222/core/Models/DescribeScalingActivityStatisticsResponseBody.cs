// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivityStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A8F44B4D-BAB4-5176-8705-5984xxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingActivityErrorCodeStatistics")]
        [Validation(Required=false)]
        public DescribeScalingActivityStatisticsResponseBodyScalingActivityErrorCodeStatistics ScalingActivityErrorCodeStatistics { get; set; }
        public class DescribeScalingActivityStatisticsResponseBodyScalingActivityErrorCodeStatistics : TeaModel {
            [NameInMap("ErrorStatistic")]
            [Validation(Required=false)]
            public List<DescribeScalingActivityStatisticsResponseBodyScalingActivityErrorCodeStatisticsErrorStatistic> ErrorStatistic { get; set; }
            public class DescribeScalingActivityStatisticsResponseBodyScalingActivityErrorCodeStatisticsErrorStatistic : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>QuotaExceeded.PrivateIpAddress</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025121623</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        [NameInMap("ScalingActivityStatusStatistics")]
        [Validation(Required=false)]
        public DescribeScalingActivityStatisticsResponseBodyScalingActivityStatusStatistics ScalingActivityStatusStatistics { get; set; }
        public class DescribeScalingActivityStatisticsResponseBodyScalingActivityStatusStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeScalingActivityStatisticsResponseBodyScalingActivityStatusStatisticsStatistic> Statistic { get; set; }
            public class DescribeScalingActivityStatisticsResponseBodyScalingActivityStatusStatisticsStatistic : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailedActivityCount")]
                [Validation(Required=false)]
                public int? FailedActivityCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SuccessActivityCount")]
                [Validation(Required=false)]
                public int? SuccessActivityCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025121623</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("WarningActivityCount")]
                [Validation(Required=false)]
                public int? WarningActivityCount { get; set; }

            }

        }

    }

}
