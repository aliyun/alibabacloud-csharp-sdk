// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// The details about the configuration that is used to detect unusual logons to your servers. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// - **totalCount**: the total number of assets. 
        /// - **uuidCount**: the number of servers to which the configuration is applied. 
        /// - **id**: the ID of the configuration. 
        /// - **location**: the name of the common logon location. 
        /// 
        /// > You must specify the location parameter only if the Type parameter is set to login_common_location. 
        /// 
        /// - **ip**: the common logon IP address. 
        /// 
        /// > You must specify the ip parameter only if the Type parameter is set to login_common_ip. 
        /// 
        /// - **endTime**: the end time of the common logon time range. 
        /// 
        /// > You must specify the endTime parameter only if the Type parameter is set to login_common_time. 
        /// 
        /// - **startTime**: the start time of the common logon time range. 
        /// 
        /// > You must specify the startTime parameter only if the Type parameter is set to login_common_time. 
        /// 
        /// - **account**: the common logon account. 
        /// 
        /// > You must specify the account parameter only if the Type parameter is set to login_common_account.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The configuration of the server to which the configuration used to detect unusual logons is applied. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// - **Target**: the UUID of the server that you want to add or remove. 
        /// - **targetType*: the type based on which you add servers. Valid values:
        ///     - **uuid**: servers 
        ///     - **groupId**: server groups 
        /// - **flag**: the operation that you want to perform on the server. Valid values:
        ///     - **del**: removes the server from the configuration. 
        ///     - **add**: adds the server to the configuration.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of logon configuration that you want to modify. Valid values:
        /// - **login_common_location**: common logon location 
        /// - **login_common_ip**: common logon IP address 
        /// - **login_common_time**: common logon time range 
        /// - **login_common_account**: common logon account
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
