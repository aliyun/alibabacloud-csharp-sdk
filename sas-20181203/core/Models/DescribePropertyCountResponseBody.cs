// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountResponseBody : TeaModel {
        [NameInMap("Process")]
        [Validation(Required=false)]
        public int? Process { get; set; }

        [NameInMap("AutoRun")]
        [Validation(Required=false)]
        public int? AutoRun { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public int? User { get; set; }

        [NameInMap("Software")]
        [Validation(Required=false)]
        public int? Software { get; set; }

        [NameInMap("Cron")]
        [Validation(Required=false)]
        public int? Cron { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("Sca")]
        [Validation(Required=false)]
        public int? Sca { get; set; }

    }

}
