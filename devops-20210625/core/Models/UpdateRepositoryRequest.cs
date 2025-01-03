// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateRepositoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c3c09f1230187a879678da43c973d069</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Java</para>
        /// </summary>
        [NameInMap("adminSettingLanguage")]
        [Validation(Required=false)]
        public string AdminSettingLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxx">https://xxxx</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("buildsEnabled")]
        [Validation(Required=false)]
        public bool? BuildsEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkEmail")]
        [Validation(Required=false)]
        public bool? CheckEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("defaultBranch")]
        [Validation(Required=false)]
        public string DefaultBranch { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2080398</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("issuesEnabled")]
        [Validation(Required=false)]
        public bool? IssuesEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("mergeRequestsEnabled")]
        [Validation(Required=false)]
        public bool? MergeRequestsEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>codeup</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allowed")]
            [Validation(Required=false)]
            public bool? Allowed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project:download</para>
            /// </summary>
            [NameInMap("permissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

        }

        [NameInMap("projectCloneDownloadRoleList")]
        [Validation(Required=false)]
        public List<UpdateRepositoryRequestProjectCloneDownloadRoleList> ProjectCloneDownloadRoleList { get; set; }
        public class UpdateRepositoryRequestProjectCloneDownloadRoleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("allowed")]
            [Validation(Required=false)]
            public bool? Allowed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("roleCode")]
            [Validation(Required=false)]
            public int? RoleCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("snippetsEnabled")]
        [Validation(Required=false)]
        public bool? SnippetsEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("visibilityLevel")]
        [Validation(Required=false)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("wikiEnabled")]
        [Validation(Required=false)]
        public bool? WikiEnabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
