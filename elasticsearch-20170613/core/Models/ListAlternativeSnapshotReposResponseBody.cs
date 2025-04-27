// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAlternativeSnapshotReposResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAlternativeSnapshotReposResponseBodyResult> Result { get; set; }
        public class ListAlternativeSnapshotReposResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-6ja1ro4jt000c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The address of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RepoPath</para>
            /// </summary>
            [NameInMap("repoPath")]
            [Validation(Required=false)]
            public string RepoPath { get; set; }

        }

    }

}
