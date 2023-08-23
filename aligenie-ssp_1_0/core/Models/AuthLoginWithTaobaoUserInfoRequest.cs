// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithTaobaoUserInfoRequest : TeaModel {
        [NameInMap("EncryptedTaobaoUserIdentifier")]
        [Validation(Required=false)]
        public string EncryptedTaobaoUserIdentifier { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
