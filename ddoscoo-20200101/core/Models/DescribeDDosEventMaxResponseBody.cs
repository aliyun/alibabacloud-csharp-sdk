// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventMaxResponseBody : TeaModel {
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        [NameInMap("Mbps")]
        [Validation(Required=false)]
        public long? Mbps { get; set; }

        [NameInMap("Qps")]
        [Validation(Required=false)]
        public long? Qps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
