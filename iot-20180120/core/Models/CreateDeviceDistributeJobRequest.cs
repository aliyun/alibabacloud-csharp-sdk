// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceDistributeJobRequest : TeaModel {
        /// <summary>
        /// The names of the devices to be distributed. You can specify a maximum of 10,000 device names.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the source instance to which the device belongs.
        /// 
        /// *   The IDs of public instances in different regions:
        /// 
        ///     *   China (Shanghai): iotx-oxssharez200.
        ///     *   Japan (Tokyo): iotx-oxssharez300.
        ///     *   Singapore (Singapore): iotx-oxssharez400.
        ///     *   US (Silicon Valley): iotx-oxssharez500.
        ///     *   US (Virginia): iotx-oxssharez600.
        ///     *   Germany (Frankfurt): iotx-oxssharez700.
        /// 
        /// *   The IDs of Enterprise Edition instances:
        /// 
        ///     1\. Log on to the IoT Platform console. Select a region from the drop-down list in the upper-left corner of the top navigation bar.
        /// 
        ///     2\. On the **Overview** page, click the instance name. On the **Instance Details** page, view the instance ID in the **Basic Information** section.
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// The distribution policy. Default value: 0.
        /// 
        /// *   **0**: distributes devices to instances in a specified region.
        /// *   **1**: configures instance IDs in multiple regions and distributes devices to the nearest regions based on the IP addresses of the devices.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        /// <summary>
        /// The Alibaba Cloud account to which the device belongs. You can log on to the IoT Platform console, click the profile picture, and then view the account ID on the **Security Settings** page.
        /// 
        /// The **TargetUid** and **TargetAliyunId** parameters cannot be left empty at the same time.
        /// </summary>
        [NameInMap("TargetAliyunId")]
        [Validation(Required=false)]
        public string TargetAliyunId { get; set; }

        [NameInMap("TargetInstanceConfig")]
        [Validation(Required=false)]
        public List<CreateDeviceDistributeJobRequestTargetInstanceConfig> TargetInstanceConfig { get; set; }
        public class CreateDeviceDistributeJobRequestTargetInstanceConfig : TeaModel {
            /// <summary>
            /// The configurations of the destination instance to which the device is distributed. For more information about instance IDs, see the description of the **SourceInstanceId** parameter.
            /// 
            /// *   If the value of the **Strategy** parameter is **1**, you can specify multiple instance IDs.
            /// *   If the value of the **Strategy** parameter is **0**, you can specify only one instance ID.
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the device belongs. You can log on to the IoT Platform console, click the profile picture, and then view the account ID on the **Security Settings** page.
        /// 
        /// The **TargetUid** and **TargetAliyunId** parameters cannot be left empty at the same time.
        /// </summary>
        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

    }

}
