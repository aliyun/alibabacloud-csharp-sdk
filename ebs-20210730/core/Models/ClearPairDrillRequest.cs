// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ClearPairDrillRequest : TeaModel {
        [NameInMap("DrillId")]
        [Validation(Required=false)]
        public string DrillId { get; set; }

        [NameInMap("PairId")]
        [Validation(Required=false)]
        public string PairId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
