// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The URL of the snapshot.
        /// </summary>
        [NameInMap("MediaSnapshot")]
        [Validation(Required=false)]
        public ListSnapshotsResponseBodyMediaSnapshot MediaSnapshot { get; set; }
        public class ListSnapshotsResponseBodyMediaSnapshot : TeaModel {
            /// <summary>
            /// The ID of the snapshot job.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// Queries the snapshots that are captured from the specified media.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Regular")]
            [Validation(Required=false)]
            public string Regular { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public ListSnapshotsResponseBodyMediaSnapshotSnapshots Snapshots { get; set; }
            public class ListSnapshotsResponseBodyMediaSnapshotSnapshots : TeaModel {
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public List<ListSnapshotsResponseBodyMediaSnapshotSnapshotsSnapshot> Snapshot { get; set; }
                public class ListSnapshotsResponseBodyMediaSnapshotSnapshotsSnapshot : TeaModel {
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public long? Index { get; set; }

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
        /// The snapshot data of the media.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
