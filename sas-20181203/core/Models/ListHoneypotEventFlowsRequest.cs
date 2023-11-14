// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventFlowsRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEventId")]
        [Validation(Required=false)]
        public long? SecurityEventId { get; set; }

    }

}
