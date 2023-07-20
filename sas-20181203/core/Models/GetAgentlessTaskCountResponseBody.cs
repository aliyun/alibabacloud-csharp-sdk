// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountResponseBody : TeaModel {
        [NameInMap("BaselineCheckCount")]
        [Validation(Required=false)]
        public int? BaselineCheckCount { get; set; }

        [NameInMap("CveVulCount")]
        [Validation(Required=false)]
        public int? CveVulCount { get; set; }

        [NameInMap("LastTaskTime")]
        [Validation(Required=false)]
        public long? LastTaskTime { get; set; }

        [NameInMap("MaliciousFile")]
        [Validation(Required=false)]
        public int? MaliciousFile { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskMachine")]
        [Validation(Required=false)]
        public int? RiskMachine { get; set; }

        [NameInMap("ScaVulCount")]
        [Validation(Required=false)]
        public int? ScaVulCount { get; set; }

        [NameInMap("ScanMachine")]
        [Validation(Required=false)]
        public int? ScanMachine { get; set; }

        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public int? Vulnerability { get; set; }

    }

}
