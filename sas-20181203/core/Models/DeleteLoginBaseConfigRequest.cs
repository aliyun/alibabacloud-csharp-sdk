// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// The content of the logon security settings to delete. The content varies based on the type of the logon security settings. Valid values:
        /// 
        /// *   **login_common_ip**: approved logon IP addresses
        /// 
        /// Example: {"ip":"10.23.23.23"}.
        /// 
        /// *   **login_common_time**: approved logon time ranges
        /// 
        /// Example: {"startTime":"06:00:00","endTime":"16:00:00"}.
        /// 
        /// *   **login_common_account**: approved logon accounts
        /// 
        /// Example: {"account":"test_account_001"}.
        /// 
        /// *   **login_common_location**: approved logon locations
        /// 
        /// Example: {"location":"Shanghai"}.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The UUID of the server whose logon security settings you want to delete.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of the logon security settings to delete. Valid values:
        /// 
        /// *   **login_common_ip**: approved logon IP addresses
        /// *   **login_common_time**: approved logon time ranges
        /// *   **login_common_account**: approved logon accounts
        /// *   **login_common_location**: approved logon locations
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
