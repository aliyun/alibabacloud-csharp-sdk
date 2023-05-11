// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryOTAJobResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The update batch information returned if the call is successful. For more information, see the following parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOTAJobResponseBodyData Data { get; set; }
        public class QueryOTAJobResponseBodyData : TeaModel {
            /// <summary>
            /// The destination firmware version of the update.
            /// </summary>
            [NameInMap("DestVersion")]
            [Validation(Required=false)]
            public string DestVersion { get; set; }

            /// <summary>
            /// The download protocol of the update package.
            /// </summary>
            [NameInMap("DownloadProtocol")]
            [Validation(Required=false)]
            public string DownloadProtocol { get; set; }

            /// <summary>
            /// The mode of dynamic update. Valid values:
            /// 
            /// *   **1**: constantly updates the devices that meet the conditions.
            /// *   **2**: updates only the devices that subsequently submit the latest firmware versions.
            /// 
            /// This parameter is returned only if you perform a dynamic update.
            /// </summary>
            [NameInMap("DynamicMode")]
            [Validation(Required=false)]
            public int? DynamicMode { get; set; }

            /// <summary>
            /// The ID of the update package.
            /// </summary>
            [NameInMap("FirmwareId")]
            [Validation(Required=false)]
            public string FirmwareId { get; set; }

            /// <summary>
            /// The phase ratio of the phased update.
            /// 
            /// This parameter is returned only if you perform a phased update.
            /// </summary>
            [NameInMap("GrayPercent")]
            [Validation(Required=false)]
            public string GrayPercent { get; set; }

            /// <summary>
            /// The ID of the device group to be updated.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the device group to be updated.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The description of the update batch.
            /// </summary>
            [NameInMap("JobDesc")]
            [Validation(Required=false)]
            public string JobDesc { get; set; }

            /// <summary>
            /// The ID of the update batch.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The status of the update batch.
            /// 
            /// *   **PLANNED**: The update batch is being planned. The batch is created, but the scheduled time has not arrived. This parameter is returned only if you perform a static update.
            /// *   **IN_PROGRESS**: The update batch is running.
            /// *   **COMPLETED**: The update batch is completed.
            /// *   **CANCELED**: The update batch is canceled.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The type of the batch. Valid values:
            /// 
            /// *   **VERFIY_FIRMWARE**: update package verification.
            /// *   **UPGRADE_FIRMWARE**: batch update.
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// The maximum number of devices to which the download URL of the update package is pushed per minute.
            /// </summary>
            [NameInMap("MaximumPerMinute")]
            [Validation(Required=false)]
            public int? MaximumPerMinute { get; set; }

            /// <summary>
            /// Specifies whether the device supports simultaneous updates of multiple modules.
            /// 
            /// *   **false** (default): no.
            /// *   **true**: yes.
            /// 
            /// For more information, see [Overview](~~58328~~).
            /// </summary>
            [NameInMap("MultiModuleMode")]
            [Validation(Required=false)]
            public bool? MultiModuleMode { get; set; }

            /// <summary>
            /// The name of the update package.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Specifies whether to confirm the update by using your mobile app.
            /// </summary>
            [NameInMap("NeedConfirm")]
            [Validation(Required=false)]
            public bool? NeedConfirm { get; set; }

            /// <summary>
            /// Specifies whether to automatically push update tasks from IoT Platform to devices.
            /// </summary>
            [NameInMap("NeedPush")]
            [Validation(Required=false)]
            public bool? NeedPush { get; set; }

            /// <summary>
            /// Specifies whether to overwrite the previous update task. Valid values:
            /// 
            /// *   **1**: The previous update task is not overwritten. If a device already has an update task, the previous update task is implemented.
            /// *   **2**: The previous update task is overwritten. Only the current update task is implemented.
            /// 
            /// The update task that is in progress is not overwritten.
            /// </summary>
            [NameInMap("OverwriteMode")]
            [Validation(Required=false)]
            public int? OverwriteMode { get; set; }

            /// <summary>
            /// The ProductKey of the product to which the update package belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The number of automatic retries after a device fails to be updated.
            /// 
            /// This parameter is returned if a retry policy is set when you create the update batch.
            /// </summary>
            [NameInMap("RetryCount")]
            [Validation(Required=false)]
            public int? RetryCount { get; set; }

            /// <summary>
            /// The automatic retry interval after a device fails to be updated. Unit: minutes.
            /// 
            /// This parameter is returned if a retry policy is set when you create the update batch.
            /// </summary>
            [NameInMap("RetryInterval")]
            [Validation(Required=false)]
            public int? RetryInterval { get; set; }

            /// <summary>
            /// The update policy of the update batch. Valid values:
            /// 
            /// *   **DYNAMIC**: dynamic update. This value is returned if you call the [CreateOTADynamicUpgradeJob](~~147887~~) API operation to create an update batch.
            /// *   **STATIC**: static update. This value is returned if you call the [CreateOTAStaticUpgradeJob](~~147496~~) API operation to create an update batch.
            /// </summary>
            [NameInMap("SelectionType")]
            [Validation(Required=false)]
            public string SelectionType { get; set; }

            /// <summary>
            /// The list of firmware versions to be updated.
            /// </summary>
            [NameInMap("SrcVersions")]
            [Validation(Required=false)]
            public QueryOTAJobResponseBodyDataSrcVersions SrcVersions { get; set; }
            public class QueryOTAJobResponseBodyDataSrcVersions : TeaModel {
                [NameInMap("SrcVersion")]
                [Validation(Required=false)]
                public List<string> SrcVersion { get; set; }

            }

            /// <summary>
            /// The tags of the update batch.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public QueryOTAJobResponseBodyDataTags Tags { get; set; }
            public class QueryOTAJobResponseBodyDataTags : TeaModel {
                [NameInMap("OtaTagDTO")]
                [Validation(Required=false)]
                public List<QueryOTAJobResponseBodyDataTagsOtaTagDTO> OtaTagDTO { get; set; }
                public class QueryOTAJobResponseBodyDataTagsOtaTagDTO : TeaModel {
                    /// <summary>
                    /// The key of each tag.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the tag.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The scope of the update batch. Valid values: 
            /// 
            /// - **ALL**: updates all devices.
            /// - **SPECIFIC**: updates specified devices.
            /// - **GRAY**: performs a phased update.
            /// 
            /// >  The value ALL is returned if you call the [CreateOTADynamicUpgradeJob](/help/en/iot-platform/latest/av6dui) API operation to create an update batch.
            /// </summary>
            [NameInMap("TargetSelection")]
            [Validation(Required=false)]
            public string TargetSelection { get; set; }

            /// <summary>
            /// The timeout period of the device update. Unit: minutes.
            /// 
            /// This parameter is returned if the timeout period is set when you create the update batch.
            /// </summary>
            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

            /// <summary>
            /// The time when the update batch was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            /// <summary>
            /// The end time of the update batch. The time is displayed in UTC.
            /// 
            /// This parameter is returned only after the update batch is completed.
            /// </summary>
            [NameInMap("UtcEndTime")]
            [Validation(Required=false)]
            public string UtcEndTime { get; set; }

            /// <summary>
            /// The time when the update batch was last modified. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            /// <summary>
            /// The end time of the scheduled update batch. This parameter is returned only if the update batch is scheduled and the end time of the scheduled update batch is specified.
            /// </summary>
            [NameInMap("UtcScheduleFinishTime")]
            [Validation(Required=false)]
            public string UtcScheduleFinishTime { get; set; }

            /// <summary>
            /// The start time of the scheduled update batch. This parameter is returned only for scheduled update batches.
            /// </summary>
            [NameInMap("UtcScheduleTime")]
            [Validation(Required=false)]
            public string UtcScheduleTime { get; set; }

            /// <summary>
            /// The start time of the update batch. The time is displayed in UTC.
            /// </summary>
            [NameInMap("UtcStartTime")]
            [Validation(Required=false)]
            public string UtcStartTime { get; set; }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
