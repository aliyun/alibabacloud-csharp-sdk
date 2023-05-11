// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchBindDeviceToEdgeInstanceWithDriverRequest : TeaModel {
        /// <summary>
        /// The IDs of the devices.
        /// 
        /// You can call the [QueryDevice](~~69905~~) operation to query detailed information about all devices that belong to the current Alibaba Cloud account and obtain the required device IDs.
        /// 
        /// >  You can specify a maximum of 20 device IDs when you call the BatchBindDeviceToEdgeInstanceWithDriver operation.
        /// </summary>
        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        /// <summary>
        /// The ID of the driver. To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver that you want to configure and obtain the driver ID.
        /// 
        /// You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IotIds")]
        [Validation(Required=false)]
        public List<string> IotIds { get; set; }

        /// <summary>
        /// The ID of the edge instance. To obtain the instance ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Edge Instances** page, move the pointer over the name of the edge instance to which you want to bind multiple devices and obtain the instance ID.
        /// 
        /// You can also call the [QueryEdgeInstance](~~135214~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
