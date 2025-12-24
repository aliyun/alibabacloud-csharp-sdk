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
                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("CreatedVmCount")]
                [Validation(Required=false)]
                public int? CreatedVmCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("DestroyedVmCount")]
                [Validation(Required=false)]
                public int? DestroyedVmCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("StartedVmCount")]
                [Validation(Required=false)]
                public int? StartedVmCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StoppedVmCount")]
                [Validation(Required=false)]
                public int? StoppedVmCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025121623</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>086EFCD4-C76F-4DC6-9EE9-0D9B711E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
