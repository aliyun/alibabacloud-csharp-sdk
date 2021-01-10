// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class UpdateHttpTriggerConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DefaultEndpoint")]
        [Validation(Required=false)]
        public string DefaultEndpoint { get; set; }

        [NameInMap("EnableService")]
        [Validation(Required=false)]
        public bool? EnableService { get; set; }

    }

}
