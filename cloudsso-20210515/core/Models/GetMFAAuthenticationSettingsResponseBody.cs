// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationSettingsResponseBody : TeaModel {
        [NameInMap("MFAAuthenticationAdvanceSettings")]
        [Validation(Required=false)]
        public string MFAAuthenticationAdvanceSettings { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
