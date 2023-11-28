// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListShardRecoveriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListShardRecoveriesResponseBodyResult> Result { get; set; }
        public class ListShardRecoveriesResponseBodyResult : TeaModel {
            /// <summary>
            /// The data restoration progress.
            /// </summary>
            [NameInMap("bytesPercent")]
            [Validation(Required=false)]
            public string BytesPercent { get; set; }

            /// <summary>
            /// The total amount of data that is restored.
            /// </summary>
            [NameInMap("bytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// The file execution progress.
            /// </summary>
            [NameInMap("filesPercent")]
            [Validation(Required=false)]
            public string FilesPercent { get; set; }

            /// <summary>
            /// The total number of files.
            /// </summary>
            [NameInMap("filesTotal")]
            [Validation(Required=false)]
            public long? FilesTotal { get; set; }

            /// <summary>
            /// The name of the index.
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public string Index { get; set; }

            /// <summary>
            /// The IP address of the source node.
            /// </summary>
            [NameInMap("sourceHost")]
            [Validation(Required=false)]
            public string SourceHost { get; set; }

            /// <summary>
            /// The name of the source node.
            /// </summary>
            [NameInMap("sourceNode")]
            [Validation(Required=false)]
            public string SourceNode { get; set; }

            /// <summary>
            /// The data restoration status. Valid values:
            /// 
            /// *   done: Data restoration is complete.
            /// *   finalize: Data is being cleared.
            /// *   index: Index metadata is being read, and bytes are being copied from source to destination.
            /// *   init: Data restoration is not started.
            /// *   start: Data restoration is started.
            /// *   translog: Translogs are being redone.
            /// </summary>
            [NameInMap("stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// The IP address of the destination node.
            /// </summary>
            [NameInMap("targetHost")]
            [Validation(Required=false)]
            public string TargetHost { get; set; }

            /// <summary>
            /// The name of the destination node.
            /// </summary>
            [NameInMap("targetNode")]
            [Validation(Required=false)]
            public string TargetNode { get; set; }

            /// <summary>
            /// The number of translog operations to be restored.
            /// </summary>
            [NameInMap("translogOps")]
            [Validation(Required=false)]
            public long? TranslogOps { get; set; }

            /// <summary>
            /// The restoration progress of translog operations.
            /// </summary>
            [NameInMap("translogOpsPercent")]
            [Validation(Required=false)]
            public string TranslogOpsPercent { get; set; }

        }

    }

}
