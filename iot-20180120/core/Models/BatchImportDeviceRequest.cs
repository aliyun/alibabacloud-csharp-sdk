// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchImportDeviceRequest : TeaModel {
        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public List<BatchImportDeviceRequestDeviceList> DeviceList { get; set; }
        public class BatchImportDeviceRequestDeviceList : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceSecret")]
            [Validation(Required=false)]
            public string DeviceSecret { get; set; }

            [NameInMap("Sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

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
        /// The **ProductKey** of the gateway product to which the devices belong.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
