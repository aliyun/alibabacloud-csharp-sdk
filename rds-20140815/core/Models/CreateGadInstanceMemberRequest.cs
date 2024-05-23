// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGadInstanceMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the central node . You can call the DescribeGadInstances operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// The username of the privileged account of the central node. You can call the DescribeAccounts operation to query the privileged account of the central node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// The password of the privileged account of the central node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// The region ID of the central node. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// A JSON array that consists of the information about the databases on the central node. All database information that you specify in this array is synchronized to the unit nodes of the global active database cluster. The JSON array contains the following fields:
        /// 
        /// *   **name**: the name of the database.
        /// *   **all**: specifies whether to synchronize all data in the database or the table. Valid values: **true** and **false**.
        /// *   **Table**: the name of the table. If you set the **all** field to **false**, you must nest the name of the table that you want to synchronize into the JSON array.
        /// 
        /// Example: `{ "testdb": { "name": "testdb", "all": false, "Table": { "order": { "name": "order", "all": true }, "ordernew": { "name": "ordernew", "all": true } } } }`
        /// 
        /// >  For more information, see [Objects of DTS tasks](https://help.aliyun.com/document_detail/209545.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// The ID of the global active database cluster. You can call the DescribeGadInstances operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GadInstanceId")]
        [Validation(Required=false)]
        public string GadInstanceId { get; set; }

        /// <summary>
        /// The information about the unit node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGadInstanceMemberRequestUnitNode> UnitNode { get; set; }
        public class CreateGadInstanceMemberRequestUnitNode : TeaModel {
            /// <summary>
            /// The name of the unit node that you want to create. The name must meet the following requirements:
            /// 
            /// *   The name must be **2 to 255** characters in length.
            /// *   The name can contain letters, digits, underscores (_), and hyphens (-) and must start with a letter.
            /// *   The name cannot start with `http://` or `https://`.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// The storage capacity of the unit node that you want to create. Unit: GB. You can adjust the storage capacity in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html). You can also call the DescribeAvailableResource operation to query the storage capacity range that is available for a specific instance type in a region.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            /// <summary>
            /// The storage type of the new instance. Valid values:
            /// 
            /// *   **local_ssd**: local SSDs
            /// *   **cloud_ssd**: standard SSDs
            /// *   **cloud_essd**: PL1 ESSDs
            /// *   **cloud_essd2**: PL2 ESSDs
            /// *   **cloud_essd3**: PL3 ESSD
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// The instance type of the unit node that you want to create. For more information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html). You can call the DescribeAvailableResource operation to query the available instance types in a region.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// The conflict resolution policy based on which Data Transmission Service (DTS) responds to primary key conflicts during data synchronization to the unit node that you want to create. Valid values:
            /// 
            /// *   **overwrite**: DTS overwrites the conflicting primary key on the destination node.
            /// *   **interrupt**: DTS stops the synchronization task, reports an error, and then exits.
            /// *   **ignore**: DTS overwrites the conflicting primary key on the logger node.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DtsConflict")]
            [Validation(Required=false)]
            public string DtsConflict { get; set; }

            /// <summary>
            /// The specifications of the data synchronization task for the unit node that you want to create. Valid values:
            /// 
            /// *   **small**
            /// *   **medium**
            /// *   **large**
            /// *   **micro**
            /// 
            /// >  For more information, see [Specifications of data synchronization instances](https://help.aliyun.com/document_detail/26605.html).
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DtsInstanceClass")]
            [Validation(Required=false)]
            public string DtsInstanceClass { get; set; }

            /// <summary>
            /// The database engine of the unit node that you want to create. Set the value to **MySQL**.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The database engine version of the unit node that you want to create. Valid values:
            /// 
            /// *   **8.0**
            /// *   **5.7**
            /// *   **5.6**
            /// *   **5.5**
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The region ID of the unit node that you want to create. You can call the DescribeRegions operation to query the most recent region list.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// The IP address whitelist of the unit node that you want to create. For more information, see [IP address whitelist](https://help.aliyun.com/document_detail/43185.html). If you want to add more than one entry to the IP address whitelist, separate the entries with commas (,). Each entry must be unique. The IP address whitelist can contain up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:
            /// 
            /// *   IP addresses, such as `10.10.XX.XX`.
            /// *   CIDR blocks, such as `10.10.XX.XX/24`. In this example, **24** indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of **1 to 32**.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// The vSwitch ID of the unit node that you want to create.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID of the unit node that you want to create.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// The zone ID of the unit node that you want to create. You can call the DescribeRegions operation to query zone ID.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// The zone ID of the secondary node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.
            /// 
            /// *   If the value of this parameter is the same as the **zone ID** of the unit node that you want to create, the single-zone deployment method is used.
            /// *   If the value of this parameter is different from the **zone ID** of the unit node that you want to create, the multiple-zone deployment method is used.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// The zone ID of the logger node of the unit node that you want to create. You can call the DescribeRegions operation to query the zone ID.
            /// 
            /// *   If the value of this parameter is the same as the **zone ID** of the unit node that you want to create, the single-zone deployment method is used.
            /// *   If the value of this parameter is different from the **zone ID** of the unit node that you want to create, the multiple-zone deployment method is used.
            /// 
            /// **N** specifies unit node N. The value of N is an integer that ranges from **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
