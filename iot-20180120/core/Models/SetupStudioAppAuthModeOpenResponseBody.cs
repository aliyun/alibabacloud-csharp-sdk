// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SetupStudioAppAuthModeOpenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetupStudioAppAuthModeOpenResponseBodyData Data { get; set; }
        public class SetupStudioAppAuthModeOpenResponseBodyData : TeaModel {
            [NameInMap("AuthMode")]
            [Validation(Required=false)]
            public int? AuthMode { get; set; }

            [NameInMap("TokenInfo")]
            [Validation(Required=false)]
            public SetupStudioAppAuthModeOpenResponseBodyDataTokenInfo TokenInfo { get; set; }
            public class SetupStudioAppAuthModeOpenResponseBodyDataTokenInfo : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("IsEnable")]
                [Validation(Required=false)]
                public string IsEnable { get; set; }

                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
