// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class EcologyOpennessAuthenticateRequest : TeaModel {
        [NameInMap("EncodeKey")]
        [Validation(Required=false)]
        public string EncodeKey { get; set; }

        [NameInMap("EncodeType")]
        [Validation(Required=false)]
        public string EncodeType { get; set; }

        [NameInMap("LoginStateAccessToken")]
        [Validation(Required=false)]
        public string LoginStateAccessToken { get; set; }

    }

}
