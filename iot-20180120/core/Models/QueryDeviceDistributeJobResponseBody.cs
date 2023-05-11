// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDistributeJobResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The task information returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceDistributeJobResponseBodyData Data { get; set; }
        public class QueryDeviceDistributeJobResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the distribution task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The **ProductKey** of the product to which the device belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The ID of the source instance.
            /// </summary>
            [NameInMap("SourceInstanceId")]
            [Validation(Required=false)]
            public string SourceInstanceId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("SourceUid")]
            [Validation(Required=false)]
            public string SourceUid { get; set; }

            /// <summary>
            /// The status of the distribution task.
            /// 
            /// *   **0**: The task is being initialized.
            /// *   **1**: The task is being implemented.
            /// *   **2**: The task is completed. This status only indicates that the distribution task is completed. This status does not indicate that all products and devices are distributed. To obtain distribution results, call the [QueryDeviceDistributeDetail](~~199533~~) operation.
            /// *   **3**: The task is unexpectedly interrupted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The distribution policy.
            /// 
            /// *   **0**: distributes devices to instances in a specified region.
            /// *   **1**: configures instance IDs in multiple regions and distributes devices to the nearest regions based on the IP addresses of the devices.
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public int? Strategy { get; set; }

            /// <summary>
            /// The IDs of the destination instances.
            /// 
            /// *   If the value of the **Strategy** parameter is **1**, multiple instance IDs exist.
            /// *   If the value of the **Strategy** parameter is **0**, only one instance ID exists.
            /// </summary>
            [NameInMap("TargetInstanceConfigs")]
            [Validation(Required=false)]
            public QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigs TargetInstanceConfigs { get; set; }
            public class QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigs : TeaModel {
                [NameInMap("targetInstanceConfigs")]
                [Validation(Required=false)]
                public List<QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                public class QueryDeviceDistributeJobResponseBodyDataTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                    /// <summary>
                    /// The ID of the destination instance.
                    /// </summary>
                    [NameInMap("TargetInstanceId")]
                    [Validation(Required=false)]
                    public string TargetInstanceId { get; set; }

                }

            }

            [NameInMap("TargetUid")]
            [Validation(Required=false)]
            public string TargetUid { get; set; }

            /// <summary>
            /// The total number of devices in the distribution task.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
