// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeOssPreSignedAddressRequest : TeaModel {
        /// <summary>
        /// The name of the object whose URL is to be obtained. The format is `<File name>.<File name extension>`.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The ID of the edge instance. To obtain the instance ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Edge Instances** page, move the pointer over the name of the edge instance that uses the driver and obtain the instance ID.
        /// 
        /// You can also call the [QueryEdgeInstance](~~135214~~) operation to query the instance ID.
        /// 
        /// >  When the **Type** parameter is set to **INSTANCE_DRIVER_VERSION_CONFIG**, this parameter is required.
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
        /// The ID of the resource for which the object URL is to be obtained. Only driver resources are supported. Set this parameter to the ID of the corresponding driver.
        /// 
        /// To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver for which the object URL you want to obtain and obtain the driver ID. You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The version number of the resource. Only driver resources are supported. Set this parameter to the version number of the corresponding driver.
        /// </summary>
        [NameInMap("ResourceVersion")]
        [Validation(Required=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// The content type of the object. Valid values:
        /// 
        /// *   DRIVER_VERSION_CONTENT: the code of a specific driver version.
        /// *   DRIVER_VERSION_DEFAULT_CONFIG: the default configuration of a specific driver version.
        /// *   INSTANCE_DRIVER_VERSION_CONFIG: the configuration of a specific driver version that is used in an edge instance.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
