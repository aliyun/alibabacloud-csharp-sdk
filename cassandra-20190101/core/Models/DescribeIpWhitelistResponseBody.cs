// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeIpWhitelistResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=false)]
        public DescribeIpWhitelistResponseBodyIpList IpList { get; set; }
        public class DescribeIpWhitelistResponseBodyIpList : TeaModel {
            [NameInMap("IP")]
            [Validation(Required=false)]
            public List<string> IP { get; set; }
        };

    }

}
