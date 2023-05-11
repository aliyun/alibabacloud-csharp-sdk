// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedDeviceResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The products returned if the call is successful. For more information, see **Info**.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDistributedDeviceResponseBodyData Data { get; set; }
        public class ListDistributedDeviceResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the device.
            /// </summary>
            [NameInMap("Info")]
            [Validation(Required=false)]
            public ListDistributedDeviceResponseBodyDataInfo Info { get; set; }
            public class ListDistributedDeviceResponseBodyDataInfo : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<ListDistributedDeviceResponseBodyDataInfoItems> Items { get; set; }
                public class ListDistributedDeviceResponseBodyDataInfoItems : TeaModel {
                    /// <summary>
                    /// The DeviceName of the device.
                    /// </summary>
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    /// <summary>
                    /// The time when the distribution task was created.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    /// <summary>
                    /// The time when the distribution task was modified.
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public long? GmtModified { get; set; }

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
                    /// The source region in which the device resides.
                    /// </summary>
                    [NameInMap("SourceRegion")]
                    [Validation(Required=false)]
                    public string SourceRegion { get; set; }

                    /// <summary>
                    /// The ID of the Alibaba Cloud account that distributes the device.
                    /// 
                    /// You can only distribute devices across regions and instances by using the same Alibaba cloud account. The value of this parameter is the same as the value of the **TargetUid** parameter.
                    /// </summary>
                    [NameInMap("SourceUid")]
                    [Validation(Required=false)]
                    public string SourceUid { get; set; }

                    /// <summary>
                    /// The Alibaba Cloud account to which the device is distributed.
                    /// </summary>
                    [NameInMap("TargetAliyunId")]
                    [Validation(Required=false)]
                    public string TargetAliyunId { get; set; }

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
                    /// The destination region to which the device is distributed.
                    /// </summary>
                    [NameInMap("TargetRegion")]
                    [Validation(Required=false)]
                    public string TargetRegion { get; set; }

                    /// <summary>
                    /// The Alibaba Cloud account to which the device is distributed.
                    /// 
                    /// You can only distribute devices across regions and instances by using the same Alibaba cloud account. The value of this parameter is the same as the value of the **TargetUid** parameter.
                    /// </summary>
                    [NameInMap("TargetUid")]
                    [Validation(Required=false)]
                    public string TargetUid { get; set; }

                }

            }

            /// <summary>
            /// The total number of returned devices.
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
