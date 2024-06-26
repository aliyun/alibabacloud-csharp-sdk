// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class VerifyUserAuthenticationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthenticationContext")]
        [Validation(Required=false)]
        public string AuthenticationContext { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        [NameInMap("LogTag")]
        [Validation(Required=false)]
        public string LogTag { get; set; }

        [NameInMap("RequireBindHashBase64")]
        [Validation(Required=false)]
        public string RequireBindHashBase64 { get; set; }

        [NameInMap("RequireChallengeBase64")]
        [Validation(Required=false)]
        public string RequireChallengeBase64 { get; set; }

        [NameInMap("ServerExtendParamsJson")]
        [Validation(Required=false)]
        public string ServerExtendParamsJson { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserSourceIp")]
        [Validation(Required=false)]
        public string UserSourceIp { get; set; }

    }

}
