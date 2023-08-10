// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationObjectModifyStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of full data synchronization.
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if full data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of full data synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of records that have been synchronized during full data synchronization.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of full data synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Full data synchronization is not started.
            /// *   **Migrating**: Full data synchronization is in progress.
            /// *   **Failed**: Full data synchronization failed.
            /// *   **Finished**: Full data synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The status of incremental data synchronization.
        /// 
        /// >  This parameter and its sub-parameters will be removed in the future.
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// The synchronization latency, in seconds.
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// The error message returned if incremental data synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of incremental data synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The status of incremental data synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Incremental data synchronization is not started.
            /// *   **Migrating**: Incremental data synchronization is in progress.
            /// *   **Failed**: Incremental data synchronization failed.
            /// *   **Finished**: Incremental data synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// The error message returned if the task failed to modify the objects to be synchronized.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The precheck status.
        /// </summary>
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// The result of each precheck item.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail : TeaModel {
                /// <summary>
                /// The precheck result. Valid values:
                /// 
                /// *   Success: The task passed the precheck.
                /// *   Failed: The task failed to pass the precheck.
                /// </summary>
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                /// <summary>
                /// The error message returned if the task failed to pass the precheck.
                /// 
                /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is **Failed**.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// The name of the precheck item.
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// The method to fix the precheck failure.
                /// 
                /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is Failed.
                /// </summary>
                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

            }

            /// <summary>
            /// The precheck progress. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The precheck status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the task that changes the objects to be synchronized. Valid values:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **Migrating**: The task is running.
        /// *   **Failed**: The task failed.
        /// *   **Finished**: The task is completed.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The status of schema synchronization.
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if schema synchronization failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of schema synchronization. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of tables whose schemas have been synchronized.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of schema synchronization. Valid values:
            /// 
            /// *   **NotStarted**: Schema synchronization is not started.
            /// *   **Migrating**: Schema synchronization is in progress.
            /// *   **Failed**: Schema synchronization failed.
            /// *   **Finished**: Schema synchronization is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
