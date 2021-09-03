// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class GetOrganizationRepositorySettingResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetOrganizationRepositorySettingResponseBodyResult Result { get; set; }
        public class GetOrganizationRepositorySettingResponseBodyResult : TeaModel {
            [NameInMap("GroupRequired")]
            [Validation(Required=false)]
            public bool? GroupRequired { get; set; }
            [NameInMap("RepoVisibilityLevel")]
            [Validation(Required=false)]
            public List<string> RepoVisibilityLevel { get; set; }
            [NameInMap("RepoCreatorIdentity")]
            [Validation(Required=false)]
            public List<string> RepoCreatorIdentity { get; set; }
            [NameInMap("RepoAdminAccessVisibilityLevel")]
            [Validation(Required=false)]
            public List<string> RepoAdminAccessVisibilityLevel { get; set; }
            [NameInMap("RepoAdminOperation")]
            [Validation(Required=false)]
            public List<string> RepoAdminOperation { get; set; }
            [NameInMap("OpenCloneDownloadControl")]
            [Validation(Required=false)]
            public bool? OpenCloneDownloadControl { get; set; }
            [NameInMap("OrgCloneDownloadMethodList")]
            [Validation(Required=false)]
            public List<GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadMethodList> OrgCloneDownloadMethodList { get; set; }
            public class GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadMethodList : TeaModel {
                public string PermissionCode { get; set; }
                public bool? Allowed { get; set; }
            }
            [NameInMap("OrgCloneDownloadRoleList")]
            [Validation(Required=false)]
            public List<GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadRoleList> OrgCloneDownloadRoleList { get; set; }
            public class GetOrganizationRepositorySettingResponseBodyResultOrgCloneDownloadRoleList : TeaModel {
                public long? RoleCode { get; set; }
                public bool? Allowed { get; set; }
            }
            [NameInMap("ForcePushForbidden")]
            [Validation(Required=false)]
            public bool? ForcePushForbidden { get; set; }
        };

    }

}
