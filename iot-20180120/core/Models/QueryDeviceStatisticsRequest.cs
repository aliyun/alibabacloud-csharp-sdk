// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceStatisticsRequest : TeaModel {
        /// <summary>
        /// The ID of the group to which the devices belong.
        /// 
        /// *   If you specify this parameter, the statistics of the devices that are added to the group is returned. If you also specify **ProductKey**, the statistics of the devices that are created under the product and added to the group is returned.
        /// *   If you do not specify this parameter and **ProductKey**, the statistics of all devices within the current account is returned.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

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
        /// The ProductKey of the product to which the devices belong.
        /// 
        /// *   If you specify this parameter, the statistics of the devices under the product is returned. If you also specify **GroupId**, the statistics of the devices that are created under the product and added to the group is returned.
        /// *   If you do not specify this parameter and **GroupId**, the statistics of all devices within the current account is returned.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
