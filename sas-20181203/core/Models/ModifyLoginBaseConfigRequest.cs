// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// The details of the configuration that is used to detect unusual logons to your servers. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **totalCount**: the total number of servers.
        /// *   **uuidCount**: the number of servers to which the configuration is applied.
        /// *   **id**: the ID of the configuration.
        /// *   **location**: the common logon location.
        /// 
        /// > You must specify this field if the Type parameter is set to login_common_location.
        /// 
        /// *   **ip**: the common logon IP address.
        /// 
        /// > You must specify this field if the Type parameter is set to login_common_ip.
        /// 
        /// *   **endTime**: the end time of the common logon time range.
        /// 
        /// > You must specify this field if the Type parameter is set to login_common_time.
        /// 
        /// *   **startTime**: the start time of the common logon time range.
        /// 
        /// > You must specify this field if the Type parameter is set to login_common_time.
        /// 
        /// *   **account**: the common logon account.
        /// 
        /// > You must specify this field if the Type parameter is set to login_common_account.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The details of the server to which the configuration is applied. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **Target**: the UUID of the server.
        /// 
        /// *   **targetType**: the type of the server to which the configuration is applied. Valid values:
        /// 
        ///     *   **uuid**: a server
        ///     *   **groupId**: a server group
        /// 
        /// *   **flag**: the operation that you want to perform on the server. Valid values:
        /// 
        ///     *   **del**: removes the server from the configuration.
        ///     *   **add**: adds the server to the configuration.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The logon type of the configuration to modify. Valid values:
        /// 
        /// *   **login\_common_location**: common logon location
        /// *   **login\_common_ip**: common logon IP address
        /// *   **login\_common_time**: common logon time range
        /// *   **login\_common_account**: common logon account
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
