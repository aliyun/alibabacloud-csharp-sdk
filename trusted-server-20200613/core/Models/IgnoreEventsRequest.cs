// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class IgnoreEventsRequest : TeaModel {
        [NameInMap("EventUuids")]
        [Validation(Required=false)]
        public string EventUuids { get; set; }

        [NameInMap("HandleStyle")]
        [Validation(Required=false)]
        public int? HandleStyle { get; set; }

    }

}
