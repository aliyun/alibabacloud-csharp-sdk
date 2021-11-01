// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        [NameInMap("IsMFAEnable")]
        [Validation(Required=false)]
        public bool? IsMFAEnable { get; set; }

        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public GetUserMFAInfoResponseBodyMFADevice MFADevice { get; set; }
        public class GetUserMFAInfoResponseBodyMFADevice : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
