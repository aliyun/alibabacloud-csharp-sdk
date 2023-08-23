// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithAligenieUserInfoRequest : TeaModel {
        [NameInMap("EncryptedAligenieUserIdentifier")]
        [Validation(Required=false)]
        public string EncryptedAligenieUserIdentifier { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
