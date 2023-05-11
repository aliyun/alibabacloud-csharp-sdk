// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BindDriverToEdgeInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the driver. To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver that you want to bind and obtain the driver ID.
        /// 
        /// You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        /// <summary>
        /// The version number of the driver. By default, if you do not specify this parameter, the latest version of the driver is used.
        /// </summary>
        [NameInMap("DriverVersion")]
        [Validation(Required=false)]
        public string DriverVersion { get; set; }

        /// <summary>
        /// The ID of the edge instance. To obtain the instance ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Edge Instances** page, move the pointer over the name of the edge instance to which you want to bind a driver and obtain the instance ID.
        /// 
        /// You can also call the [QueryEdgeInstance](~~135214~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for the public instance but required for Enterprise Edition instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the order.
        /// 
        /// >  This parameter is required if you use a third-party driver that is purchased from the IoT marketplace. If an official or self-developed driver is used, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
