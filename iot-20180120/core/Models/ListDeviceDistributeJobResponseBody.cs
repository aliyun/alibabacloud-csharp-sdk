// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDeviceDistributeJobResponseBody : TeaModel {
        /// <summary>
        /// The error code that is returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The distribution tasks that are returned if the call is successful. For more information, see the **JobInfo** parameter.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeviceDistributeJobResponseBodyData Data { get; set; }
        public class ListDeviceDistributeJobResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the task.
            /// </summary>
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public ListDeviceDistributeJobResponseBodyDataJobInfo JobInfo { get; set; }
            public class ListDeviceDistributeJobResponseBodyDataJobInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListDeviceDistributeJobResponseBodyDataJobInfoItems> Items { get; set; }
                public class ListDeviceDistributeJobResponseBodyDataJobInfoItems : TeaModel {
                    /// <summary>
                    /// The time when the task was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    /// <summary>
                    /// The ID of the task.
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
                    /// The name of the source instance.
                    /// </summary>
                    [NameInMap("SourceInstanceName")]
                    [Validation(Required=false)]
                    public string SourceInstanceName { get; set; }

                    /// <summary>
                    /// The region where the source instance resides.
                    /// </summary>
                    [NameInMap("SourceRegion")]
                    [Validation(Required=false)]
                    public string SourceRegion { get; set; }

                    /// <summary>
                    /// The ID of the source Alibaba Cloud account.
                    /// </summary>
                    [NameInMap("SourceUid")]
                    [Validation(Required=false)]
                    public string SourceUid { get; set; }

                    /// <summary>
                    /// The status of the task.
                    /// 
                    /// *   **0**: The task is being initialized.
                    /// *   **1**: The task is running.
                    /// *   **2**: The task is completed. The status indicates that the distribution task is complete but does not indicate that all products and devices are distributed. To obtain distribution results, call the [QueryDeviceDistributeDetail](~~199533~~) operation.
                    /// *   **3**: The task is unexpectedly interrupted.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The distribution policy.
                    /// 
                    /// *   **0**: distributes devices to specified instances in a specified region. This is the default value.
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
                    public ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigs TargetInstanceConfigs { get; set; }
                    public class ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigs : TeaModel {
                        [NameInMap("targetInstanceConfigs")]
                        [Validation(Required=false)]
                        public List<ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs> TargetInstanceConfigs { get; set; }
                        public class ListDeviceDistributeJobResponseBodyDataJobInfoItemsTargetInstanceConfigsTargetInstanceConfigs : TeaModel {
                            /// <summary>
                            /// The ID of the destination instance.
                            /// </summary>
                            [NameInMap("TargetInstanceId")]
                            [Validation(Required=false)]
                            public string TargetInstanceId { get; set; }

                            /// <summary>
                            /// The name of the destination instance.
                            /// </summary>
                            [NameInMap("TargetInstanceName")]
                            [Validation(Required=false)]
                            public string TargetInstanceName { get; set; }

                            /// <summary>
                            /// The region where the destination instance resides.
                            /// </summary>
                            [NameInMap("TargetRegion")]
                            [Validation(Required=false)]
                            public string TargetRegion { get; set; }

                        }

                    }

                    /// <summary>
                    /// The ID of the destination Alibaba Cloud account.
                    /// </summary>
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

            }

            /// <summary>
            /// The token that is used to retrieve the subsequent pages of the query results. The value of this parameter can be used in the next query to obtain the subsequent pages of results. 
            /// 
            /// If the return value is empty, no subsequent page exists.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of device distribution tasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the call fails.
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
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
