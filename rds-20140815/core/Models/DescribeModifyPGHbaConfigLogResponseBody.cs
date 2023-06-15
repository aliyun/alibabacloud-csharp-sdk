// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeModifyPGHbaConfigLogResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// An array that consists of the modifications to the pg_hba.conf file.
        /// </summary>
        [NameInMap("HbaLogItems")]
        [Validation(Required=false)]
        public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems HbaLogItems { get; set; }
        public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItems : TeaModel {
            [NameInMap("HbaLogItem")]
            [Validation(Required=false)]
            public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem> HbaLogItem { get; set; }
            public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItem : TeaModel {
                /// <summary>
                /// The configuration of the pg_hba.conf file after the modification was made.
                /// </summary>
                [NameInMap("AfterHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems AfterHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemAfterHbaItemsHbaItem : TeaModel {
                        /// <summary>
                        /// The IP address of the instance.
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// The name of the database.
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
                        /// The value of this parameter was set based on the value of the Method parameter.
                        /// </summary>
                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        /// <summary>
                        /// The priority of the configuration item in the pg_hba.conf file.
                        /// </summary>
                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        /// <summary>
                        /// The type of the connection.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The username of the account that was used to connect to the instance.
                        /// </summary>
                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                /// <summary>
                /// The configuration of the pg_hba.conf file before the modification was made.
                /// </summary>
                [NameInMap("BeforeHbaItems")]
                [Validation(Required=false)]
                public DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems BeforeHbaItems { get; set; }
                public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItems : TeaModel {
                    [NameInMap("HbaItem")]
                    [Validation(Required=false)]
                    public List<DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem> HbaItem { get; set; }
                    public class DescribeModifyPGHbaConfigLogResponseBodyHbaLogItemsHbaLogItemBeforeHbaItemsHbaItem : TeaModel {
                        /// <summary>
                        /// The IP address of the instance.
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// The name of the database.
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
                        /// The value of this parameter was set based on the value of the Method parameter.
                        /// </summary>
                        [NameInMap("Option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        /// <summary>
                        /// The priority of the configuration item in the pg_hba.conf file.
                        /// </summary>
                        [NameInMap("PriorityId")]
                        [Validation(Required=false)]
                        public int? PriorityId { get; set; }

                        /// <summary>
                        /// The type of the connection.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The username of the account that was used to connect to the instance.
                        /// </summary>
                        [NameInMap("User")]
                        [Validation(Required=false)]
                        public string User { get; set; }

                    }

                }

                /// <summary>
                /// The status of the modification.
                /// 
                /// *   **success**: The modification is successful.
                /// *   **failed**: The modification failed.
                /// *   **setting**: The modification is being applied.
                /// </summary>
                [NameInMap("ModifyStatus")]
                [Validation(Required=false)]
                public string ModifyStatus { get; set; }

                /// <summary>
                /// The time when the pg_hba.conf file was modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The reason why the modification failed.
                /// </summary>
                [NameInMap("StatusReason")]
                [Validation(Required=false)]
                public string StatusReason { get; set; }

            }

        }

        /// <summary>
        /// The number of modification records.
        /// </summary>
        [NameInMap("LogItemCount")]
        [Validation(Required=false)]
        public int? LogItemCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
