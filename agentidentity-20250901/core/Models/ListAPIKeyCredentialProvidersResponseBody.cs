// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListAPIKeyCredentialProvidersResponseBody : TeaModel {
        [NameInMap("APIKeyCredentialProviders")]
        [Validation(Required=false)]
        public List<ListAPIKeyCredentialProvidersResponseBodyAPIKeyCredentialProviders> APIKeyCredentialProviders { get; set; }
        public class ListAPIKeyCredentialProvidersResponseBodyAPIKeyCredentialProviders : TeaModel {
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

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
