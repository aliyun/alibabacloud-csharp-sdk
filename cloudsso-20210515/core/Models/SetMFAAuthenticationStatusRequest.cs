// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetMFAAuthenticationStatusRequest : TeaModel {
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("MFAAuthenticationStatus")]
        [Validation(Required=false)]
        public string MFAAuthenticationStatus { get; set; }

    }

}
