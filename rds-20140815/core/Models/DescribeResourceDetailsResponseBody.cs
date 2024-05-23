// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceDetailsResponseBody : TeaModel {
        /// <summary>
        /// The storage that is occupied by data backup files, excluding archived backup files, on the instance. Unit: bytes.
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// The size of the backup log. Unit: bytes.
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// The size of the backup data. Unit: MB.
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// The disk capacity of the instance.
        /// </summary>
        [NameInMap("DbInstanceStorage")]
        [Validation(Required=false)]
        public long? DbInstanceStorage { get; set; }

        /// <summary>
        /// The name of the proxy instance.
        /// </summary>
        [NameInMap("DbProxyInstanceName")]
        [Validation(Required=false)]
        public string DbProxyInstanceName { get; set; }

        /// <summary>
        /// The total storage used. The value is the sum of the DataSize and LogSize values. Unit: bytes. The value -1 indicates that no data files or log files are stored.
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// The storage type of the instance.
        /// </summary>
        [NameInMap("InstanceStorageType")]
        [Validation(Required=false)]
        public string InstanceStorageType { get; set; }

        /// <summary>
        /// The rule for the IP address whitelist of the instance.
        /// </summary>
        [NameInMap("RdsEcsSecurityGroupRel")]
        [Validation(Required=false)]
        public List<DescribeResourceDetailsResponseBodyRdsEcsSecurityGroupRel> RdsEcsSecurityGroupRel { get; set; }
        public class DescribeResourceDetailsResponseBodyRdsEcsSecurityGroupRel : TeaModel {
            /// <summary>
            /// The name of the security group.
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The IP address whitelist of the instance. For more information, see [Configure IP address whitelists](https://help.aliyun.com/document_detail/43185.html). If the returned IP address whitelist contains more than one entry, these entries are separated with commas (,). Each entry is unique and up to 1,000 entries are returned. The entries in the IP address whitelist must be in one of the following formats:
        /// 
        /// *   IP addresses, such as 10.10.XX.XX.
        /// *   CIDR blocks, such as 10.10.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.
        /// 
        /// If this parameter is not specified, the default IP address whitelist is used.
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// 
        /// >  The vSwitch must belong to the same zone as the instance.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
