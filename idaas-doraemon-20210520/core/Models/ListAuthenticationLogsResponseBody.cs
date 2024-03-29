// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListAuthenticationLogsResponseBody : TeaModel {
        [NameInMap("AuthenticationLogContent")]
        [Validation(Required=false)]
        public List<ListAuthenticationLogsResponseBodyAuthenticationLogContent> AuthenticationLogContent { get; set; }
        public class ListAuthenticationLogsResponseBodyAuthenticationLogContent : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("ApplicationExternalId")]
            [Validation(Required=false)]
            public string ApplicationExternalId { get; set; }

            [NameInMap("ApplicationUuid")]
            [Validation(Required=false)]
            public string ApplicationUuid { get; set; }

            [NameInMap("AuthenticationAction")]
            [Validation(Required=false)]
            public string AuthenticationAction { get; set; }

            [NameInMap("AuthenticationTime")]
            [Validation(Required=false)]
            public long? AuthenticationTime { get; set; }

            [NameInMap("AuthenticatorName")]
            [Validation(Required=false)]
            public string AuthenticatorName { get; set; }

            [NameInMap("AuthenticatorType")]
            [Validation(Required=false)]
            public string AuthenticatorType { get; set; }

            [NameInMap("AuthenticatorUuid")]
            [Validation(Required=false)]
            public string AuthenticatorUuid { get; set; }

            [NameInMap("ChallengeBase64")]
            [Validation(Required=false)]
            public string ChallengeBase64 { get; set; }

            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("LogParams")]
            [Validation(Required=false)]
            public string LogParams { get; set; }

            [NameInMap("LogTag")]
            [Validation(Required=false)]
            public string LogTag { get; set; }

            [NameInMap("RawAuthenticationContext")]
            [Validation(Required=false)]
            public string RawAuthenticationContext { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UserAgent")]
            [Validation(Required=false)]
            public string UserAgent { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserSourceIp")]
            [Validation(Required=false)]
            public string UserSourceIp { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public bool? VerifyResult { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
