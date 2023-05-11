// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class SaveDevicePropRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// >  If you specify this parameter, you must also specify the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// >  If you specify this parameter, you do not need to specify the **ProductKey** or **DeviceName** parameters. The **IotId** parameter specifies a globally unique identifier (GUID) for the device. The value of the IotId parameter corresponds to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the **ID** of the instance.
        /// 
        /// 
        /// **Important**
        /// 
        /// *   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// *   If the **Overview** page or instance ID is not displayed in the IoT Platform console, you do not need to configure this parameter.
        /// 
        /// For more information about the instance, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// >  If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The tag that you want to specify for the device. You can specify multiple tags.
        /// 
        /// The tags must be JSON data in the **Key:Value** format. **Key** indicates the tag name, and **Value** indicates the tag value.
        /// 
        /// Separate multiple tags with commas (,). Example: **Props={"color":"red","shape":"round"}**
        /// 
        /// 
        /// **Important**
        /// 
        /// *   The maximum size of the **Props** parameter is 5 KB.
        /// *   `abc` is a **key** that is reserved by IoT Platform. You cannot set **Key** to abc. If you set `Key` to abc, the abc tag is automatically filtered when you query tags.
        /// </summary>
        [NameInMap("Props")]
        [Validation(Required=false)]
        public string Props { get; set; }

    }

}
