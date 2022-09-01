// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetUserMFAAuthenticationSettingsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserMFAAuthenticationSettings")]
        [Validation(Required=false)]
        public string UserMFAAuthenticationSettings { get; set; }

    }

}
