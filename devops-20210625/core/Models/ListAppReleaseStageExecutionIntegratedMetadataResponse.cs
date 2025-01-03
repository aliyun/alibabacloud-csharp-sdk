// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListAppReleaseStageExecutionIntegratedMetadataResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAppReleaseStageExecutionIntegratedMetadataResponseBody> Body { get; set; }
        public class ListAppReleaseStageExecutionIntegratedMetadataResponseBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>release/20240625-152603220321211_release_3252057_1</para>
            /// </summary>
            [NameInMap("releaseBranch")]
            [Validation(Required=false)]
            public string ReleaseBranch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a66cfa8c6869b96bb7d111ba2144c9c764d556b7</para>
            /// </summary>
            [NameInMap("releaseRevision")]
            [Validation(Required=false)]
            public string ReleaseRevision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://codeup.aliyun.com/60d54f3daccf2bbd6659f3ad/auto-test.git">https://codeup.aliyun.com/60d54f3daccf2bbd6659f3ad/auto-test.git</a></para>
            /// </summary>
            [NameInMap("repoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CODEUP</para>
            /// </summary>
            [NameInMap("repoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            [NameInMap("changeRequests")]
            [Validation(Required=false)]
            public List<ListAppReleaseStageExecutionIntegratedMetadataResponseBodyChangeRequests> ChangeRequests { get; set; }
            public class ListAppReleaseStageExecutionIntegratedMetadataResponseBodyChangeRequests : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>fcd37726a6f84c60b7eb9c5856007c2f</para>
                /// </summary>
                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>feature/20240625</para>
                /// </summary>
                [NameInMap("branchName")]
                [Validation(Required=false)]
                public string BranchName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a66cfa8c6869b96bb7d111ba2144c9c764d556b7</para>
                /// </summary>
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>262579140573491041</para>
                /// </summary>
                [NameInMap("ownerAccountId")]
                [Validation(Required=false)]
                public string OwnerAccountId { get; set; }

            }

        }

    }

}
