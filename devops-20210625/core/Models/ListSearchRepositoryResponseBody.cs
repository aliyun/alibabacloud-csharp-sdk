// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSearchRepositoryResponseBodyResult> Result { get; set; }
        public class ListSearchRepositoryResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60d54f3daccf2bbd6659f3ad/gitlabhq/master/config/environments/test.rb</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public ListSearchRepositoryResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class ListSearchRepositoryResponseBodyResultHighlightTextMap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("creatorUserId")]
                [Validation(Required=false)]
                public string CreatorUserId { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60de7a6852743a5162b5f957</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("readMe")]
                [Validation(Required=false)]
                public string ReadMe { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup/test-repo</para>
                /// </summary>
                [NameInMap("repoNameWithNamespace")]
                [Validation(Required=false)]
                public string RepoNameWithNamespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup/test-repo</para>
                /// </summary>
                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public ListSearchRepositoryResponseBodyResultSource Source { get; set; }
            public class ListSearchRepositoryResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-10 10:10:10</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-11-11 11:11:11</para>
                /// </summary>
                [NameInMap("lastActivityTime")]
                [Validation(Required=false)]
                public string LastActivityTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>62a94a8611fc0f0c9e2a7bc1</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("readMe")]
                [Validation(Required=false)]
                public string ReadMe { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-repo</para>
                /// </summary>
                [NameInMap("repoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup/test-repo</para>
                /// </summary>
                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("visibilityLevel")]
                [Validation(Required=false)]
                public int? VisibilityLevel { get; set; }

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
        /// <para>30</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
