// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DescribeDSTTopologyRequest : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("IncludeMetrics")]
        [Validation(Required=false)]
        public bool? IncludeMetrics { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<DescribeDSTTopologyRequestDimensions> Dimensions { get; set; }
        public class DescribeDSTTopologyRequestDimensions : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
