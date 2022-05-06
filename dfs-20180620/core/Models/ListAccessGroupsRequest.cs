// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListAccessGroupsRequest : TeaModel {
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("StartOffset")]
        [Validation(Required=false)]
        public int? StartOffset { get; set; }

    }

}
