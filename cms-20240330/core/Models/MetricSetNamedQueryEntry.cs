// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetNamedQueryEntry : TeaModel {
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<UmodelLabelFilter> LabelFilters { get; set; }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
