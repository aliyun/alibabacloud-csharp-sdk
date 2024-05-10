// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UninstallBackupClientRequest : TeaModel {
        /// <summary>
        /// The version of the anti-ransomware policy. You can call the [DescribeBackupPolicies](~~DescribeBackupPolicies~~) operation to query the versions of anti-ransomware policies. Valid values:
        /// 
        /// *   **1.0.0**
        /// *   **2.0.0**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public string PolicyVersion { get; set; }

        /// <summary>
        /// The UUID of the server from which you want to uninstall the anti-ransomware agent.
        /// 
        /// > You must specify at least one of the UuidList and Uuid parameters.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// The UUIDs of the servers from which you want to uninstall the anti-ransomware agent.
        /// 
        /// > You must specify at least one of the UuidList and Uuid parameters.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
