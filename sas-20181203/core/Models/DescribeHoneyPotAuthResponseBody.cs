// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHoneyPotAuthResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HoneyPotCount")]
        [Validation(Required=false)]
        public int? HoneyPotCount { get; set; }

        [NameInMap("HoneyPotAuthCount")]
        [Validation(Required=false)]
        public long? HoneyPotAuthCount { get; set; }

    }

}
