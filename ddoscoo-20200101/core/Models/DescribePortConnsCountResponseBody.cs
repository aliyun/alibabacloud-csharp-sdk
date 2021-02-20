// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortConnsCountResponseBody : TeaModel {
        [NameInMap("Conns")]
        [Validation(Required=false)]
        public long? Conns { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        [NameInMap("InActConns")]
        [Validation(Required=false)]
        public long? InActConns { get; set; }

        [NameInMap("ActConns")]
        [Validation(Required=false)]
        public long? ActConns { get; set; }

    }

}
