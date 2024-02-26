// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class Metric : TeaModel {
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
