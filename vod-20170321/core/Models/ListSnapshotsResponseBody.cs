// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the snapshot.</para>
        /// </summary>
        [NameInMap("MediaSnapshot")]
        [Validation(Required=false)]
        public ListSnapshotsResponseBodyMediaSnapshot MediaSnapshot { get; set; }
        public class ListSnapshotsResponseBodyMediaSnapshot : TeaModel {
            /// <summary>
            /// <para>The time when the snapshot job was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-20T12:23:45Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad90a501b1b9472374ad005046****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The rule used to generate snapshot URLs.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/snapshot/sample%7BSnapshotCount%7D.jpg">http://example.aliyundoc.com/snapshot/sample{SnapshotCount}.jpg</a></para>
            /// </summary>
            [NameInMap("Regular")]
            [Validation(Required=false)]
            public string Regular { get; set; }

            /// <summary>
            /// <para>The details of the snapshot.</para>
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
                    /// <para>The index of the snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public long? Index { get; set; }

                    /// <summary>
                    /// <para>The URL of the snapshot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example.aliyundoc.com/snapshot/sample00001****.jpg">http://example.aliyundoc.com/snapshot/sample00001****.jpg</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            /// <summary>
            /// <para>The total number of snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
