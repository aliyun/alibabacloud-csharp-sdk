// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("repository")]
        [Validation(Required=false)]
        public GetRepositoryResponseBodyRepository Repository { get; set; }
        public class GetRepositoryResponseBodyRepository : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-19T04:02:00.744Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19258</para>
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
            [NameInMap("demoProjectStatus")]
            [Validation(Required=false)]
            public bool? DemoProjectStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>repo desc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://codeup.aliyun.com/xxx/test/test.git">https://codeup.aliyun.com/xxx/test/test.git</a></para>
            /// </summary>
            [NameInMap("httpUrlToRepository")]
            [Validation(Required=false)]
            public string HttpUrlToRepository { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-19T04:02:00.744Z</para>
            /// </summary>
            [NameInMap("lastActivityAt")]
            [Validation(Required=false)]
            public string LastActivityAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test / test</para>
            /// </summary>
            [NameInMap("nameWithNamespace")]
            [Validation(Required=false)]
            public string NameWithNamespace { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public GetRepositoryResponseBodyRepositoryNamespace Namespace { get; set; }
            public class GetRepositoryResponseBodyRepositoryNamespace : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxx.jpg">https://xxx.jpg</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-06-19T04:02:00.744Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>repo desc</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ownerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-06-19T04:02:00.744Z</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test/test</para>
            /// </summary>
            [NameInMap("pathWithNamespace")]
            [Validation(Required=false)]
            public string PathWithNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:git@codeup.aliyun.com">git@codeup.aliyun.com</a>:xxx/test/test.git</para>
            /// </summary>
            [NameInMap("sshUrlToRepository")]
            [Validation(Required=false)]
            public string SshUrlToRepository { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("visibilityLevel")]
            [Validation(Required=false)]
            public int? VisibilityLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://codeup.aliyun.com/xxx/test/test">https://codeup.aliyun.com/xxx/test/test</a></para>
            /// </summary>
            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>37294673-00CA-5B8B-914F-A8B35511E90A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
