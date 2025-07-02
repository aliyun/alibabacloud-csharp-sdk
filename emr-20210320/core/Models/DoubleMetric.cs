// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DoubleMetric : TeaModel {
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
