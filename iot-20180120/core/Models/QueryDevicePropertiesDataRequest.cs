// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertiesDataRequest : TeaModel {
        /// <summary>
        /// The sorting order of the returned property records. Valid values:
        /// 
        /// *   **0**: in reverse chronological order. In this case, the time that is specified by the **StartTime** parameter must be later than the time that is specified by the **EndTime** parameter.
        /// *   **1**: in chronological order. In this case, the time that is specified by the **StartTime** parameter must be earlier than the time that is specified by the **EndTime** parameter.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        /// <summary>
        /// The DeviceName of the device.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a 13-digit timestamp in milliseconds, for example 1579249499000.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public List<string> Identifier { get; set; }

        /// <summary>
        /// The ID of the device. The device ID is issued by IoT Platform.
        /// 
        /// >  The **IotId** parameter is a globally unique identifier (GUID), and corresponds to a combination of the **ProductKey** and **DeviceName** parameters. If you specify the **IotId** parameter and a combination of the **ProductKey** and **DeviceName** parameters at the same time, the **IotId** parameter is used.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The maximum number of records that is returned for each property. Maximum value: 100.
        /// 
        /// The number of records that are returned for an arbitrary property cannot exceed the limit.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The start of the time range to query. The value is a 13-digit timestamp in milliseconds, for example, 1579249499000.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
