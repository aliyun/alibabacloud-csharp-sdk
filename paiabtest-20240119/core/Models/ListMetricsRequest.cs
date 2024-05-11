// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIABTest20240119.Models
{
    public class ListMetricsRequest : TeaModel {
        [NameInMap("All")]
        [Validation(Required=false)]
        public string All { get; set; }

        [NameInMap("MetricGroupId")]
        [Validation(Required=false)]
        public string MetricGroupId { get; set; }

        [NameInMap("MetricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
