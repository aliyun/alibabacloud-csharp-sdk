// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNAUTHORIZED_ERROR</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F590C9D8-E908-5B6C-95AC-56B7E8011FFA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateRepositoryResponseBodyResult Result { get; set; }
        public class CreateRepositoryResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Import_from_svn")]
            [Validation(Required=false)]
            public bool? ImportFromSvn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("archived")]
            [Validation(Required=false)]
            public bool? Archived { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("avatar_url")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-14T21:08:26+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1233</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("defaultBranch")]
            [Validation(Required=false)]
            public string DefaultBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("demoProject")]
            [Validation(Required=false)]
            public bool? DemoProject { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("httpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>2959</para>
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
            /// <para>codeupTest</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>codeup-test-org / test-codeup</para>
            /// </summary>
            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public CreateRepositoryResponseBodyResultNamespace Namespace { get; set; }
            public class CreateRepositoryResponseBodyResultNamespace : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-01-14T21:08:26+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup repo description</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>3194</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("public")]
                [Validation(Required=false)]
                public bool? Public { get; set; }

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
                public string VisibilityLevel { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-codeup</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>codeup-test-org/test-codeup</para>
            /// </summary>
            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("sshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public string VisibilityLevel { get; set; }

            /// <summary>
            /// <para>web url</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
