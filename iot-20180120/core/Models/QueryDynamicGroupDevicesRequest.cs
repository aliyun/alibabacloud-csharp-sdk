// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDynamicGroupDevicesRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// If you specify this parameter and set **FuzzyName** to **true**, the value you specified is used as the prefix to fuzzy match the DeviceName. The value must be at least 4 characters in length.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Specifies whether to fuzzy match devices by the value of the **DeviceName** parameter. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("FuzzyName")]
        [Validation(Required=false)]
        public bool? FuzzyName { get; set; }

        /// <summary>
        /// The ID of the group. The ID is the globally unique identifier (GUID) for the group.
        /// 
        /// You can call the [QueryDeviceGroupList](~~93356~~) operation to query the **GroupId** parameter.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 200. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the devices belong.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The device status. Valid values:
        /// 
        /// *   **ONLINE**: The device is online.
        /// *   **OFFLINE**: The device is offline.
        /// *   **UNACTIVE**: The device is not activated.
        /// *   **DISABLE**: The device is deactivated.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
