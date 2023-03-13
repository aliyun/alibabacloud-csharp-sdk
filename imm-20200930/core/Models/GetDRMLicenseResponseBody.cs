// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDRMLicenseResponseBody : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfo { get; set; }

        [NameInMap("License")]
        [Validation(Required=false)]
        public string License { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("States")]
        [Validation(Required=false)]
        public long? States { get; set; }

    }

}
