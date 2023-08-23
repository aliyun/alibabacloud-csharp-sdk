// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockMfaDeviceRequest : TeaModel {
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
