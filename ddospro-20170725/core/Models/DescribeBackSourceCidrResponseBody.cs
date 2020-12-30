// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeBackSourceCidrResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CidrList")]
        [Validation(Required=false)]
        public DescribeBackSourceCidrResponseBodyCidrList CidrList { get; set; }
        public class DescribeBackSourceCidrResponseBodyCidrList : TeaModel {
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public List<string> Cidr { get; set; }
        };

    }

}
