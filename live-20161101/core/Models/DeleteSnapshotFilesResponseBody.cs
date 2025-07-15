// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteSnapshotFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of snapshots that failed to be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailureCount")]
        [Validation(Required=false)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90F60327-ABEC-5A93-BF1F-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the snapshots.</para>
        /// </summary>
        [NameInMap("SnapshotDeleteInfoList")]
        [Validation(Required=false)]
        public DeleteSnapshotFilesResponseBodySnapshotDeleteInfoList SnapshotDeleteInfoList { get; set; }
        public class DeleteSnapshotFilesResponseBodySnapshotDeleteInfoList : TeaModel {
            [NameInMap("SnapshotDeleteInfo")]
            [Validation(Required=false)]
            public List<DeleteSnapshotFilesResponseBodySnapshotDeleteInfoListSnapshotDeleteInfo> SnapshotDeleteInfo { get; set; }
            public class DeleteSnapshotFilesResponseBodySnapshotDeleteInfoListSnapshotDeleteInfo : TeaModel {
                /// <summary>
                /// <para>The timestamp when the snapshot was captured. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1653641526637</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The processing result of the snapshot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The snapshot was deleted.</description></item>
                /// <item><description><b>FileNotFound</b>: The snapshot was not found.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of successful screenshot deletions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

    }

}
