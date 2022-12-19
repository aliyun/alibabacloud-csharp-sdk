// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// The configuration item that you want to delete. The items vary based on the type of logon configurations. Valid values:
        /// 
        /// *   **login\_common_ip**: approved logon IP addresses
        /// 
        /// Example: {"ip":"10.23.23.23"}.
        /// 
        /// *   **login\_common_time**: approved logon time ranges
        /// 
        /// Example: {"startTime":"06:00:00","endTime":"16:00:00"}.
        /// 
        /// *   **login\_common_account**: approved logon accounts
        /// 
        /// Example: {"account":"test_account\_001"}.
        /// 
        /// *   **login\_common_location**: approved logon locations
        /// 
        /// Example: {"location":"Shanghai"}.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The UUID of the server whose logon configurations you want to delete.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The type of logon configurations to delete. Valid values:
        /// 
        /// *   **login\_common_ip**: approved logon IP addresses
        /// *   **login\_common_time**: approved logon time ranges
        /// *   **login\_common_account**: approved logon accounts
        /// *   **login\_common_location**: approved logon locations
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
