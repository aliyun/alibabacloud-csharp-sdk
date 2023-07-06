// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message that is returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the database instance.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// The name of the database link for the database instance.
            /// </summary>
            [NameInMap("DataLinkName")]
            [Validation(Required=false)]
            public string DataLinkName { get; set; }

            /// <summary>
            /// The password that is used to log on to the database.
            /// </summary>
            [NameInMap("DatabasePassword")]
            [Validation(Required=false)]
            public string DatabasePassword { get; set; }

            /// <summary>
            /// The account that is used to log on to the database instance.
            /// </summary>
            [NameInMap("DatabaseUser")]
            [Validation(Required=false)]
            public string DatabaseUser { get; set; }

            /// <summary>
            /// The ID of the database administrator (DBA) for the database instance.
            /// </summary>
            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            /// <summary>
            /// The nickname of the DBA for the database instance.
            /// </summary>
            [NameInMap("DbaNickName")]
            [Validation(Required=false)]
            public string DbaNickName { get; set; }

            /// <summary>
            /// Indicates whether the lock-free schema change feature is enabled for the database instance.
            /// </summary>
            [NameInMap("DdlOnline")]
            [Validation(Required=false)]
            public int? DdlOnline { get; set; }

            /// <summary>
            /// The ID of the Elastic Compute Service (ECS) instance on which the database instance is deployed.
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// The ID of the region in which the database instance resides.
            /// </summary>
            [NameInMap("EcsRegion")]
            [Validation(Required=false)]
            public string EcsRegion { get; set; }

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
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// The timeout period for exporting data from the database instance.
            /// </summary>
            [NameInMap("ExportTimeout")]
            [Validation(Required=false)]
            public int? ExportTimeout { get; set; }

            /// <summary>
            /// The host address that is used to connect to the database instance.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The alias of the database instance.
            /// </summary>
            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            /// <summary>
            /// The ID of the database instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The source of the database instance.
            /// </summary>
            [NameInMap("InstanceSource")]
            [Validation(Required=false)]
            public string InstanceSource { get; set; }

            /// <summary>
            /// The type of the database instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The IDs of the owners for the database instance.
            /// </summary>
            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerIdList OwnerIdList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            /// <summary>
            /// The nicknames of the owners for the database instance.
            /// </summary>
            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceOwnerNameList OwnerNameList { get; set; }
            public class GetInstanceResponseBodyInstanceOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            /// <summary>
            /// The port number that is used to connect to the database instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The timeout period for querying data in the database instance.
            /// </summary>
            [NameInMap("QueryTimeout")]
            [Validation(Required=false)]
            public int? QueryTimeout { get; set; }

            /// <summary>
            /// The ID of the security rule set for the database instance.
            /// </summary>
            [NameInMap("SafeRuleId")]
            [Validation(Required=false)]
            public string SafeRuleId { get; set; }

            /// <summary>
            /// Whether sensitive data protection is enabled.  Valid values:
            /// 
            /// - **true**: Enable.
            /// 
            /// - **false**: Close.
            /// </summary>
            [NameInMap("SellSitd")]
            [Validation(Required=false)]
            public string SellSitd { get; set; }

            /// <summary>
            /// The SID of the database instance.
            /// </summary>
            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            /// <summary>
            /// The control mode of the database instance.
            /// </summary>
            [NameInMap("StandardGroup")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceStandardGroup StandardGroup { get; set; }
            public class GetInstanceResponseBodyInstanceStandardGroup : TeaModel {
                /// <summary>
                /// The type of the control mode. Valid values:
                /// 
                /// *   **COMMON**: Security Collaboration
                /// *   **NONE_CONTROL**: Flexible Management
                /// *   **STABLE**: Stable Change
                /// </summary>
                [NameInMap("GroupMode")]
                [Validation(Required=false)]
                public string GroupMode { get; set; }

                /// <summary>
                /// The name of the security rule set corresponding to the control mode.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// The status of the database instance. Valid values:
            /// 
            /// *   **NORMAL**: normal
            /// *   **DISABLE**: disabled
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// Indicates whether the cross-database query feature is enabled for the database instance. Valid values:
            /// 
            /// *   **0**: disabled
            /// *   **1**: enabled
            /// </summary>
            [NameInMap("UseDsql")]
            [Validation(Required=false)]
            public int? UseDsql { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC) to which the database instance belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// - **true**: The request was successful.
        /// - **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
