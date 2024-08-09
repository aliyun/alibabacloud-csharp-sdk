// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class WatermarkSpec : TeaModel {
        [NameInMap("column")]
        [Validation(Required=false)]
        public string Column { get; set; }

        [NameInMap("watermarkExpression")]
        [Validation(Required=false)]
        public string WatermarkExpression { get; set; }

    }

}
