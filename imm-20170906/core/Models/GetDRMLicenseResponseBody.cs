// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetDRMLicenseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfo { get; set; }

        [NameInMap("DRMData")]
        [Validation(Required=false)]
        public string DRMData { get; set; }

    }

}
