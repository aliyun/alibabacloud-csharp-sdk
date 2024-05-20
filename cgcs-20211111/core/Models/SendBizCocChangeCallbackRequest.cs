// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class SendBizCocChangeCallbackRequest : TeaModel {
        [NameInMap("PlatformSessionId")]
        [Validation(Required=false)]
        public string PlatformSessionId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
