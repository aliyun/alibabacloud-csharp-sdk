// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ClearEdgeInstanceDriverConfigsRequest : TeaModel {
        /// <summary>
        /// The ID of the driver. To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver whose configurations you want to delete and obtain the driver ID.
        /// 
        /// You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        /// <summary>
        /// The ID of the edge instance. To obtain the instance ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Edge Instances** page, move the pointer over the name of the edge instance that uses the driver and obtain the instance ID.
        /// 
        /// You can also call the [QueryEdgeInstance](~~135214~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is not required for the public instance but required for your purchased instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
