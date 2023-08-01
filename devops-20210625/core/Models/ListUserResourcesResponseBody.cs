// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserResourcesResponseBody : TeaModel {
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
        public List<ListUserResourcesResponseBodyResult> Result { get; set; }
        public class ListUserResourcesResponseBodyResult : TeaModel {
            [NameInMap("groupInfos")]
            [Validation(Required=false)]
            public List<ListUserResourcesResponseBodyResultGroupInfos> GroupInfos { get; set; }
            public class ListUserResourcesResponseBodyResultGroupInfos : TeaModel {
                [NameInMap("groupInfo")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultGroupInfosGroupInfo GroupInfo { get; set; }
                public class ListUserResourcesResponseBodyResultGroupInfosGroupInfo : TeaModel {
                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nameWithNamespace")]
                    [Validation(Required=false)]
                    public string NameWithNamespace { get; set; }

                    [NameInMap("ownerId")]
                    [Validation(Required=false)]
                    public long? OwnerId { get; set; }

                    [NameInMap("parentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("pathWithNamespace")]
                    [Validation(Required=false)]
                    public string PathWithNamespace { get; set; }

                    [NameInMap("updatedAt")]
                    [Validation(Required=false)]
                    public string UpdatedAt { get; set; }

                    [NameInMap("visibilityLevel")]
                    [Validation(Required=false)]
                    public int? VisibilityLevel { get; set; }

                }

                [NameInMap("groupRole")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultGroupInfosGroupRole GroupRole { get; set; }
                public class ListUserResourcesResponseBodyResultGroupInfosGroupRole : TeaModel {
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    [NameInMap("cnRoleName")]
                    [Validation(Required=false)]
                    public string CnRoleName { get; set; }

                    [NameInMap("enRoleName")]
                    [Validation(Required=false)]
                    public string EnRoleName { get; set; }

                    [NameInMap("sourceId")]
                    [Validation(Required=false)]
                    public long? SourceId { get; set; }

                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

            }

            [NameInMap("repositoryInfos")]
            [Validation(Required=false)]
            public List<ListUserResourcesResponseBodyResultRepositoryInfos> RepositoryInfos { get; set; }
            public class ListUserResourcesResponseBodyResultRepositoryInfos : TeaModel {
                [NameInMap("repositoryInfo")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultRepositoryInfosRepositoryInfo RepositoryInfo { get; set; }
                public class ListUserResourcesResponseBodyResultRepositoryInfosRepositoryInfo : TeaModel {
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    [NameInMap("archived")]
                    [Validation(Required=false)]
                    public bool? Archived { get; set; }

                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public long? CreatorId { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("lastActivityAt")]
                    [Validation(Required=false)]
                    public string LastActivityAt { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nameWithNamespace")]
                    [Validation(Required=false)]
                    public string NameWithNamespace { get; set; }

                    [NameInMap("namespaceId")]
                    [Validation(Required=false)]
                    public long? NamespaceId { get; set; }

                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("pathWithNamespace")]
                    [Validation(Required=false)]
                    public string PathWithNamespace { get; set; }

                    [NameInMap("updatedAt")]
                    [Validation(Required=false)]
                    public string UpdatedAt { get; set; }

                    [NameInMap("visibilityLevel")]
                    [Validation(Required=false)]
                    public int? VisibilityLevel { get; set; }

                }

                [NameInMap("repositoryRole")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultRepositoryInfosRepositoryRole RepositoryRole { get; set; }
                public class ListUserResourcesResponseBodyResultRepositoryInfosRepositoryRole : TeaModel {
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    [NameInMap("cnRoleName")]
                    [Validation(Required=false)]
                    public string CnRoleName { get; set; }

                    [NameInMap("enRoleName")]
                    [Validation(Required=false)]
                    public string EnRoleName { get; set; }

                    [NameInMap("sourceId")]
                    [Validation(Required=false)]
                    public long? SourceId { get; set; }

                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

            }

            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public ListUserResourcesResponseBodyResultUserInfo UserInfo { get; set; }
            public class ListUserResourcesResponseBodyResultUserInfo : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
