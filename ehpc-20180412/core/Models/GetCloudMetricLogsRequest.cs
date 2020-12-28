// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("To")]
        [Validation(Required=false)]
        public int? To { get; set; }

        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("AggregationType")]
        [Validation(Required=false)]
        public string AggregationType { get; set; }

        [NameInMap("AggregationInterval")]
        [Validation(Required=false)]
        public int? AggregationInterval { get; set; }

        [NameInMap("MetricScope")]
        [Validation(Required=false)]
        public string MetricScope { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        [NameInMap("MetricCategories")]
        [Validation(Required=false)]
        public string MetricCategories { get; set; }

    }

}
