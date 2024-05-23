// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDTCSecurityIpHostsForSQLServerRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IP address of the ECS instance and the hostname of the Windows computer. Format: `IP address,Hostname`. Separate multiple entries with semicolon (;).
        /// 
        /// >  For more information about how to query the computer hostname, see [Configure a distributed transaction whitelist](https://help.aliyun.com/document_detail/124321.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityIpHosts")]
        [Validation(Required=false)]
        public string SecurityIpHosts { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The name of the IP address whitelist.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WhiteListGroupName")]
        [Validation(Required=false)]
        public string WhiteListGroupName { get; set; }

    }

}
