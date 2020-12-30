// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeSourceFailureTopIpResponseBody : TeaModel {
        [NameInMap("TopIps")]
        [Validation(Required=false)]
        public List<DescribeSourceFailureTopIpResponseBodyTopIps> TopIps { get; set; }
        public class DescribeSourceFailureTopIpResponseBodyTopIps : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
