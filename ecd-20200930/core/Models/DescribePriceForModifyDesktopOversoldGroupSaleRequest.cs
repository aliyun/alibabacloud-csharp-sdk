// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePriceForModifyDesktopOversoldGroupSaleRequest : TeaModel {
        [NameInMap("ConcurrenceCount")]
        [Validation(Required=false)]
        public int? ConcurrenceCount { get; set; }

        [NameInMap("OversoldGroupId")]
        [Validation(Required=false)]
        public string OversoldGroupId { get; set; }

        [NameInMap("OversoldUserCount")]
        [Validation(Required=false)]
        public int? OversoldUserCount { get; set; }

    }

}
