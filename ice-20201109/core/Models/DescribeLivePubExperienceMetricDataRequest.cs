// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeLivePubExperienceMetricDataRequest : TeaModel {
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public string BeginTs { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        [NameInMap("PubProtocol")]
        [Validation(Required=false)]
        public string PubProtocol { get; set; }

        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
