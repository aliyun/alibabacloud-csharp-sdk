// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ReBindLicenseDeviceRequest : TeaModel {
        /// <summary>
        /// The **DeviceNames** of all devices to which you want to rebind a license.
        /// 
        /// You can call the [QueryDevice](~~69905~~) operation to query the **DeviceNames** of all devices that belong to a specific product.
        /// </summary>
        [NameInMap("DeviceNameList")]
        [Validation(Required=false)]
        public List<string> DeviceNameList { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  You must specify the ID of a public instance of the new version or an Enterprise Edition instance. Otherwise, the request fails. You do not need to specify the ID of a public instance of the previous version.
        /// 
        /// For more information, see [Overview](~~356505~~) of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The license type. Set the value to **LINK_SPEECH_COMMON_LICENSE**.
        /// </summary>
        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the devices belong.
        /// 
        /// You can go to the IoT Platform console or call the [QueryProductList](~~69271~~) operation to view the information about all products of the instance.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
