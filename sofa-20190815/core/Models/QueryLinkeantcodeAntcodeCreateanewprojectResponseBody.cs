// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeCreateanewprojectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Archived")]
        [Validation(Required=false)]
        public bool? Archived { get; set; }

        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public bool? Artifacts { get; set; }

        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("CheckEmail")]
        [Validation(Required=false)]
        public bool? CheckEmail { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        [NameInMap("DefaultBranch")]
        [Validation(Required=false)]
        public string DefaultBranch { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("ExceptBranch")]
        [Validation(Required=false)]
        public string ExceptBranch { get; set; }

        [NameInMap("Homepage")]
        [Validation(Required=false)]
        public string Homepage { get; set; }

        [NameInMap("HttpUrlToRepo")]
        [Validation(Required=false)]
        public string HttpUrlToRepo { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ImportStatus")]
        [Validation(Required=false)]
        public string ImportStatus { get; set; }

        [NameInMap("IsGray")]
        [Validation(Required=false)]
        public bool? IsGray { get; set; }

        [NameInMap("IsReview")]
        [Validation(Required=false)]
        public bool? IsReview { get; set; }

        [NameInMap("LastActivityAt")]
        [Validation(Required=false)]
        public string LastActivityAt { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NameWithNamespace")]
        [Validation(Required=false)]
        public string NameWithNamespace { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("PathWithNamespace")]
        [Validation(Required=false)]
        public string PathWithNamespace { get; set; }

        [NameInMap("Public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        [NameInMap("RepositorySize")]
        [Validation(Required=false)]
        public string RepositorySize { get; set; }

        [NameInMap("RepositorySizeLimit")]
        [Validation(Required=false)]
        public long? RepositorySizeLimit { get; set; }

        [NameInMap("ResponsePage")]
        [Validation(Required=false)]
        public string ResponsePage { get; set; }

        [NameInMap("ResponsePageInfoNextPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoNextPage { get; set; }

        [NameInMap("ResponsePageInfoPerPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoPerPage { get; set; }

        [NameInMap("ResponsePageInfoPrevPage")]
        [Validation(Required=false)]
        public string ResponsePageInfoPrevPage { get; set; }

        [NameInMap("ResponsePageInfoTotal")]
        [Validation(Required=false)]
        public string ResponsePageInfoTotal { get; set; }

        [NameInMap("ResponsePageInfoTotalPages")]
        [Validation(Required=false)]
        public string ResponsePageInfoTotalPages { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("RunnersToken")]
        [Validation(Required=false)]
        public string RunnersToken { get; set; }

        [NameInMap("SshUrlToRepo")]
        [Validation(Required=false)]
        public string SshUrlToRepo { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("VisibilityLevel")]
        [Validation(Required=false)]
        public long? VisibilityLevel { get; set; }

        [NameInMap("WebUrl")]
        [Validation(Required=false)]
        public string WebUrl { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyNamespace Namespace { get; set; }
        public class QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyNamespace : TeaModel {
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }
            [NameInMap("Public")]
            [Validation(Required=false)]
            public bool? Public { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
        };

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyOwner Owner { get; set; }
        public class QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyOwner : TeaModel {
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("ExternUid")]
            [Validation(Required=false)]
            public string ExternUid { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NotificationLevel")]
            [Validation(Required=false)]
            public long? NotificationLevel { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }
            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }
        };

        [NameInMap("Permission")]
        [Validation(Required=false)]
        public QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyPermission Permission { get; set; }
        public class QueryLinkeantcodeAntcodeCreateanewprojectResponseBodyPermission : TeaModel {
            [NameInMap("GroupAccess")]
            [Validation(Required=false)]
            public string GroupAccess { get; set; }
            [NameInMap("ProjectAccess")]
            [Validation(Required=false)]
            public string ProjectAccess { get; set; }
            [NameInMap("ReviewAccess")]
            [Validation(Required=false)]
            public string ReviewAccess { get; set; }
            [NameInMap("TenantAccess")]
            [Validation(Required=false)]
            public string TenantAccess { get; set; }
        };

    }

}
