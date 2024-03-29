// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class RegisterAuthenticatorRequest : TeaModel {
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        [NameInMap("AuthenticatorName")]
        [Validation(Required=false)]
        public string AuthenticatorName { get; set; }

        [NameInMap("AuthenticatorType")]
        [Validation(Required=false)]
        public string AuthenticatorType { get; set; }

        [NameInMap("ClientExtendParamsJson")]
        [Validation(Required=false)]
        public string ClientExtendParamsJson { get; set; }

        [NameInMap("ClientExtendParamsJsonSign")]
        [Validation(Required=false)]
        public string ClientExtendParamsJsonSign { get; set; }

        [NameInMap("LogParams")]
        [Validation(Required=false)]
        public string LogParams { get; set; }

        [NameInMap("RegistrationContext")]
        [Validation(Required=false)]
        public string RegistrationContext { get; set; }

        [NameInMap("RequireChallengeBase64")]
        [Validation(Required=false)]
        public string RequireChallengeBase64 { get; set; }

        [NameInMap("ServerExtendParamsJson")]
        [Validation(Required=false)]
        public string ServerExtendParamsJson { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserSourceIp")]
        [Validation(Required=false)]
        public string UserSourceIp { get; set; }

    }

}
