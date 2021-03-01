// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryMonitorInfoRequest : TeaModel {
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public string Aggregator { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

    }

}
