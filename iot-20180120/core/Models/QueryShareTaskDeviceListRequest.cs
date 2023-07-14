// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryShareTaskDeviceListRequest : TeaModel {
        /// <summary>
        /// The keyword in the DeviceName of the device that you want to query. Fuzzy match is supported.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~) of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

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
        /// The ID of the sharing task.
        /// </summary>
        [NameInMap("ShareTaskId")]
        [Validation(Required=false)]
        public string ShareTaskId { get; set; }

    }

}
