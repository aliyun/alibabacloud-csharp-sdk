// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceOriginalPropertyDataRequest : TeaModel {
        /// <summary>
        /// The order in which you want to sort the returned property records. Valid values:
        /// 
        /// *   0: descending.
        /// *   1: ascending.
        /// 
        /// >  The **start time** must be earlier than the **end time**. The system sorts the returned records based on the specified order.
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public int? Asc { get; set; }

        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// > If you specify a value for this parameter, you must configure the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The end of the time range to query. The value must be a 13-digit timestamp.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The identifier of the property.
        /// 
        /// *   If weak verification is used, you can perform the following steps to view the **Identifier** of a device property: Log on to the IoT Platform console and go to the Define Feature tab of the Product Details page. You can also call the [QueryThingModel](~~150321~~) operation and view the property identifier in the returned TSL data.
        /// *   If no verification is used, the value must be the same as the custom **identifier** that is submitted by the device.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// The ID of the device. The ID is a unique identifier that is issued by IoT Platform to the device.
        /// 
        /// > The IotId parameter specifies a unique ID for the device. The value of the **IotId** parameter is equivalent to a combination of the values of the **ProductKey** and **DeviceName.N** parameters. If you specify the IotId parameter, you do not need to configure the **ProductKey** or **DeviceName.N** parameter. If you specify values for the **IotId**, **ProductKey**, and **DeviceName.N** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the ID of the instance on the **Overview** page in the IoT Platform console.
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
        /// The token that is used to retrieve the next page of the query results. If the next page exists, this parameter is returned. In this case, you must add the value of the parameter to the next request.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The maximum number of records that can be returned for each property. Maximum value: 100.
        /// 
        /// The number of records that are returned for an arbitrary property cannot exceed the limit.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.****
        /// 
        /// 
        /// 
        /// > If you specify a value for this parameter, you must configure the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The start of the time range to query. The value must be a 13-digit timestamp.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
