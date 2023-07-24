// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sasti20200512.Models
{
    public class DescribeDomainReportResponseBody : TeaModel {
        [NameInMap("AttackCntByThreatType")]
        [Validation(Required=false)]
        public string AttackCntByThreatType { get; set; }

        [NameInMap("AttackPreferenceTop5")]
        [Validation(Required=false)]
        public string AttackPreferenceTop5 { get; set; }

        [NameInMap("Basic")]
        [Validation(Required=false)]
        public string Basic { get; set; }

        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public string Confidence { get; set; }

        [NameInMap("Context")]
        [Validation(Required=false)]
        public string Context { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Intelligences")]
        [Validation(Required=false)]
        public string Intelligences { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        [NameInMap("SslCert")]
        [Validation(Required=false)]
        public string SslCert { get; set; }

        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

        [NameInMap("ThreatTypes")]
        [Validation(Required=false)]
        public string ThreatTypes { get; set; }

        [NameInMap("Whois")]
        [Validation(Required=false)]
        public string Whois { get; set; }

    }

}
