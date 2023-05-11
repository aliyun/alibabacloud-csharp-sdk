// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceEventDataRequest : TeaModel {
        /// <summary>
        /// The order in which you want to sort the returned event records. Valid values:
        /// 
        /// *   **0**: in reverse chronological order. This is the default value.
        /// *   **1**: in chronological order.
        /// 
        /// >  If you do not configure this parameter, the default value **0** is used. The system sorts the returned event records in reverse chronological order.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// >  If you specify a value for this parameter, you must also specify a value for the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a 13-digit timestamp in milliseconds. Example: 1516541900303.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The type of the event that you want to query. Valid values:
        /// 
        /// *   **info**: Information.
        /// *   **alert**: Alert.
        /// *   **error**: Error.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The identifier of the event that you want to query. You can view the event identifier on the Define Feature tab of the Product Details page in the IoT Platform console. You can also call the [QueryThingModel](~~150321~~) operation and view the event identifier in the returned TSL data.
        /// 
        /// >  If the PowerOff event belongs to a custom module named testFb, this parameter is set to **testFb:PowerOff**.
        /// 
        /// If you do not specify this parameter, the system queries all event data of the default module and custom modules.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// >  If you specify a value for this parameter, you do not need to specify a value for the **ProductKey** or **DeviceName** parameter. The **IotId** parameter specifies a globally unique identifier (GUID) for the device. The value of the IotId parameter corresponds to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify a value for the **IotId** parameter and values for the **ProductKey** and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page does not appear in the IoT Platform console or no ID is generated for your instance, you do not need to specify this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// >  If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a 13-digit timestamp in milliseconds. Example: 1516538300303.
        /// 
        /// >  You can query the event data only of the most recent 30 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
