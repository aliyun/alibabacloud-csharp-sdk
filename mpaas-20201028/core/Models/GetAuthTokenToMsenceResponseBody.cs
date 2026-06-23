// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetAuthTokenToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasSystemOauthTokenResponse")]
        [Validation(Required=false)]
        public GetAuthTokenToMsenceResponseBodyMpaasSystemOauthTokenResponse MpaasSystemOauthTokenResponse { get; set; }
        public class GetAuthTokenToMsenceResponseBodyMpaasSystemOauthTokenResponse : TeaModel {
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public string ExpiresIn { get; set; }

            [NameInMap("OpenId")]
            [Validation(Required=false)]
            public string OpenId { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
