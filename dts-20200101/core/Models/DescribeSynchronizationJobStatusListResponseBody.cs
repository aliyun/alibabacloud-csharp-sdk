// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusListResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of data synchronization instances displayed on one page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The status of the data synchronization tasks.
        /// </summary>
        [NameInMap("SynchronizationJobListStatusList")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList> SynchronizationJobListStatusList { get; set; }
        public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusList : TeaModel {
            /// <summary>
            /// The details of data synchronization tasks in each direction.
            /// </summary>
            [NameInMap("SynchronizationDirectionInfoList")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList> SynchronizationDirectionInfoList { get; set; }
            public class DescribeSynchronizationJobStatusListResponseBodySynchronizationJobListStatusListSynchronizationDirectionInfoList : TeaModel {
                /// <summary>
                /// The UNIX timestamp generated when the latest data record was synchronized.
                /// 
                /// >  You can use a search engine to obtain a UNIX timestamp converter.
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// The status of the data synchronization task in this direction. Valid values:
                /// 
                /// *   **NotStarted**: The task is not started.
                /// *   **Prechecking**: The task is being prechecked.
                /// *   **PrecheckFailed**: The task failed to pass the precheck.
                /// *   **Initializing**: The task is performing initial synchronization.
                /// *   **InitializeFailed**: Initial synchronization failed.
                /// *   **Synchronizing**: The task is synchronizing data.
                /// *   **Failed**: The task failed to synchronize data.
                /// *   **Suspending**: The task is paused.
                /// *   **Modifying**: The objects in the task are being modified.
                /// *   **Finished**: The task is completed.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The synchronization direction. Valid values:
                /// 
                /// *   **Forward**
                /// *   **Reverse**
                /// </summary>
                [NameInMap("SynchronizationDirection")]
                [Validation(Required=false)]
                public string SynchronizationDirection { get; set; }

            }

            /// <summary>
            /// The ID of the data synchronization instance.
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

        }

        /// <summary>
        /// The total number of data synchronization instances.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
