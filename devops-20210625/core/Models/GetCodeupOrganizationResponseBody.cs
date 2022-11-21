// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetCodeupOrganizationResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCodeupOrganizationResponseBodyResult Result { get; set; }
        public class GetCodeupOrganizationResponseBodyResult : TeaModel {
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("namespaceId")]
            [Validation(Required=false)]
            public long? NamespaceId { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("userRole")]
            [Validation(Required=false)]
            public string UserRole { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
