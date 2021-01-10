// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutAppstenantexternalidappnamequeryapprepoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeBahamutAppstenantexternalidappnamequeryapprepoResponseBodyResult Result { get; set; }
        public class QueryLinkeBahamutAppstenantexternalidappnamequeryapprepoResponseBodyResult : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("ReadNeedOwnerAudit")]
            [Validation(Required=false)]
            public bool? ReadNeedOwnerAudit { get; set; }
            [NameInMap("ReadSecLevel")]
            [Validation(Required=false)]
            public string ReadSecLevel { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
            [NameInMap("RepoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }
            [NameInMap("WriteNeedOwnerAudit")]
            [Validation(Required=false)]
            public bool? WriteNeedOwnerAudit { get; set; }
            [NameInMap("WriteSecLevel")]
            [Validation(Required=false)]
            public string WriteSecLevel { get; set; }
        };

    }

}
