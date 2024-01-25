// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPopTrafficStatisticsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
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
                [NameInMap("Average")]
                [Validation(Required=false)]
                public double? Average { get; set; }

                [NameInMap("DateTime")]
                [Validation(Required=false)]
                public string DateTime { get; set; }

            }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

        }

    }

}
