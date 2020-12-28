// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetUserMFAInfoResponseBody : TeaModel {
        [NameInMap("MFADevice")]
        [Validation(Required=false)]
        public GetUserMFAInfoResponseBodyMFADevice MFADevice { get; set; }
        public class GetUserMFAInfoResponseBodyMFADevice : TeaModel {
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
