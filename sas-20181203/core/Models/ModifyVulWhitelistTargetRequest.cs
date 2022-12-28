// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulWhitelistTargetRequest : TeaModel {
        /// <summary>
        /// The ID of the whitelist.
        /// 
        /// >  You can call the [DescribeVulWhitelist](~~DescribeVulWhitelist~~) operation to query the IDs of whitelists.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The reason why you add the server to the whitelist.
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The applicable scope of the whitelist. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **type**: the type of the applicable scope. Valid values:
        /// 
        ///     *   **GroupId**: the ID of a server group
        ///     *   **Uuid**: the UUID of a server
        /// 
        /// *   **uuids**: the UUIDs of servers
        /// 
        /// *   **groupIds**: the IDs of server groups
        /// 
        /// >  If you leave this parameter empty, all servers are added to the whitelist. If you set the **type** field to **GroupId**, you must also specify the **groupIds** field. If you set the **type** field to **Uuid**, you must also specify the **uuids** field.
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
