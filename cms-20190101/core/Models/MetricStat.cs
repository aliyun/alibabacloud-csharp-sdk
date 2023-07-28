// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class MetricStat : TeaModel {
        [NameInMap("Associated")]
        [Validation(Required=false)]
        public Dictionary<string, string> Associated { get; set; }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<Dimension> Dimensions { get; set; }

        [NameInMap("LogTime")]
        [Validation(Required=false)]
        public long? LogTime { get; set; }

        [NameInMap("Measurements")]
        [Validation(Required=false)]
        public Dictionary<string, object> Measurements { get; set; }

        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
