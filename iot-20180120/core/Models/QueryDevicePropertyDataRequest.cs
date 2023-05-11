// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyDataRequest : TeaModel {
        /// <summary>
        /// The order in which you want to sort the property records that are returned. Valid values:
        /// 
        /// *   **0**: reverse chronological order
        /// *   **1**: chronological order
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        /// <summary>
        /// The name of the device.
        /// 
        /// >If you specify a value for this parameter, you must also specify a value for the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The end of the time range to query. The value of the EndTime parameter must be greater than the value of the **StartTime** parameter. The value is a timestamp in milliseconds, for example, 1579249499000.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The identifier of the property that you want to query.
        /// 
        /// You can view the property **identifier** on the Define Feature tab of the Product Details page in the IoT Platform console. You can also call the [QueryThingModel](~~150321~~) operation and view the property identifier in the returned TSL data.
        /// 
        /// >  If a property named temperature belongs to a custom module named testFb, set this parameter to **testFb:temperature**. The custom module is not the default module.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the device to which the property belongs.:
        /// 
        /// You can call the [QueryDeviceInfo](~~257184~~) operation to query the **ID** of the device.
        /// 
        /// >If you specify a value for this parameter, you do not need to specify a value for the **ProductKey** or **DeviceName** parameter. The **IotId** parameter specifies a globally unique identifier (GUID) for the device. The value of the IotId parameter corresponds to a combination of the values of the **ProductKey** and **DeviceName** parameters. If you specify a value for the **IotId** parameter and values for the **ProductKey** and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not configure this parameter, the call fails.
        /// *   If your instance has no **Overview** page or ID, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// >If you specify a value for this parameter, you must also specify a value for the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The start of the time range to query. The value of the StartTime parameter must be less than the value of the **EndTime** parameter. The value is a timestamp in milliseconds, for example, 1579249499000.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
