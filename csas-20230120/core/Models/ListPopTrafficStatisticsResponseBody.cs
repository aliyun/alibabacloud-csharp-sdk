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

        [NameInMap("TrafficData")]
        [Validation(Required=false)]
        public List<ListPopTrafficStatisticsResponseBodyTrafficData> TrafficData { get; set; }
        public class ListPopTrafficStatisticsResponseBodyTrafficData : TeaModel {
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public List<ListPopTrafficStatisticsResponseBodyTrafficDataDatapoints> Datapoints { get; set; }
            public class ListPopTrafficStatisticsResponseBodyTrafficDataDatapoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>15325</para>
                /// </summary>
                [NameInMap("Average")]
                [Validation(Required=false)]
                public double? Average { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-12-06 15:29:00</para>
                /// </summary>
                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InternetTx</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

        }

    }

}
