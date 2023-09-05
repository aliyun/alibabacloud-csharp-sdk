// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskEventsResponseBody : TeaModel {
        /// <summary>
        /// The risk events of the disk.
        /// </summary>
        [NameInMap("DiskEvents")]
        [Validation(Required=false)]
        public List<DescribeDiskEventsResponseBodyDiskEvents> DiskEvents { get; set; }
        public class DescribeDiskEventsResponseBodyDiskEvents : TeaModel {
            /// <summary>
            /// The description of the event.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the disk.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// The recommended action after the event occurred. Valid values:
            /// 
            /// *   Resize: resizes the disk.
            /// *   ModifyDiskSpec: changes the category of the disk.
            /// *   NoAction: performs no operation.
            /// </summary>
            [NameInMap("RecommendAction")]
            [Validation(Required=false)]
            public string RecommendAction { get; set; }

            /// <summary>
            /// The region ID of the disk.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The state of the event. Valid values:
            /// 
            /// *   Solved
            /// *   UnSolved
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the event occurred. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// The type of the event. Only DataNeedProtect can be returned.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
