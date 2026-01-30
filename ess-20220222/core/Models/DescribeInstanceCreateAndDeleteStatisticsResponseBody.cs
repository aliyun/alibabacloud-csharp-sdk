// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceCreateAndDeleteStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>Metrics for instance creation and deletion.</para>
        /// </summary>
        [NameInMap("InstanceCreateAndDeleteStatistics")]
        [Validation(Required=false)]
        public DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatistics InstanceCreateAndDeleteStatistics { get; set; }
        public class DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatisticsStatistic> Statistic { get; set; }
            public class DescribeInstanceCreateAndDeleteStatisticsResponseBodyInstanceCreateAndDeleteStatisticsStatistic : TeaModel {
                /// <summary>
                /// <para>The number of new instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("CreatedVmCount")]
                [Validation(Required=false)]
                public int? CreatedVmCount { get; set; }

                /// <summary>
                /// <para>The number of released instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("DestroyedVmCount")]
                [Validation(Required=false)]
                public int? DestroyedVmCount { get; set; }

                /// <summary>
                /// <para>The number of instances that are started from economical mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StartedVmCount")]
                [Validation(Required=false)]
                public int? StartedVmCount { get; set; }

                /// <summary>
                /// <para>The number of instances that are stopped in economical mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StoppedVmCount")]
                [Validation(Required=false)]
                public int? StoppedVmCount { get; set; }

                /// <summary>
                /// <para>The time when the statistics are generated. The time is in UTC. Format: yyyyMMddHH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025121623</para>
                /// </summary>
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
