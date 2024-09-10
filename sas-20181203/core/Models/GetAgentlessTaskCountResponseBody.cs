// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountResponseBody : TeaModel {
        /// <summary>
        /// The number of baseline checks.
        /// </summary>
        [NameInMap("BaselineCheckCount")]
        [Validation(Required=false)]
        public int? BaselineCheckCount { get; set; }

        /// <summary>
        /// The number of system vulnerabilities.
        /// </summary>
        [NameInMap("CveVulCount")]
        [Validation(Required=false)]
        public int? CveVulCount { get; set; }

        /// <summary>
        /// The timestamp generated when the last detection is performed.
        /// </summary>
        [NameInMap("LastTaskTime")]
        [Validation(Required=false)]
        public long? LastTaskTime { get; set; }

        /// <summary>
        /// The number of malicious files.
        /// </summary>
        [NameInMap("MaliciousFile")]
        [Validation(Required=false)]
        public int? MaliciousFile { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of risky hosts.
        /// </summary>
        [NameInMap("RiskMachine")]
        [Validation(Required=false)]
        public int? RiskMachine { get; set; }

        /// <summary>
        /// The number of application vulnerabilities.
        /// </summary>
        [NameInMap("ScaVulCount")]
        [Validation(Required=false)]
        public int? ScaVulCount { get; set; }

        /// <summary>
        /// The number of hosts that are scanned.
        /// </summary>
        [NameInMap("ScanMachine")]
        [Validation(Required=false)]
        public int? ScanMachine { get; set; }

        /// <summary>
        /// The total number of sensitive files.
        /// </summary>
        [NameInMap("SensitiveFileCount")]
        [Validation(Required=false)]
        public int? SensitiveFileCount { get; set; }

        /// <summary>
        /// The total number of Windows system vulnerabilities.
        /// </summary>
        [NameInMap("SysVulCount")]
        [Validation(Required=false)]
        public string SysVulCount { get; set; }

        /// <summary>
        /// The number of vulnerabilities.
        /// </summary>
        [NameInMap("Vulnerability")]
        [Validation(Required=false)]
        public int? Vulnerability { get; set; }

    }

}
