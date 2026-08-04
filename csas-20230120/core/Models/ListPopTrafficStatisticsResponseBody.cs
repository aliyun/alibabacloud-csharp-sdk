// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPopTrafficStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFE7EBB2-449D-5BBB-B381-CA7839BC1649</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of bandwidth data for the POPs.</para>
        /// </summary>
        [NameInMap("TrafficData")]
        [Validation(Required=false)]
        public List<ListPopTrafficStatisticsResponseBodyTrafficData> TrafficData { get; set; }
        public class ListPopTrafficStatisticsResponseBodyTrafficData : TeaModel {
            /// <summary>
            /// <para>A list of bandwidth data points for the POPs.</para>
            /// </summary>
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public List<ListPopTrafficStatisticsResponseBodyTrafficDataDatapoints> Datapoints { get; set; }
            public class ListPopTrafficStatisticsResponseBodyTrafficDataDatapoints : TeaModel {
                /// <summary>
                /// <para>The average bandwidth value per minute. The unit is Byte/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15325</para>
                /// </summary>
                [NameInMap("Average")]
                [Validation(Required=false)]
                public double? Average { get; set; }

                /// <summary>
                /// <para>The time that corresponds to the data point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-06 15:29:00</para>
                /// </summary>
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            /// <summary>
            /// <para>The name of the metric. Metrics are categorized as inbound or outbound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetTx</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

        }

    }

}
