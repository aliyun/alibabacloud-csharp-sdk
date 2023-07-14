// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BindLicenseDeviceRequest : TeaModel {
        [NameInMap("DeviceNameList")]
        [Validation(Required=false)]
        public List<string> DeviceNameList { get; set; }

        [NameInMap("IotIdList")]
        [Validation(Required=false)]
        public List<string> IotIdList { get; set; }

        /// <summary>
        /// The ID of the Enterprise Edition instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The license type that specifies the audio and video specifications. Valid values: **480P** and **720P**.
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
