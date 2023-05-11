// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedDeviceRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The DeviceName of the device.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 200.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// The ID of the Alibaba Cloud account. You can log on to the IoT Platform console, click the profile picture, and then view **Account ID** on the **Security Settings** page.
        /// </summary>
        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

    }

}
