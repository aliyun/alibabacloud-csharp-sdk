// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutWorkspacesResponseBody : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutWorkspacesResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutWorkspacesResponseBodyResult : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("AccessSecret")]
            [Validation(Required=false)]
            public string AccessSecret { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("CrossCloud")]
            [Validation(Required=false)]
            public bool? CrossCloud { get; set; }

            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("DefaultUse")]
            [Validation(Required=false)]
            public bool? DefaultUse { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("LinkETenant")]
            [Validation(Required=false)]
            public string LinkETenant { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Use")]
            [Validation(Required=false)]
            public string Use { get; set; }

            [NameInMap("WorkspaceGroupId")]
            [Validation(Required=false)]
            public string WorkspaceGroupId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            [NameInMap("CloudTenant")]
            [Validation(Required=false)]
            public QueryLinkeBahamutWorkspacesResponseBodyResultCloudTenant CloudTenant { get; set; }
            public class QueryLinkeBahamutWorkspacesResponseBodyResultCloudTenant : TeaModel {
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }
                [NameInMap("AccessSecret")]
                [Validation(Required=false)]
                public string AccessSecret { get; set; }
                [NameInMap("Created")]
                [Validation(Required=false)]
                public long? Created { get; set; }
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }
                [NameInMap("EndPoint")]
                [Validation(Required=false)]
                public string EndPoint { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public long? LastModified { get; set; }
                [NameInMap("LinkETenant")]
                [Validation(Required=false)]
                public string LinkETenant { get; set; }
                [NameInMap("StationName")]
                [Validation(Required=false)]
                public string StationName { get; set; }
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }
            };

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public QueryLinkeBahamutWorkspacesResponseBodyResultExtraInfo ExtraInfo { get; set; }
            public class QueryLinkeBahamutWorkspacesResponseBodyResultExtraInfo : TeaModel {
                [NameInMap("AntXUrl")]
                [Validation(Required=false)]
                public string AntXUrl { get; set; }
                [NameInMap("AuthTokenType")]
                [Validation(Required=false)]
                public bool? AuthTokenType { get; set; }
                [NameInMap("EnvTypeEnum")]
                [Validation(Required=false)]
                public string EnvTypeEnum { get; set; }
                [NameInMap("GroupStrategy")]
                [Validation(Required=false)]
                public string GroupStrategy { get; set; }
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }
                [NameInMap("LdcConsoleUrl")]
                [Validation(Required=false)]
                public string LdcConsoleUrl { get; set; }
                [NameInMap("MachImport")]
                [Validation(Required=false)]
                public bool? MachImport { get; set; }
                [NameInMap("MachIter")]
                [Validation(Required=false)]
                public bool? MachIter { get; set; }
                [NameInMap("MavenModeEnum")]
                [Validation(Required=false)]
                public string MavenModeEnum { get; set; }
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }
                [NameInMap("RegistryHost")]
                [Validation(Required=false)]
                public string RegistryHost { get; set; }
                [NameInMap("ReleaseTypeEnum")]
                [Validation(Required=false)]
                public string ReleaseTypeEnum { get; set; }
                [NameInMap("ShareOpenAPI")]
                [Validation(Required=false)]
                public bool? ShareOpenAPI { get; set; }
                [NameInMap("SofarouterEnabled")]
                [Validation(Required=false)]
                public bool? SofarouterEnabled { get; set; }
                [NameInMap("BuildWorkspaceList")]
                [Validation(Required=false)]
                public List<string> BuildWorkspaceList { get; set; }
            };

            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public QueryLinkeBahamutWorkspacesResponseBodyResultModifier Modifier { get; set; }
            public class QueryLinkeBahamutWorkspacesResponseBodyResultModifier : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }
                [NameInMap("Created")]
                [Validation(Required=false)]
                public long? Created { get; set; }
                [NameInMap("Customer")]
                [Validation(Required=false)]
                public string Customer { get; set; }
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }
                [NameInMap("Department")]
                [Validation(Required=false)]
                public string Department { get; set; }
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }
                [NameInMap("EmpId")]
                [Validation(Required=false)]
                public string EmpId { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("LastLogin")]
                [Validation(Required=false)]
                public long? LastLogin { get; set; }
                [NameInMap("LastModified")]
                [Validation(Required=false)]
                public long? LastModified { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }
                [NameInMap("UniqueId")]
                [Validation(Required=false)]
                public string UniqueId { get; set; }
                [NameInMap("Ww")]
                [Validation(Required=false)]
                public string Ww { get; set; }
                [NameInMap("Tenants")]
                [Validation(Required=false)]
                public List<string> Tenants { get; set; }
            };

        }

    }

}
