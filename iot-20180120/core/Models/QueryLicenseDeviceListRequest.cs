// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLicenseDeviceListRequest : TeaModel {
        /// <summary>
        /// The end time of the time range in which the license is bound to the devices.The timestamp follows the UNIX time format. It is the number of seconds that have elapsed since 00:00:00 Thursday, January 1, 1970.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the device.
        /// 
        /// You can call the [QueryDevice](~~69905~~) operation to query the **IotId** values of all devices that belong to a specific product.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  You must specify this parameter for a public instance of the new version or an Enterprise Edition instance. You do not need to specify this parameter for a public instance of the previous version.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The license type that specifies the audio and video specifications. Valid values: **480P** and **720P**.
        /// </summary>
        [NameInMap("LicenseCode")]
        [Validation(Required=false)]
        public string LicenseCode { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public int? PageId { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the devices belong.
        /// 
        /// You can go to the IoT Platform console or call the [QueryProductList](~~69271~~) operation to view the information about all products of the instance.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The start time of the time range in which the license is bound to the devices. The timestamp follows the UNIX time format. It is the number of seconds that have elapsed since 00:00:00 Thursday, January 1, 1970.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
