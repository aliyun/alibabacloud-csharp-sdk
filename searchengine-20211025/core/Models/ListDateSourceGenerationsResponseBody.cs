// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDateSourceGenerationsResponseBodyResult> Result { get; set; }
        public class ListDateSourceGenerationsResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the offline deployment.
            /// </summary>
            [NameInMap("buildDeployId")]
            [Validation(Required=false)]
            public int? BuildDeployId { get; set; }

            /// <summary>
            /// The timestamp that was generated when the index building was started.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The path of the dumped index in the Apsara File Storage for HDFS file system.
            /// </summary>
            [NameInMap("dataDumpRoot")]
            [Validation(Required=false)]
            public string DataDumpRoot { get; set; }

            /// <summary>
            /// The ID of the full index version.
            /// </summary>
            [NameInMap("generation")]
            [Validation(Required=false)]
            public long? Generation { get; set; }

            /// <summary>
            /// The shards of the index version. The value is a key-value pair in which the key indicates the index name and the value indicates the number of shards. The number of value shards.
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public Dictionary<string, int?> Partition { get; set; }

            /// <summary>
            /// The status of the index version.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The start timestamp from which incremental data is retrieved.
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
