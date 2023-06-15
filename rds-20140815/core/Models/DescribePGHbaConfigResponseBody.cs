// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePGHbaConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// An array that consists of the default configuration items in the pg_hba.conf file.
        /// </summary>
        [NameInMap("DefaultHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyDefaultHbaItems DefaultHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyDefaultHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyDefaultHbaItemsHbaItem : TeaModel {
                /// <summary>
                /// The IP addresses from which the specified users can access the specified databases. The value is fixed as 0.0.0.0/0.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The names of the databases that the specified users are allowed to access. The value is fixed as all or replication.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The mask of the instance. The value is fixed as null.
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// The authentication method. The value is fixed as md5.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The value of this parameter is based on the value of the Method parameter. The value is fixed as null.
                /// </summary>
                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                /// <summary>
                /// The priority of the configuration items in the pg_hba.conf file. This value is automatically generated.
                /// </summary>
                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                /// <summary>
                /// The type of connection to the instance. The value is fixed as host.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The user that is allowed to access the instance. The value is fixed as all.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

        /// <summary>
        /// The time when the previous modification was made to the pg_hba.conf file.
        /// </summary>
        [NameInMap("HbaModifyTime")]
        [Validation(Required=false)]
        public string HbaModifyTime { get; set; }

        /// <summary>
        /// The status of the previous modification to the pg_hba.conf file.
        /// 
        /// Valid values:
        /// 
        /// *   **success**: The modification is successful.
        /// *   **setting**: The modification is being applied.
        /// *   **failed**: The modification fails.
        /// </summary>
        [NameInMap("LastModifyStatus")]
        [Validation(Required=false)]
        public string LastModifyStatus { get; set; }

        /// <summary>
        /// The reason why the previous modification was made to the pg_hba.conf file.
        /// </summary>
        [NameInMap("ModifyStatusReason")]
        [Validation(Required=false)]
        public string ModifyStatusReason { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the current configuration items in the pg_hba.conf file.
        /// </summary>
        [NameInMap("RunningHbaItems")]
        [Validation(Required=false)]
        public DescribePGHbaConfigResponseBodyRunningHbaItems RunningHbaItems { get; set; }
        public class DescribePGHbaConfigResponseBodyRunningHbaItems : TeaModel {
            [NameInMap("HbaItem")]
            [Validation(Required=false)]
            public List<DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem> HbaItem { get; set; }
            public class DescribePGHbaConfigResponseBodyRunningHbaItemsHbaItem : TeaModel {
                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// The name of the database that the specified users are allowed to access.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The mask of the instance.
                /// </summary>
                [NameInMap("Mask")]
                [Validation(Required=false)]
                public string Mask { get; set; }

                /// <summary>
                /// The authentication method.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The value of this parameter varies based on the value of the Method parameter. The value is fixed as null.
                /// </summary>
                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                /// <summary>
                /// The priority of the instance.
                /// </summary>
                [NameInMap("PriorityId")]
                [Validation(Required=false)]
                public int? PriorityId { get; set; }

                /// <summary>
                /// The type of the connection. 
                /// 
                /// - **host**: The record matches TCP/IP connections, including SSL connections and non-SSL connections.
                /// - **hostssl**: The record matches only TCP/IP connections that are established over SSL.
                /// - **hostnossl**: The record matches only TCP/IP connections that are not established over SSL.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The username of the account that is used to connect to the instance.
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

        }

    }

}
