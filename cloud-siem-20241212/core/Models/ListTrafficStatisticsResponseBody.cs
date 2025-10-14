// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListTrafficStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficStatistics")]
        [Validation(Required=false)]
        public List<ListTrafficStatisticsResponseBodyTrafficStatistics> TrafficStatistics { get; set; }
        public class ListTrafficStatisticsResponseBodyTrafficStatistics : TeaModel {
            [NameInMap("TrafficStatisticData")]
            [Validation(Required=false)]
            public List<ListTrafficStatisticsResponseBodyTrafficStatisticsTrafficStatisticData> TrafficStatisticData { get; set; }
            public class ListTrafficStatisticsResponseBodyTrafficStatisticsTrafficStatisticData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20250815。</para>
                /// </summary>
                [NameInMap("TrafficStatisticTime")]
                [Validation(Required=false)]
                public long? TrafficStatisticTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.699814。</para>
                /// </summary>
                [NameInMap("TrafficStatisticValue")]
                [Validation(Required=false)]
                public double? TrafficStatisticValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>all。</para>
            /// </summary>
            [NameInMap("TrafficStatisticTarget")]
            [Validation(Required=false)]
            public string TrafficStatisticTarget { get; set; }

        }

    }

}
