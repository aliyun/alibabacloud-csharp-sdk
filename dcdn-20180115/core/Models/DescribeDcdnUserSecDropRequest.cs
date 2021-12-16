// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("SecFunc")]
        [Validation(Required=false)]
        public string SecFunc { get; set; }

    }

}
