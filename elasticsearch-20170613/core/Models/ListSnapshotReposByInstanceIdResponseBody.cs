// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSnapshotReposByInstanceIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSnapshotReposByInstanceIdResponseBodyResult> Result { get; set; }
        public class ListSnapshotReposByInstanceIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The referenced instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-6ja1ro4jt000c****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The repository address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-6ja1ro4jt000c****</para>
            /// </summary>
            [NameInMap("repoPath")]
            [Validation(Required=false)]
            public string RepoPath { get; set; }

            /// <summary>
            /// <para>The name of the referenced repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_snapshot_from_es-cn-6ja1ro4jt000c****</para>
            /// </summary>
            [NameInMap("snapWarehouse")]
            [Validation(Required=false)]
            public string SnapWarehouse { get; set; }

            /// <summary>
            /// <para>The status of the referenced repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>available: The repository is active.</description></item>
            /// <item><description>unavailable: The repository is inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
