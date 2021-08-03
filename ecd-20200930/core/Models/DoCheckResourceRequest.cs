// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DoCheckResourceRequest : TeaModel {
        [NameInMap("Invoker")]
        [Validation(Required=false)]
        public string Invoker { get; set; }

        [NameInMap("Pk")]
        [Validation(Required=false)]
        public string Pk { get; set; }

        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Hid")]
        [Validation(Required=false)]
        public long? Hid { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("TaskIdentifier")]
        [Validation(Required=false)]
        public string TaskIdentifier { get; set; }

        [NameInMap("TaskExtraData")]
        [Validation(Required=false)]
        public string TaskExtraData { get; set; }

        [NameInMap("GmtWakeup")]
        [Validation(Required=false)]
        public string GmtWakeup { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
