// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAJobByFirmwareResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The update batch information returned if the call is successful. For more information, see **SimpleOTATaskInfo**.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOTAJobByFirmwareResponseBodyData Data { get; set; }
        public class ListOTAJobByFirmwareResponseBodyData : TeaModel {
            [NameInMap("SimpleOTAJobInfo")]
            [Validation(Required=false)]
            public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo> SimpleOTAJobInfo { get; set; }
            public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfo : TeaModel {
                /// <summary>
                /// The ID of the update package.
                /// </summary>
                [NameInMap("FirmwareId")]
                [Validation(Required=false)]
                public string FirmwareId { get; set; }

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
                /// *   **COMPLETE**: The update batch is completed.
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
                /// The ProductKey of the product to which the update package belongs.
                /// </summary>
                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

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
                /// The tags of the update batch.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags Tags { get; set; }
                public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTags : TeaModel {
                    [NameInMap("OtaTagDTO")]
                    [Validation(Required=false)]
                    public List<ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO> OtaTagDTO { get; set; }
                    public class ListOTAJobByFirmwareResponseBodyDataSimpleOTAJobInfoTagsOtaTagDTO : TeaModel {
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
                /// The start time of the update batch. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UtcStartTime")]
                [Validation(Required=false)]
                public string UtcStartTime { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of update jobs returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
