// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeLivePubMetricDataRequest : TeaModel {
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public long? BeginTs { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        [NameInMap("ExperienceLevel")]
        [Validation(Required=false)]
        public string ExperienceLevel { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("PubProtocol")]
        [Validation(Required=false)]
        public string PubProtocol { get; set; }

        [NameInMap("SdkVersion")]
        [Validation(Required=false)]
        public string SdkVersion { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
