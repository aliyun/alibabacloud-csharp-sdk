// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QuerySnapshotJobListRequest : TeaModel {
        /// <summary>
        /// The snapshot configuration.
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// The ID of the MPS queue to which the snapshot jobs that you want to query are submitted. To obtain the ID, you can log on to the **MPS console** and choose **Global Settings** > **Pipelines** in the left-side navigation pane.
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// The end of the time range within which the creation time of snapshot jobs to be queried is.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the
        /// *   YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The start time for taking snapshots. Unit: milliseconds.
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range within which the creation time of snapshot jobs to be queried is.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the
        /// *   YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("SnapshotJobIds")]
        [Validation(Required=false)]
        public string SnapshotJobIds { get; set; }

        /// <summary>
        /// The time when the job was created.
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// The information about the snapshot jobs.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
