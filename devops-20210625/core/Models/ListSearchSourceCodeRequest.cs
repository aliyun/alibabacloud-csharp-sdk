// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchSourceCodeRequest : TeaModel {
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public ListSearchSourceCodeRequestFilePath FilePath { get; set; }
        public class ListSearchSourceCodeRequestFilePath : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>term</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>equal</para>
            /// </summary>
            [NameInMap("operatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>orgId/test-group/spring-boot-demo/test.java</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isCodeBlock")]
        [Validation(Required=false)]
        public bool? IsCodeBlock { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Java</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("repoPath")]
        [Validation(Required=false)]
        public ListSearchSourceCodeRequestRepoPath RepoPath { get; set; }
        public class ListSearchSourceCodeRequestRepoPath : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>term</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>equal</para>
            /// </summary>
            [NameInMap("operatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66c0c9fffeb86b450c199fcd</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
