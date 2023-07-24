// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sasti20200512.Models
{
    public class DescribeFileReportResponseBody : TeaModel {
        [NameInMap("Basic")]
        [Validation(Required=false)]
        public string Basic { get; set; }

        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        [NameInMap("Intelligences")]
        [Validation(Required=false)]
        public string Intelligences { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sandbox")]
        [Validation(Required=false)]
        public string Sandbox { get; set; }

        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

        [NameInMap("ThreatTypes")]
        [Validation(Required=false)]
        public string ThreatTypes { get; set; }

    }

}
