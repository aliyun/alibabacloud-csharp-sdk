// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribeAttackedIpResponseBody : TeaModel {
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<string> IpList { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
