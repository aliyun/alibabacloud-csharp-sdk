// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class VerifyUserAuthenticationResponseBody : TeaModel {
        [NameInMap("AuthenticateResultInfo")]
        [Validation(Required=false)]
        public VerifyUserAuthenticationResponseBodyAuthenticateResultInfo AuthenticateResultInfo { get; set; }
        public class VerifyUserAuthenticationResponseBodyAuthenticateResultInfo : TeaModel {
            [NameInMap("BindHashBase64")]
            [Validation(Required=false)]
            public string BindHashBase64 { get; set; }

            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("EtasSDKString")]
        [Validation(Required=false)]
        public string EtasSDKString { get; set; }

        [NameInMap("IdToken")]
        [Validation(Required=false)]
        public string IdToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VerifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

    }

}
