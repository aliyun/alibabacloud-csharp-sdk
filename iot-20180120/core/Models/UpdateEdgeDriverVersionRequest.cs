// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateEdgeDriverVersionRequest : TeaModel {
        /// <summary>
        /// The Java Virtual Machine (JVM) startup parameter.
        /// </summary>
        [NameInMap("Argument")]
        [Validation(Required=false)]
        public string Argument { get; set; }

        /// <summary>
        /// The rule for verifying configurations. Set this parameter to a JSON string in the following format:
        /// 
        /// `{"deviceConfig":{"required":false},"driverConfig":{"required":false}`
        /// 
        /// The JSON string contains the following parameters:
        /// 
        /// *   driverConfig: the rule for verifying the configuration of the driver when the driver is to be deployed in an edge instance.
        /// *   deviceConfig: the rule for verifying the configurations of devices that use the driver when the driver is to be deployed in an edge instance.
        /// 
        /// `required`: A value of true indicates that the corresponding parameter is required. A value of false indicates that the corresponding parameter is optional.
        /// </summary>
        [NameInMap("ConfigCheckRule")]
        [Validation(Required=false)]
        public string ConfigCheckRule { get; set; }

        /// <summary>
        /// The configuration of the container where the driver runs. Set this parameter to a JSON string. For more information about parameters in the JSON string, see the following parameter description of ContainerConfig.
        /// </summary>
        [NameInMap("ContainerConfig")]
        [Validation(Required=false)]
        public string ContainerConfig { get; set; }

        /// <summary>
        /// The description of the driver. The description can be a maximum of 256 bytes in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The configuration of the driver. Set this parameter to a JSON string in the following format:
        /// 
        /// `{"format":"JSON","content":"{}"}`
        /// 
        /// The JSON string contains the following parameters:
        /// 
        /// *   format: the format of the driver configuration. Valid values: KV (key-value pair), JSON (JSON string), and FILE (configuration file).
        /// 
        /// *   content: the content of the driver configuration. If you set the format parameter to KV or JSON, set this parameter to the configuration content of the driver. If you set the format parameter to FILE, set this parameter to the URL of the driver configuration file stored in OSS.
        /// 
        /// >To obtain the URL of the driver configuration file stored in OSS, call the [CreateOssPreSignedAddress](~~155858~~) operation.
        /// </summary>
        [NameInMap("DriverConfig")]
        [Validation(Required=false)]
        public string DriverConfig { get; set; }

        /// <summary>
        /// The ID of the driver. To obtain the driver ID, perform the following steps: Log on to the [Link IoT Edge console](https://iot.console.aliyun.com/le/instance/list). On the **Drivers** page, move the pointer over the name of the driver for which you want to update a driver version and obtain the driver ID.
        /// 
        /// You can also call the [QueryEdgeDriver](~~155776~~) operation to query the driver ID.
        /// </summary>
        [NameInMap("DriverId")]
        [Validation(Required=false)]
        public string DriverId { get; set; }

        /// <summary>
        /// The version number of the driver.
        /// </summary>
        [NameInMap("DriverVersion")]
        [Validation(Required=false)]
        public string DriverVersion { get; set; }

        /// <summary>
        /// The earliest version of Link IoT Edge that is supported by the driver. The driver can run on gateways of only this version and later. For example, if you set this parameter to 2.4.0, the driver can run on gateways of only version 2.4.0 and later.
        /// </summary>
        [NameInMap("EdgeVersion")]
        [Validation(Required=false)]
        public string EdgeVersion { get; set; }

        /// <summary>
        /// The ID of the Internet of Things (IoT) service instance. This parameter is not required for the public instance but required for Enterprise Edition instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfig { get; set; }

    }

}
