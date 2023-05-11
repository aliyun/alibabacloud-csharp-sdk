// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalEventDataRequest : TeaModel {
        /// <summary>
        /// The sorting order of the returned event records. Value values:
        /// 
        /// *   0: descending.
        /// *   1: ascending.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        /// <summary>
        /// The name of the device.
        /// 
        /// >  If you specify this parameter, you must also specify the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The end of the time range to query. The value is a 13-digit timestamp in milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The event identifier that you want to query.
        /// 
        /// *   If low-level verification is applied, you can perform the following steps to view the **Identifier** of a device event: Log on to the IoT Platform console and go to the Define Feature tab of the Product Details page. You can also call the [QueryThingModel](~~150321~~) operation and view the service identifier in the returned TSL data.
        /// *   If no verification is applied, the value must be the same as the value of the custom** identifier** that is submitted by the device.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the device. It is the unique identifier that IoT Platform generated for the device.
        /// 
        /// >  If you specify this parameter, you do not need to specify the **ProductKey** or **DeviceName** parameter. The **IotId** parameter specifies a unique identifier for the device, and corresponds to a combination of the **ProductKey** and **DeviceName** parameters. If you specify the **IotId** parameter and the combination of the **ProductKey** and **DeviceName** parameters at the same time, only the **IotId** parameter is used.
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
        /// The identifier of the next page. If the next page exists, this parameter is returned. In this case, you must add the value of the parameter to the next request.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs.
        /// 
        /// >  If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The start of the time range to query. The value is a 13-digit timestamp in milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
