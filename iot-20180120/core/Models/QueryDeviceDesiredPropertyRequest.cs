// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDesiredPropertyRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// >  If you specify a value for this parameter, you must configure the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The identifier of the custom TSL module. Each identifier is unique in a product.
        /// 
        /// If you do not configure this parameter, the system queries the data of the default module.
        /// </summary>
        [NameInMap("FunctionBlockId")]
        [Validation(Required=false)]
        public string FunctionBlockId { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public List<string> Identifier { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// >  If you specify a value for this parameter, you do not need to configure the **ProductKey** or **DeviceName** parameter. The **IotId** parameter specifies a GUID for the device. The value of the IotId parameter is equivalent to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify values for the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or ID is generated for your instance, you do not need configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// >  If you specify a value for this parameter, you must configure the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
