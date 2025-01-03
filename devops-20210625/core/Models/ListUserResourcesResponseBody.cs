// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListUserResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A35869D5-BB29-5F84-A4DD-B09985EA2AFA</para>
        /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-01-14T21:08:26+08:00</para>
                    /// </summary>
                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-group</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>35268</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-group</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nameWithNamespace")]
                    [Validation(Required=false)]
                    public string NameWithNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234</para>
                    /// </summary>
                    [NameInMap("ownerId")]
                    [Validation(Required=false)]
                    public long? OwnerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1183319</para>
                    /// </summary>
                    [NameInMap("parentId")]
                    [Validation(Required=false)]
                    public long? ParentId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-group</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-org/test-group</para>
                    /// </summary>
                    [NameInMap("pathWithNamespace")]
                    [Validation(Required=false)]
                    public string PathWithNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-01-14T21:08:26+08:00</para>
                    /// </summary>
                    [NameInMap("updatedAt")]
                    [Validation(Required=false)]
                    public string UpdatedAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("visibilityLevel")]
                    [Validation(Required=false)]
                    public int? VisibilityLevel { get; set; }

                }

                [NameInMap("groupRole")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultGroupInfosGroupRole GroupRole { get; set; }
                public class ListUserResourcesResponseBodyResultGroupInfosGroupRole : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    [NameInMap("cnRoleName")]
                    [Validation(Required=false)]
                    public string CnRoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("enRoleName")]
                    [Validation(Required=false)]
                    public string EnRoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>35268</para>
                    /// </summary>
                    [NameInMap("sourceId")]
                    [Validation(Required=false)]
                    public long? SourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Namespace</para>
                    /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("archived")]
                    [Validation(Required=false)]
                    public bool? Archived { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-01-14T21:08:26+08:00</para>
                    /// </summary>
                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12679</para>
                    /// </summary>
                    [NameInMap("creatorId")]
                    [Validation(Required=false)]
                    public long? CreatorId { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("encrypted")]
                    [Validation(Required=false)]
                    public bool? Encrypted { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>37229</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-01-14T21:08:26+08:00</para>
                    /// </summary>
                    [NameInMap("lastActivityAt")]
                    [Validation(Required=false)]
                    public string LastActivityAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-repo</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nameWithNamespace")]
                    [Validation(Required=false)]
                    public string NameWithNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>600002</para>
                    /// </summary>
                    [NameInMap("namespaceId")]
                    [Validation(Required=false)]
                    public long? NamespaceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-repo</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-org/test-group/test-repo</para>
                    /// </summary>
                    [NameInMap("pathWithNamespace")]
                    [Validation(Required=false)]
                    public string PathWithNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-01-14T21:08:26+08:00</para>
                    /// </summary>
                    [NameInMap("updatedAt")]
                    [Validation(Required=false)]
                    public string UpdatedAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("visibilityLevel")]
                    [Validation(Required=false)]
                    public int? VisibilityLevel { get; set; }

                }

                [NameInMap("repositoryRole")]
                [Validation(Required=false)]
                public ListUserResourcesResponseBodyResultRepositoryInfosRepositoryRole RepositoryRole { get; set; }
                public class ListUserResourcesResponseBodyResultRepositoryInfosRepositoryRole : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("accessLevel")]
                    [Validation(Required=false)]
                    public int? AccessLevel { get; set; }

                    [NameInMap("cnRoleName")]
                    [Validation(Required=false)]
                    public string CnRoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("enRoleName")]
                    [Validation(Required=false)]
                    public string EnRoleName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>37229</para>
                    /// </summary>
                    [NameInMap("sourceId")]
                    [Validation(Required=false)]
                    public long? SourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Project</para>
                    /// </summary>
                    [NameInMap("sourceType")]
                    [Validation(Required=false)]
                    public string SourceType { get; set; }

                }

            }

            [NameInMap("userInfo")]
            [Validation(Required=false)]
            public ListUserResourcesResponseBodyResultUserInfo UserInfo { get; set; }
            public class ListUserResourcesResponseBodyResultUserInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19230</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
