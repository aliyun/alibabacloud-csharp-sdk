// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyPGHbaConfigRequest : TeaModel {
        /// <summary>
        /// A reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// An array that consists of the details of the AD domain services.
        /// </summary>
        [NameInMap("HbaItem")]
        [Validation(Required=false)]
        public List<ModifyPGHbaConfigRequestHbaItem> HbaItem { get; set; }
        public class ModifyPGHbaConfigRequestHbaItem : TeaModel {
            /// <summary>
            /// The IP addresses from which the specified users can access the specified databases. If you set this parameter to 0.0.0.0/0, the specified users are allowed to access the specified databases from all IP addresses.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The name of the database. If you set this parameter to all, the specified users are allowed to access all databases on the instance.
            /// 
            /// If you specify multiple entries, separate the entries with commas (,).
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The mask of the IP address. If the value of the **Address** parameter is an IP address, you can use this parameter to specify the mask of the IP address.
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// The authentication method. Valid values:
            /// 
            /// *   **trust**
            /// *   **reject**
            /// *   **scram-sha-256**
            /// *   **md5**
            /// *   **password**
            /// *   **gss**
            /// *   **sspi**
            /// *   **ldap**
            /// *   **radius**
            /// *   **cert**
            /// *   **pam**
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// The options of the authentication method. In this topic, LDAP is used as an example. You must configure this parameter. For more information, see [Authentication Methods](https://www.postgresql.org/docs/11/auth-methods.html).
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public string Option { get; set; }

            /// <summary>
            /// The priority of the record. If you set this parameter to 0, the record has the highest priority. Valid values: 0 to 10000.
            /// 
            /// This parameter is used to identify each record. When you add a record, the value of the PriorityId parameter for the new record must be different from the value of the PriorityId parameter of any existing record. When you modify or delete a record, you must also modify or delete the value of the PriorityId parameter for this record.
            /// </summary>
            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }

            /// <summary>
            /// The connection type.
            /// 
            /// Valid values:
            /// 
            /// *   **host**: The record matches TCP/IP connections, including SSL connections and non-SSL connections.
            /// *   **hostssl**: The record matches only TCP/IP connections that are established over SSL.
            /// *   **hostnossl**: The record matches only TCP/IP connections that are not established over SSL connections.
            /// 
            /// >  You can set this parameter to hostssl only when SSL encryption is enabled for the instance. For more information, see Configure SSL encryption for an ApsaraDB RDS for PostgreSQL instance.[](~~229518~~)
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The user who is allowed to access the specified databases. You must specify the user that is used to log on to the RDS instance. If you specify multiple entries, separate the entries with commas (,).
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The method that you use to modify the pg_hba.conf file. Valid values:
        /// 
        /// *   **add**: adds one or more records. If you use this method, make sure that the value of the PriorityId parameter for each new record is different from the value of the PriorityId parameter for any existing record.
        /// *   **delete**: deletes one or more records. If you use this method, the record that corresponds to the specified value of the **PriorityId** parameter is deleted from the pg_hba.conf file.
        /// *   **modify**: modifies one or more records. If you use this method, the record that corresponds to the specified value of the **PriorityId** parameter is modified.
        /// *   **update**: overwrites the existing configuration in the pg_hba.conf file by using the new configuration.
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
