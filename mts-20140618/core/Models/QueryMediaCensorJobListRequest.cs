// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaCensorJobListRequest : TeaModel {
        /// <summary>
        /// The end of the time range within which the jobs to be queried were created.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.
        /// *   The time must be in UTC.
        /// </summary>
        [NameInMap("EndOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string EndOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// The ID of the content moderation job. You can call the [SubmitMediaCensorJob](https://help.aliyun.com/document_detail/91779.html) operation to query the ID of the content moderation job. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// 
        /// *   Default value: **30**.
        /// *   Valid values: **1 to 300**.
        /// </summary>
        [NameInMap("MaximumPageSize")]
        [Validation(Required=false)]
        public long? MaximumPageSize { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.
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
        /// The ID of the ApsaraVideo Media Processing (MPS) queue that is used to run the job. To obtain the ID of the MPS queue, perform the following steps: Log on to the [**MPS console**](https://mps.console.aliyun.com/overview). In the left-side navigation pane, choose **Global Settings** > **Pipelines**.
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
        /// The beginning of the time range within which the jobs to be queried were created.
        /// 
        /// *   Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.
        /// *   The time must be in UTC.
        /// </summary>
        [NameInMap("StartOfJobCreatedTimeRange")]
        [Validation(Required=false)]
        public string StartOfJobCreatedTimeRange { get; set; }

        /// <summary>
        /// The status of the jobs to be queried. Valid values:
        /// 
        /// *   **All**: all jobs.
        /// *   **Queuing**: the jobs that are being queued.
        /// *   **Analysing**: the jobs that are in progress.
        /// *   **Fail**: failed jobs.
        /// *   **Success**: successful jobs.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
