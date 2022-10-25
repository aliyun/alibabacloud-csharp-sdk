// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetOrganizationRepositorySettingResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetOrganizationRepositorySettingResponseBodyResult Result { get; set; }
        public class GetOrganizationRepositorySettingResponseBodyResult : TeaModel {
            [NameInMap("ForcePushForbidden")]
            [Validation(Required=false)]
            public bool? ForcePushForbidden { get; set; }

            [NameInMap("GroupRequired")]
            [Validation(Required=false)]
            public bool? GroupRequired { get; set; }

            [NameInMap("OpenCloneDownloadControl")]
            [Validation(Required=false)]
            public bool? OpenCloneDownloadControl { get; set; }

            [NameInMap("OrgCloneDownloadMethodList")]
            [Validation(Required=false)]
            public List<GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadMethodList> OrgCloneDownloadMethodList { get; set; }
            public class GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadMethodList : TeaModel {
                [NameInMap("Allowed")]
                [Validation(Required=false)]
                public bool? Allowed { get; set; }

                [NameInMap("PermissionCode")]
                [Validation(Required=false)]
                public string PermissionCode { get; set; }

            }

            [NameInMap("OrgCloneDownloadRoleList")]
            [Validation(Required=false)]
            public List<GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadRoleList> OrgCloneDownloadRoleList { get; set; }
            public class GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadRoleList : TeaModel {
                [NameInMap("Allowed")]
                [Validation(Required=false)]
                public bool? Allowed { get; set; }

                [NameInMap("RoleCode")]
                [Validation(Required=false)]
                public long? RoleCode { get; set; }

            }

            [NameInMap("RepoAdminAccessVisibilityLevel")]
            [Validation(Required=false)]
            public List<long?> RepoAdminAccessVisibilityLevel { get; set; }

            [NameInMap("RepoAdminOperation")]
            [Validation(Required=false)]
            public List<long?> RepoAdminOperation { get; set; }

            [NameInMap("RepoCreatorIdentity")]
            [Validation(Required=false)]
            public List<long?> RepoCreatorIdentity { get; set; }

            [NameInMap("RepoVisibilityLevel")]
            [Validation(Required=false)]
            public List<long?> RepoVisibilityLevel { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
