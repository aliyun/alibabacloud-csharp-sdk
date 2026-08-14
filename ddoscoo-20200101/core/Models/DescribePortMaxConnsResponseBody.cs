// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortMaxConnsResponseBody : TeaModel {
        [NameInMap("PortMaxConns")]
        [Validation(Required=false)]
        public List<DescribePortMaxConnsResponseBodyPortMaxConns> PortMaxConns { get; set; }
        public class DescribePortMaxConnsResponseBodyPortMaxConns : TeaModel {
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
