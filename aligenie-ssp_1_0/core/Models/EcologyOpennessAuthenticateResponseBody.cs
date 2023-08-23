// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class EcologyOpennessAuthenticateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EcologyOpennessAuthenticateResponseBodyResult Result { get; set; }
        public class EcologyOpennessAuthenticateResponseBodyResult : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            [NameInMap("ThirdUserIdentifier")]
            [Validation(Required=false)]
            public string ThirdUserIdentifier { get; set; }

            [NameInMap("ThirdUserType")]
            [Validation(Required=false)]
            public string ThirdUserType { get; set; }

            [NameInMap("UserOpenId")]
            [Validation(Required=false)]
            public string UserOpenId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
