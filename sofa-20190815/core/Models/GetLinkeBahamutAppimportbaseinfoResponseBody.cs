// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutAppimportbaseinfoResponseBody : TeaModel {
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
        public GetLinkeBahamutAppimportbaseinfoResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutAppimportbaseinfoResponseBodyResult : TeaModel {
            [NameInMap("AccessControl")]
            [Validation(Required=false)]
            public string AccessControl { get; set; }
            [NameInMap("AppDisplayName")]
            [Validation(Required=false)]
            public string AppDisplayName { get; set; }
            [NameInMap("AppLevel")]
            [Validation(Required=false)]
            public string AppLevel { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppTechStackName")]
            [Validation(Required=false)]
            public string AppTechStackName { get; set; }
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }
            [NameInMap("ArchDomainId")]
            [Validation(Required=false)]
            public string ArchDomainId { get; set; }
            [NameInMap("CreateApp")]
            [Validation(Required=false)]
            public bool? CreateApp { get; set; }
            [NameInMap("CreateRepo")]
            [Validation(Required=false)]
            public bool? CreateRepo { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("FromLocal")]
            [Validation(Required=false)]
            public bool? FromLocal { get; set; }
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }
            [NameInMap("Repo")]
            [Validation(Required=false)]
            public string Repo { get; set; }
            [NameInMap("RepoEncode")]
            [Validation(Required=false)]
            public string RepoEncode { get; set; }
            [NameInMap("RepoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }
            [NameInMap("TechV2")]
            [Validation(Required=false)]
            public bool? TechV2 { get; set; }
            [NameInMap("TenantExternalId")]
            [Validation(Required=false)]
            public string TenantExternalId { get; set; }
            [NameInMap("DevOwnerAccounts")]
            [Validation(Required=false)]
            public List<string> DevOwnerAccounts { get; set; }
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<string> FileList { get; set; }
            [NameInMap("SyncCloudTenants")]
            [Validation(Required=false)]
            public List<string> SyncCloudTenants { get; set; }
            [NameInMap("TestOwnerAccounts")]
            [Validation(Required=false)]
            public List<string> TestOwnerAccounts { get; set; }
        };

    }

}
