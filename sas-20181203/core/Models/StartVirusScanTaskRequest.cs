// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartVirusScanTaskRequest : TeaModel {
        /// <summary>
        /// The asset on which you want to perform a virus scan task. You can select servers or server groups to scan for viruses. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:
        /// 
        /// *   **type**: the type of the asset on which you want to perform a virus scan task. Valid values:
        /// 
        ///     *   **groupId**: server group.
        ///     *   **uuid**: server.
        /// 
        /// *   **name**: the name of the server or server group.
        /// 
        /// *   **target**: the asset on which you want to perform a virus scan task. Valid values:
        /// 
        ///     *   If you set **type** to **groupId**, you must set this field to the ID of the server group. You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of server groups.
        ///     *   If you set **type** to **uuid**, you must set this field to the UUID of the server. You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
