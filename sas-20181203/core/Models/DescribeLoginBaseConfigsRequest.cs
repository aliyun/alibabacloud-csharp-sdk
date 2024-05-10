// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginBaseConfigsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **5**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The server to which the configuration is applied. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **Target**: the UUID or group ID of the server to add or delete.
        /// 
        /// > If targetType is set to uuid, the value of Target is the UUID of the server. If targetType is set to groupId, the value of Target is the group ID of the server. If targetType is set to global, the value of Target is a hyphen (-).
        /// 
        /// *   **targetType**: the type of the server to which the configuration is applied. Valid values:
        /// 
        ///     *   **uuid**: a server
        ///     *   **groupId**: a server group
        ///     *   **global**: all servers
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The logon type of the configuration to query. Valid values:
        /// 
        /// *   **login_common_location**: common logon location
        /// *   **login_common_ip**: common logon IP address
        /// *   **login_common_time**: common logon time range
        /// *   **login_common_account**: common logon account
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
