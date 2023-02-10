// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountResponseBody : TeaModel {
        [NameInMap("Autorun")]
        [Validation(Required=false)]
        public int? Autorun { get; set; }

        [NameInMap("Cron")]
        [Validation(Required=false)]
        public int? Cron { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public int? Database { get; set; }

        [NameInMap("Lkm")]
        [Validation(Required=false)]
        public int? Lkm { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("Process")]
        [Validation(Required=false)]
        public int? Process { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sca")]
        [Validation(Required=false)]
        public int? Sca { get; set; }

        [NameInMap("Software")]
        [Validation(Required=false)]
        public int? Software { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public int? User { get; set; }

        [NameInMap("Web")]
        [Validation(Required=false)]
        public int? Web { get; set; }

        [NameInMap("Webserver")]
        [Validation(Required=false)]
        public int? Webserver { get; set; }

    }

}
