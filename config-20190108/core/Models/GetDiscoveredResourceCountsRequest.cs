// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetDiscoveredResourceCountsRequest : TeaModel {
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public long? MemberId { get; set; }

        [NameInMap("MultiAccount")]
        [Validation(Required=false)]
        public bool? MultiAccount { get; set; }

    }

}
