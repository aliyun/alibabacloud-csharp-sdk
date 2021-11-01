// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class BindMFADeviceRequest : TeaModel {
        [NameInMap("AuthenticationCode1")]
        [Validation(Required=false)]
        public string AuthenticationCode1 { get; set; }

        [NameInMap("AuthenticationCode2")]
        [Validation(Required=false)]
        public string AuthenticationCode2 { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
