// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class ListAuthenticatorsResponseBody : TeaModel {
        [NameInMap("Authenticator")]
        [Validation(Required=false)]
        public List<ListAuthenticatorsResponseBodyAuthenticator> Authenticator { get; set; }
        public class ListAuthenticatorsResponseBodyAuthenticator : TeaModel {
            [NameInMap("ApplicationExternalId")]
            [Validation(Required=false)]
            public string ApplicationExternalId { get; set; }

            [NameInMap("AuthenticatorName")]
            [Validation(Required=false)]
            public string AuthenticatorName { get; set; }

            [NameInMap("AuthenticatorUuid")]
            [Validation(Required=false)]
            public string AuthenticatorUuid { get; set; }

            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            [NameInMap("LastVerifyTime")]
            [Validation(Required=false)]
            public long? LastVerifyTime { get; set; }

            [NameInMap("RegisterTime")]
            [Validation(Required=false)]
            public long? RegisterTime { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
