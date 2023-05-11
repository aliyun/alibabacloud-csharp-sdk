// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDistributedProductRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 200.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The ID of the source instance to which the product belongs.
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
        /// *   To view the ID of an Enterprise Edition instance, perform the following steps:
        /// 
        ///     1\. Log on to the [IoT Platform console](https://iot.console.aliyun.com/). In the top navigation bar, select the region where the instance resides from the drop-down list.
        /// 
        ///     2\. On the **Overview** page, view the **ID** of the instance.
        /// </summary>
        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// The ID of the destination instance to which the product is distributed. For more information about instance IDs, see the description of the **SourceInstanceId** parameter.
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the product belongs. You can log on to the IoT Platform console, click the profile picture, and then view the **account ID** on the **Security Settings** page.
        /// </summary>
        [NameInMap("TargetUid")]
        [Validation(Required=false)]
        public string TargetUid { get; set; }

    }

}
