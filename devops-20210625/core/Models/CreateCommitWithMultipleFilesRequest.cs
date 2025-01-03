// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommitWithMultipleFilesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actions")]
        [Validation(Required=false)]
        public List<CreateCommitWithMultipleFilesRequestActions> Actions { get; set; }
        public class CreateCommitWithMultipleFilesRequestActions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>create</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>src/test.java</para>
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>src/main/test.java</para>
            /// </summary>
            [NameInMap("previousPath")]
            [Validation(Required=false)]
            public string PreviousPath { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("commitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ebbc0228123212b59xxxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

    }

}
