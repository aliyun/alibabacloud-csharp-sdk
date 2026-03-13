// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceCreateAndDeleteStatisticsResponseBody : TeaModel {
        [NameInMap("InstanceCreateAndDeleteStatistics")]
        [Validation(Required=false)]
        public DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatistics InstanceCreateAndDeleteStatistics { get; set; }
        public class DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatisticsStatistic> Statistic { get; set; }
            public class DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatisticsStatistic : TeaModel {
                [NameInMap("CreatedVmCount")]
                [Validation(Required=false)]
                public int? CreatedVmCount { get; set; }

                [NameInMap("DestroyedVmCount")]
                [Validation(Required=false)]
                public int? DestroyedVmCount { get; set; }

                [NameInMap("StartedVmCount")]
                [Validation(Required=false)]
                public int? StartedVmCount { get; set; }

                [NameInMap("StoppedVmCount")]
                [Validation(Required=false)]
                public int? StoppedVmCount { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>086EFCD4-C76F-4DC6-9EE9-0D9B711E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
