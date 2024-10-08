// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafQuotaInteger : TeaModel {
        [NameInMap("Equal")]
        [Validation(Required=false)]
        public int? Equal { get; set; }

        [NameInMap("GreaterThan")]
        [Validation(Required=false)]
        public int? GreaterThan { get; set; }

        [NameInMap("GreaterThanOrEqual")]
        [Validation(Required=false)]
        public int? GreaterThanOrEqual { get; set; }

        [NameInMap("LessThan")]
        [Validation(Required=false)]
        public int? LessThan { get; set; }

        [NameInMap("LessThanOrEqual")]
        [Validation(Required=false)]
        public int? LessThanOrEqual { get; set; }

    }

}
