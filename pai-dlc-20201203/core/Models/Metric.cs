// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Metric : TeaModel {
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
