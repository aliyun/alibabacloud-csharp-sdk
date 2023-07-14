// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechLicenseDeviceListRequest : TeaModel {
        /// <summary>
        /// The ID of a device group. The InSpecifiedGroup response parameter indicates whether the devices belong to the specified group.
        /// </summary>
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        /// <summary>
        /// The keyword in the DeviceName of the device whose information you want to query. Fuzzy match is supported.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

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
        /// The license status.
        /// 
        /// *   **NORMAL**: The license is valid.
        /// *   **EXPIRE**: The license is expired.
        /// *   **EXPIRING**: The license is about to expire.
        /// </summary>
        [NameInMap("LicenseStatusList")]
        [Validation(Required=false)]
        public List<string> LicenseStatusList { get; set; }

        /// <summary>
        /// The page number. Valid values: 1 to 10000.
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public int? PageId { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 50. Default value: 20.
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

    }

}
