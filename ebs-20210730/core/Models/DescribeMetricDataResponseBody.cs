// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeMetricDataResponseBody : TeaModel {
        /// <summary>
        /// The disk monitoring data.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeMetricDataResponseBodyDataList> DataList { get; set; }
        public class DescribeMetricDataResponseBodyDataList : TeaModel {
            /// <summary>
            /// The datapoints that consist of consecutive timestamps in seconds and metric values that were recorded at these time points.
            /// </summary>
            [NameInMap("Datapoints")]
            [Validation(Required=false)]
            public object Datapoints { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public object Labels { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of data entries queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
