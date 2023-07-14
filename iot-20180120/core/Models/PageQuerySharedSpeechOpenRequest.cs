// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PageQuerySharedSpeechOpenRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device.
        /// 
        /// > If you specify this parameter, you do not need to specify **ProductKey** and **DeviceName**. **IotId** specifies the GUID of the device. The value of the IotId parameter is a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public int? PageId { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
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
        /// The code that is used to share the speeches.
        /// 
        /// You can obtain the **code** on the **Shared Corpus Management** page of **Speech Sending Voice Broadcasting Service**.
        /// </summary>
        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

        /// <summary>
        /// The status of the speeches that you want to query. Valid values:
        /// 
        /// *   **1**: The speeches are pending approval.
        /// *   **2**: The speeches are approved.
        /// *   **3**: The speeches are rejected.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
