// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeBahamutEnvinmultienvResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ExecLinkeBahamutEnvinmultienvResponseBodyResult> Result { get; set; }
        public class ExecLinkeBahamutEnvinmultienvResponseBodyResult : TeaModel {
            [NameInMap("CloudTenantId")]
            [Validation(Required=false)]
            public string CloudTenantId { get; set; }

            [NameInMap("CloudTenantName")]
            [Validation(Required=false)]
            public string CloudTenantName { get; set; }

            [NameInMap("ProdEnvReleaseInfo")]
            [Validation(Required=false)]
            public ExecLinkeBahamutEnvinmultienvResponseBodyResultProdEnvReleaseInfo ProdEnvReleaseInfo { get; set; }
            public class ExecLinkeBahamutEnvinmultienvResponseBodyResultProdEnvReleaseInfo : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("Ticket")]
                [Validation(Required=false)]
                public string Ticket { get; set; }
                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }
            };

            [NameInMap("PreEnvReleaseInfo")]
            [Validation(Required=false)]
            public ExecLinkeBahamutEnvinmultienvResponseBodyResultPreEnvReleaseInfo PreEnvReleaseInfo { get; set; }
            public class ExecLinkeBahamutEnvinmultienvResponseBodyResultPreEnvReleaseInfo : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("Ticket")]
                [Validation(Required=false)]
                public string Ticket { get; set; }
                [NameInMap("EnvId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }
            };

        }

    }

}
