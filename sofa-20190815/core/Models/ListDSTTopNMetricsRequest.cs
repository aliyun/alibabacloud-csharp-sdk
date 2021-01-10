// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTTopNMetricsRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<ListDSTTopNMetricsRequestMetrics> Metrics { get; set; }
        public class ListDSTTopNMetricsRequestMetrics : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListDSTTopNMetricsRequestTags> Tags { get; set; }
        public class ListDSTTopNMetricsRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TopN")]
        [Validation(Required=false)]
        public long? TopN { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
