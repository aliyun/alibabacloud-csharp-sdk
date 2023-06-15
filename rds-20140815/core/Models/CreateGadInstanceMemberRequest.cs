// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGadInstanceMemberRequest : TeaModel {
        /// <summary>
        /// The ID of the central node. You can call the [DescribeGadInstances](~~330105~~) operation to query the ID of the central node.
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// The username of the privileged account of the central node. You can call the [DescribeAccounts](~~26265~~) operation to query the privileged account of the central node.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// The password of the privileged account of the central node.
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// The region ID of the central node. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// A JSON array that consists of the information about the databases on the central node. All database information that you specify in this array is synchronized to the unit nodes of the global active database cluster. The JSON array contains the following parameters:
        /// 
        /// *   **name**: the name of the database.
        /// *   **all**: specifies whether to synchronize all data in the database or the table. Valid values: **true** and **false**.
        /// *   **Table**: the name of the table. If you set the **all** parameter to **false**, you must nest the name of the table that you want to synchronize into the JSON array.
        /// 
        /// Example: `{ "testdb": { "name": "testdb", "all": false, "Table": { "order": { "name": "order", "all": true }, "ordernew": { "name": "ordernew", "all": true } } } }`
        /// 
        /// >  For more information, see [Objects of DTS tasks](~~209545~~).
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        /// <summary>
        /// The ID of the global active database cluster. You can call the [DescribeGadInstances](~~330105~~) operation to query the ID of the global active database cluster.
        /// </summary>
        [NameInMap("GadInstanceId")]
        [Validation(Required=false)]
        public string GadInstanceId { get; set; }

        /// <summary>
        /// The list of the unit nodes.
        /// </summary>
        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGadInstanceMemberRequestUnitNode> UnitNode { get; set; }
        public class CreateGadInstanceMemberRequestUnitNode : TeaModel {
            /// <summary>
            /// The name of the unit node that you want to create. The name must meet the following requirements:
            /// 
            /// *   The name must be **2 to 255** characters in length.
            /// *   The name can contain letters, digits, underscores (\_), and hyphens (-) and must start with a letter.
            /// *   The name cannot start with `http://` or `https://`.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// The storage capacity of the unit node that you want to create. Unit: GB. You can adjust the storage capacity in increments of 5 GB. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~). You can call the [DescribeAvailableResource](~~134039~~) operation to query the storage capacity range that is supported for a specified instance type in a region.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            /// <summary>
            /// The type of storage media that is used for the instance. Valid values:
            /// 
            /// * **local_ssd**: local SSDs. This is the recommended storage type.
            /// * **cloud_ssd**: standard SSDs.
            /// * **cloud_essd**: enhanced SSDs (ESSDs) of performance level 1 (PL1).
            /// * **cloud_essd2**: ESSDs of PL2.
            /// * **cloud_essd3**: ESSDs of PL3.
            /// </summary>
            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            /// <summary>
            /// The instance type of the unit node that you want to create. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~). You can call the [DescribeAvailableResource](~~134039~~) operation to query the available instance types in a region.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// The conflict resolution policy of the unit node that you want to create. This policy is based on which Data Transmission Service (DTS) responds to primary key conflicts during data synchronization to the new unit node. Valid values:
            /// 
            /// *   **overwrite**: DTS overwrites the conflicting primary key on the destination node.
            /// *   **interrupt**: DTS stops the synchronization task, reports an error, and then exits.
            /// *   **ignore**: DTS overwrites the conflicting primary key on the logger node.
            /// 
            /// **N** in this parameter specifies unit node N. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
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
            /// >  For more information, see [Specifications of data synchronization tasks](~~26605~~).
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("DtsInstanceClass")]
            [Validation(Required=false)]
            public string DtsInstanceClass { get; set; }

            /// <summary>
            /// The database engine of the unit node that you want to create. Set the value to **MySQL**.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
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
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The region ID of the unit node that you want to create. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// The IP address allowlist of the unit node that you want to create. For more information, see [IP address allowlist](~~43185~~). If the IP address allowlist contains more than one entry, separate the entries with commas (,). Each entry must be unique. The IP address allowlist can contain up to 1,000 entries. The entries in the IP address allowlist must be in one of the following formats:
            /// 
            /// *   IP addresses, such as `10.10.XX.XX`.
            /// *   CIDR blocks, such as `10.10.XX.XX/24`. In this example, **24** indicates that the prefix of each IP address in the IP address allowlist is 24 bits in length. You can replace 24 with a value within the range of **1 to 32**.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// The vSwitch ID of the unit node that you want to create.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) ID of the unit node that you want to create.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            /// <summary>
            /// The zone ID of the unit node that you want to create. You can call the [DescribeRegions](~~26243~~) operation to query zone IDs.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            /// <summary>
            /// The zone ID of the secondary node of the unit node that you want to create. You can call the [DescribeRegions](~~26243~~) operation to query zone IDs.
            /// 
            /// *   If the **zone ID** of the unit node that you want to create is the same as the zone ID of its logger node, the single-zone deployment method is used.
            /// *   If the **zone ID** of the unit node that you want to create is different from the zone ID of its logger node, the multiple-zone deployment method is used.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            /// <summary>
            /// The zone ID of the logger node of the unit node that you want to create. You can call the [DescribeRegions](~~26243~~) operation to query zone IDs.
            /// 
            /// *   If the **zone ID** of the unit node that you want to create is the same as the zone ID of its logger node, the single-zone deployment method is used.
            /// *   If the **zone ID** of the unit node that you want to create is different from the zone ID of its logger node, the multiple-zone deployment method is used.
            /// 
            /// **N** in this parameter specifies the Nth unit node. The value of N is an integer within the range of **1 to 10**. You can create up to 10 unit nodes in a global active database cluster.
            /// </summary>
            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
