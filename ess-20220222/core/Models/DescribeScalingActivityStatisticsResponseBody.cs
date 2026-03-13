// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivityStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
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
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

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
                [NameInMap("FailedActivityCount")]
                [Validation(Required=false)]
                public int? FailedActivityCount { get; set; }

                [NameInMap("SuccessActivityCount")]
                [Validation(Required=false)]
                public int? SuccessActivityCount { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("WarningActivityCount")]
                [Validation(Required=false)]
                public int? WarningActivityCount { get; set; }

            }

        }

    }

}
