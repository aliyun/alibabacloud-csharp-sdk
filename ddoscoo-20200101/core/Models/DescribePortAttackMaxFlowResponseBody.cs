// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortAttackMaxFlowResponseBody : TeaModel {
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public long? Pps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Bps")]
        [Validation(Required=false)]
        public long? Bps { get; set; }

    }

}
