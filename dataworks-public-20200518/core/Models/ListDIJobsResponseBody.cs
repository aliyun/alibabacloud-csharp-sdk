// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIJobsResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("DIJobPaging")]
        [Validation(Required=false)]
        public ListDIJobsResponseBodyDIJobPaging DIJobPaging { get; set; }
        public class ListDIJobsResponseBodyDIJobPaging : TeaModel {
            /// <summary>
            /// The list of tasks.
            /// </summary>
            [NameInMap("DIJobs")]
            [Validation(Required=false)]
            public List<ListDIJobsResponseBodyDIJobPagingDIJobs> DIJobs { get; set; }
            public class ListDIJobsResponseBodyDIJobPagingDIJobs : TeaModel {
                /// <summary>
                /// The task ID.
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                public long? DIJobId { get; set; }

                /// <summary>
                /// The type of the destination. The value Hologres is returned.
                /// </summary>
                [NameInMap("DestinationDataSourceType")]
                [Validation(Required=false)]
                public string DestinationDataSourceType { get; set; }

                /// <summary>
                /// The task name.
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// The task status. Valid values:
                /// 
                /// *   Finished
                /// *   Initialized
                /// *   Stopped
                /// *   Failed
                /// *   Running
                /// *   Stopping
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// The synchronization type. Valid values:
                /// 
                /// *   FullAndRealtimeIncremental: one-time full synchronization and real-time incremental synchronization
                /// *   RealtimeIncremental: real-time incremental synchronization
                /// *   Full: one-time full synchronization
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// The workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// The type of the source. The value MySQL is returned.
                /// </summary>
                [NameInMap("SourceDataSourceType")]
                [Validation(Required=false)]
                public string SourceDataSourceType { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
