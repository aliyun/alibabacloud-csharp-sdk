// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// The system ID (SID) of the database instance.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The name of the security rule set corresponding to the control mode.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstanceList InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// The type of the environment to which the database instance belongs. Valid values:
                /// 
                /// *   **product**: production environment
                /// *   **dev**: development environment
                /// *   **pre**: staging environment
                /// *   **test**: test environment
                /// *   **sit**: system integration testing (SIT) environment
                /// *   **uat**: user acceptance testing (UAT) environment
                /// *   **pet**: stress testing environment
                /// *   **stag**: STAG environment
                /// </summary>
                [NameInMap("DataLinkName")]
                [Validation(Required=false)]
                public string DataLinkName { get; set; }

                [NameInMap("DatabasePassword")]
                [Validation(Required=false)]
                public string DatabasePassword { get; set; }

                /// <summary>
                /// The account that is used to log on to the database.
                /// </summary>
                [NameInMap("DatabaseUser")]
                [Validation(Required=false)]
                public string DatabaseUser { get; set; }

                /// <summary>
                /// The ID of the ECS instance on which the database instance is deployed.
                /// </summary>
                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                /// <summary>
                /// The ID of the database instance.
                /// </summary>
                [NameInMap("DbaNickName")]
                [Validation(Required=false)]
                public string DbaNickName { get; set; }

                [NameInMap("DdlOnline")]
                [Validation(Required=false)]
                public int? DdlOnline { get; set; }

                /// <summary>
                /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                [NameInMap("EcsRegion")]
                [Validation(Required=false)]
                public string EcsRegion { get; set; }

                /// <summary>
                /// The status of the database instance. Valid values:
                /// 
                /// *   **NORMAL**: normal
                /// *   **DISABLE**: disabled
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("ExportTimeout")]
                [Validation(Required=false)]
                public int? ExportTimeout { get; set; }

                /// <summary>
                /// The ID of the database administrator (DBA) for the database instance.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("InstanceAlias")]
                [Validation(Required=false)]
                public string InstanceAlias { get; set; }

                /// <summary>
                /// The timeout period for exporting data from the database instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether the cross-database query feature is enabled for the database instance. Valid values:
                /// 
                /// *   **0**: disabled
                /// *   **1**: enabled
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// Queries the information about database instances.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The host address that is used to connect to the database instance.
                /// </summary>
                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerIdList OwnerIdList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                /// <summary>
                /// The error message that is returned.
                /// </summary>
                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceOwnerNameList OwnerNameList { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                /// <summary>
                /// The type of the control mode. Valid values:
                /// 
                /// *   **COMMON**: Security Collaboration
                /// *   **NONE_CONTROL**: Flexible Management
                /// *   **STABLE**: Stable Change
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The number of entries to return on each page. The number cannot exceed 100.
                /// </summary>
                [NameInMap("QueryTimeout")]
                [Validation(Required=false)]
                public int? QueryTimeout { get; set; }

                /// <summary>
                /// The password that is used to log on to the database.
                /// </summary>
                [NameInMap("SafeRuleId")]
                [Validation(Required=false)]
                public string SafeRuleId { get; set; }

                [NameInMap("SellSitd")]
                [Validation(Required=false)]
                public bool? SellSitd { get; set; }

                /// <summary>
                /// The name of the database link for the database instance.
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                [NameInMap("StandardGroup")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstanceListInstanceStandardGroup StandardGroup { get; set; }
                public class ListInstancesResponseBodyInstanceListInstanceStandardGroup : TeaModel {
                    [NameInMap("GroupMode")]
                    [Validation(Required=false)]
                    public string GroupMode { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                /// <summary>
                /// The source of the database instance.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The keyword that is used to search for database instances.
                /// </summary>
                [NameInMap("UseDsql")]
                [Validation(Required=false)]
                public int? UseDsql { get; set; }

                /// <summary>
                /// The ID of the region in which the database instance resides.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The control mode of the database instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the database instances that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
