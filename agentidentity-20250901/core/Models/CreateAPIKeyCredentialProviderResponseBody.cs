// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateAPIKeyCredentialProviderResponseBody : TeaModel {
        [NameInMap("APIKeyCredentialProvider")]
        [Validation(Required=false)]
        public CreateAPIKeyCredentialProviderResponseBodyAPIKeyCredentialProvider APIKeyCredentialProvider { get; set; }
        public class CreateAPIKeyCredentialProviderResponseBodyAPIKeyCredentialProvider : TeaModel {
            [NameInMap("APIKeyCredentialProviderName")]
            [Validation(Required=false)]
            public string APIKeyCredentialProviderName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CredentialProviderArn")]
            [Validation(Required=false)]
            public string CredentialProviderArn { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
