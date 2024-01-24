// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceMonitorResponseBody : TeaModel {
        /// <summary>
        /// The result set of the query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDrdsInstanceMonitorResponseBodyData> Data { get; set; }
        public class DescribeDrdsInstanceMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the metric.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The number of nodes.
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// The unit of the metric value.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// The details of the monitoring data of the metric.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceMonitorResponseBodyDataValues> Values { get; set; }
            public class DescribeDrdsInstanceMonitorResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The point in time when the value of the metric was collected. The value is in the UNIX timestamp format. The timestamp is displayed in UTC. Unit: ms.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// The value of the metric.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
