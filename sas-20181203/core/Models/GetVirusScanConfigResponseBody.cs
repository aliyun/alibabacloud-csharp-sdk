// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVirusScanConfigResponseBody : TeaModel {
        /// <summary>
        /// The data returned if the request was successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVirusScanConfigResponseBodyData Data { get; set; }
        public class GetVirusScanConfigResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the task configuration.
            /// 
            /// > You can call the [DescribeCycleTaskList](~~DescribeCycleTaskList~~) operation to query the IDs of task configurations.
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public string ConfigId { get; set; }

            /// <summary>
            /// Indicates whether the periodic scan feature is enabled. Valid value:
            /// 
            /// *   **1**: The feature is enabled
            /// *   **0**: The feature is disabled.
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// The interval at which virus scan tasks are run.
            /// </summary>
            [NameInMap("IntervalPeriod")]
            [Validation(Required=false)]
            public int? IntervalPeriod { get; set; }

            /// <summary>
            /// The unit of the interval at which virus scan tasks are run.
            /// 
            /// *   The value is fixed as **day**.
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// The file paths.
            /// </summary>
            [NameInMap("ScanPath")]
            [Validation(Required=false)]
            public List<string> ScanPath { get; set; }

            /// <summary>
            /// The type of the virus scan task. Valid values:
            /// 
            /// *   **system**: automatic scan.
            /// *   **user**: custom scan.
            /// </summary>
            [NameInMap("ScanType")]
            [Validation(Required=false)]
            public string ScanType { get; set; }

            /// <summary>
            /// The key that stores the asset information.
            /// 
            /// > You can call the [GetAssetSelectionConfig](~~GetAssetSelectionConfig~~) operation to obtain the key value.
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public string SelectionKey { get; set; }

            /// <summary>
            /// The end time of the virus scan task. The time is a time frame.
            /// </summary>
            [NameInMap("TargetEndTime")]
            [Validation(Required=false)]
            public int? TargetEndTime { get; set; }

            /// <summary>
            /// The start time of the virus scan task. The time is a time frame.
            /// </summary>
            [NameInMap("TargetStartTime")]
            [Validation(Required=false)]
            public int? TargetStartTime { get; set; }

            /// <summary>
            /// The type of the task. Valid value:
            /// 
            /// *   **VIRUS_VUL_SCHEDULE_SCAN**: a virus scan task.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
