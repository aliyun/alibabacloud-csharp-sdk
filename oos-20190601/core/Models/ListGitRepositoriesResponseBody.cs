// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitRepositoriesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GitRepos")]
        [Validation(Required=false)]
        public List<ListGitRepositoriesResponseBodyGitRepos> GitRepos { get; set; }
        public class ListGitRepositoriesResponseBodyGitRepos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Test secret parameter for vulnerability testing - 1757298077.453695</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun/repo</para>
            /// </summary>
            [NameInMap("FullName")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://github.com/alibaba/fastjson">https://github.com/alibaba/fastjson</a></para>
            /// </summary>
            [NameInMap("HtmlUrl")]
            [Validation(Required=false)]
            public string HtmlUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("IsPrivate")]
            [Validation(Required=false)]
            public bool? IsPrivate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22351123</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public long? RepoId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DBA6E6C8-F75D-41DE-AFF5-1FA03F551CA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
