// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveHostsFromGroupRequest : TeaModel {
        /// <summary>
        /// The return code that indicates whether the call was successful. Valid values:
        /// 
        /// *   **OK**: The call was successful.
        /// *   **UNEXPECTED**: An unknown error occurred.
        /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
        /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
        /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
        /// </summary>
        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("HostIds")]
        [Validation(Required=false)]
        public string HostIds { get; set; }

        /// <summary>
        /// The ID of the host that you want to remove from the host group. The value is a JSON string. You can add up to 100 host IDs.
        /// 
        /// >  You can call the [ListHosts](~~200665~~) operation to query the IDs of hosts.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the host group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
