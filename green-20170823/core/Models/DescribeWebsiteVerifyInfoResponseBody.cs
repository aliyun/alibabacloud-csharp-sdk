// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeWebsiteVerifyInfoResponseBody : TeaModel {
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("HostFile")]
        [Validation(Required=false)]
        public string HostFile { get; set; }

        [NameInMap("IndexPage")]
        [Validation(Required=false)]
        public string IndexPage { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VerifyMethod")]
        [Validation(Required=false)]
        public string VerifyMethod { get; set; }

    }

}
