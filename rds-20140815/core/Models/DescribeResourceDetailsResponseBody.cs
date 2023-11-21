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
        /// The storage that is occupied by log backup files, excluding archived backup files, on the instance. Unit: bytes.
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// The storage that is used to store backup files. Unit: bytes. The value -1 indicates that no backup files are stored.
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// Database Storage.
        /// </summary>
        [NameInMap("DbInstanceStorage")]
        [Validation(Required=false)]
        public long? DbInstanceStorage { get; set; }

        /// <summary>
        /// ProxyInstance name.
        /// </summary>
        [NameInMap("DbProxyInstanceName")]
        [Validation(Required=false)]
        public string DbProxyInstanceName { get; set; }

        /// <summary>
        /// The total storage that is occupied by data files and log files on the instance. Unit: bytes. The value -1 indicates that no data files or log files are stored on the instance.
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// Instance StorageType
        /// </summary>
        [NameInMap("InstanceStorageType")]
        [Validation(Required=false)]
        public string InstanceStorageType { get; set; }

        /// <summary>
        /// Whitelist Rules.
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
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The IP address whitelist of the serverless instance. For more information, see [Use a database client or the CLI to connect to an ApsaraDB RDS for PostgreSQL instance](~~43185~~). If the IP address whitelist contains more than one entry, separate the entries with commas (,). Each entry must be unique. You can specify up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:
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
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// VPC ID.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
