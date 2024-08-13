// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The information about the snapshot.
        /// </summary>
        [NameInMap("MediaSnapshot")]
        [Validation(Required=false)]
        public ListSnapshotsResponseBodyMediaSnapshot MediaSnapshot { get; set; }
        public class ListSnapshotsResponseBodyMediaSnapshot : TeaModel {
            /// <summary>
            /// The time when the snapshot job was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The ID of the snapshot job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The rule used to generate snapshot URLs.
            /// </summary>
            [NameInMap("Regular")]
            [Validation(Required=false)]
            public string Regular { get; set; }

            /// <summary>
            /// The details of the snapshot.
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public ListSnapshotsResponseBodyMediaSnapshotSnapshots Snapshots { get; set; }
            public class ListSnapshotsResponseBodyMediaSnapshotSnapshots : TeaModel {
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public List<ListSnapshotsResponseBodyMediaSnapshotSnapshotsSnapshot> Snapshot { get; set; }
                public class ListSnapshotsResponseBodyMediaSnapshotSnapshotsSnapshot : TeaModel {
                    /// <summary>
                    /// The index of the snapshot.
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public long? Index { get; set; }

                    /// <summary>
                    /// The URL of the snapshot.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// The total number of snapshots.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
