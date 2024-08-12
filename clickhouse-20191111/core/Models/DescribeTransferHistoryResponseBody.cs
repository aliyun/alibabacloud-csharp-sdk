// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeTransferHistoryResponseBody : TeaModel {
        /// <summary>
        /// The migration information.
        /// </summary>
        [NameInMap("HistoryDetails")]
        [Validation(Required=false)]
        public DescribeTransferHistoryResponseBodyHistoryDetails HistoryDetails { get; set; }
        public class DescribeTransferHistoryResponseBodyHistoryDetails : TeaModel {
            [NameInMap("HistoryDetail")]
            [Validation(Required=false)]
            public List<DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail> HistoryDetail { get; set; }
            public class DescribeTransferHistoryResponseBodyHistoryDetailsHistoryDetail : TeaModel {
                [NameInMap("DisableWriteWindows")]
                [Validation(Required=false)]
                public string DisableWriteWindows { get; set; }

                /// <summary>
                /// The progress of the data migration.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                [NameInMap("SourceControlVersion")]
                [Validation(Required=false)]
                public string SourceControlVersion { get; set; }

                /// <summary>
                /// The ID of the source cluster.
                /// </summary>
                [NameInMap("SourceDBCluster")]
                [Validation(Required=false)]
                public string SourceDBCluster { get; set; }

                /// <summary>
                /// The status of the data migration task. Valid values:
                /// 
                /// *   **Finished**: The data migration task is complete.
                /// *   **Processing**: The data migration task is in progress.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TargetControlVersion")]
                [Validation(Required=false)]
                public string TargetControlVersion { get; set; }

                /// <summary>
                /// The ID of the destination cluster.
                /// </summary>
                [NameInMap("TargetDBCluster")]
                [Validation(Required=false)]
                public string TargetDBCluster { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
