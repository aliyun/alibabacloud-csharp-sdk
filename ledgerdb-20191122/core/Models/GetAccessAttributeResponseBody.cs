// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class GetAccessAttributeResponseBody : TeaModel {
        [NameInMap("EnableOpenAccess")]
        [Validation(Required=false)]
        public string EnableOpenAccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LedgerId")]
        [Validation(Required=false)]
        public string LedgerId { get; set; }

        [NameInMap("OpenUri")]
        [Validation(Required=false)]
        public string OpenUri { get; set; }

    }

}
