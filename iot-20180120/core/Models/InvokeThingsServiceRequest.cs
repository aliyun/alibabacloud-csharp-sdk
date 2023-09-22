// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class InvokeThingsServiceRequest : TeaModel {
        /// <summary>
        /// The input parameter of the service. The value is a JSON string. Example: **Args={"param1": 1}**.
        /// 
        /// If this parameter is left empty, set the value to **Args={}**.
        /// 
        /// >If the TSL data is of the float or double type, the parameter values that correspond to the TSL data contain at least one decimal place. Examples: 10.0 and 11.1.
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

        /// <summary>
        /// The identifier of the service.
        /// 
        /// You can use one of the following methods to view the **identifier** of the service.
        /// 
        /// *   Log on to the IoT Platform console. On the **Define Feature** tab of the product to which the device belongs, you can view the identifier.
        /// *   Call the [QueryThingModel](~~150321~~) operation and view the identifier in the TSL information that is returned.
        /// 
        /// >  If a service named testService belongs to a custom module named testFb, you can set this parameter to ******testFb:testService******. The custom module is not the default module.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.****
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.****
        /// >*   If no **Overview** page or **ID** is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

    }

}
