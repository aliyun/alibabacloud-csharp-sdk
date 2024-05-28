// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateRepositoryRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("adminSettingLanguage")]
        [Validation(Required=false)]
        public string AdminSettingLanguage { get; set; }

        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("buildsEnabled")]
        [Validation(Required=false)]
        public bool? BuildsEnabled { get; set; }

        [NameInMap("checkEmail")]
        [Validation(Required=false)]
        public bool? CheckEmail { get; set; }

        [NameInMap("defaultBranch")]
        [Validation(Required=false)]
        public string DefaultBranch { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("issuesEnabled")]
        [Validation(Required=false)]
        public bool? IssuesEnabled { get; set; }

        [NameInMap("mergeRequestsEnabled")]
        [Validation(Required=false)]
        public bool? MergeRequestsEnabled { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("openCloneDownloadControl")]
        [Validation(Required=false)]
        public bool? OpenCloneDownloadControl { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("projectCloneDownloadMethodList")]
        [Validation(Required=false)]
        public List<UpdateRepositoryRequestProjectCloneDownloadMethodList> ProjectCloneDownloadMethodList { get; set; }
        public class UpdateRepositoryRequestProjectCloneDownloadMethodList : TeaModel {
            [NameInMap("allowed")]
            [Validation(Required=false)]
            public bool? Allowed { get; set; }

            [NameInMap("permissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

        }

        [NameInMap("projectCloneDownloadRoleList")]
        [Validation(Required=false)]
        public List<UpdateRepositoryRequestProjectCloneDownloadRoleList> ProjectCloneDownloadRoleList { get; set; }
        public class UpdateRepositoryRequestProjectCloneDownloadRoleList : TeaModel {
            [NameInMap("allowed")]
            [Validation(Required=false)]
            public bool? Allowed { get; set; }

            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public int? RoleCode { get; set; }

        }

        [NameInMap("snippetsEnabled")]
        [Validation(Required=false)]
        public bool? SnippetsEnabled { get; set; }

        [NameInMap("visibilityLevel")]
        [Validation(Required=false)]
        public int? VisibilityLevel { get; set; }

        [NameInMap("wikiEnabled")]
        [Validation(Required=false)]
        public bool? WikiEnabled { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
