// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPermApplyOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the permission application ticket.
        /// </summary>
        [NameInMap("PermApplyOrderDetail")]
        [Validation(Required=false)]
        public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail PermApplyOrderDetail { get; set; }
        public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetail : TeaModel {
            /// <summary>
            /// The type of objects on which you apply for permissions. Valid values:
            /// 
            /// *   **DB**: database
            /// *   **TAB**: table
            /// *   **COL**: column
            /// *   **INSTANT**: instance
            /// </summary>
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }

            /// <summary>
            /// The type of permissions that you apply for. Valid values:
            /// 
            /// *   **1**: the permissions to query information
            /// *   **2**: the permissions to export information
            /// *   **3**: the permissions to query and export information
            /// *   **4**: the permissions to modify information
            /// *   **5**: the permissions to query and modify information
            /// *   **6**: the permissions to export and modify information
            /// *   **7**: the permissions to query, export, and modify information
            /// </summary>
            [NameInMap("PermType")]
            [Validation(Required=false)]
            public long? PermType { get; set; }

            /// <summary>
            /// The list of resources.
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources> Resources { get; set; }
            public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResources : TeaModel {
                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("ColumnInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo ColumnInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesColumnInfo : TeaModel {
                    /// <summary>
                    /// The name of the table.
                    /// </summary>
                    [NameInMap("ColumnName")]
                    [Validation(Required=false)]
                    public string ColumnName { get; set; }

                    /// <summary>
                    /// The information about the column.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// The information about the database.
                /// </summary>
                [NameInMap("DatabaseInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo DatabaseInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesDatabaseInfo : TeaModel {
                    /// <summary>
                    /// The ID of the database.
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public long? DbId { get; set; }

                    /// <summary>
                    /// The type of the database engine.
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The nickname of the owner of the database.
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// Indicates whether the database is a logical database. Valid values:
                    /// 
                    /// *   **true**: The database is a logical database.
                    /// *   **false**: The database is not a logical database.
                    /// </summary>
                    [NameInMap("Logic")]
                    [Validation(Required=false)]
                    public bool? Logic { get; set; }

                    /// <summary>
                    /// test@xxxx:3306[test]
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// The ID of the owner of the database.
                    /// </summary>
                    [NameInMap("OwnerNickNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickNames { get; set; }

                    /// <summary>
                    /// The name that is used to search for the database.
                    /// > We recommend that you do not use this parameter for business development. The format of the parameter value may be modified in later versions.
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

                /// <summary>
                /// The name of the column.
                /// </summary>
                [NameInMap("InstanceInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo InstanceInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesInstanceInfo : TeaModel {
                    /// <summary>
                    /// The name that is used to search for the instance.
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The nickname of the owner of the instance.
                    /// </summary>
                    [NameInMap("DbaId")]
                    [Validation(Required=false)]
                    public long? DbaId { get; set; }

                    /// <summary>
                    /// The nickname of the DBA of the instance.
                    /// </summary>
                    [NameInMap("DbaNickName")]
                    [Validation(Required=false)]
                    public string DbaNickName { get; set; }

                    /// <summary>
                    /// The type of the database engine.
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// The type of the environment to which the instance belongs. For more information, see [Change the environment type of an instance](~~163309~~).
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// The information about the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The port that is used to connect to the instance.
                    /// </summary>
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<long?> OwnerIds { get; set; }

                    /// <summary>
                    /// The ID of the owner of the instance.
                    /// </summary>
                    [NameInMap("OwnerNickName")]
                    [Validation(Required=false)]
                    public List<string> OwnerNickName { get; set; }

                    /// <summary>
                    /// The endpoint of the instance.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("SearchName")]
                    [Validation(Required=false)]
                    public string SearchName { get; set; }

                }

                /// <summary>
                /// The type of the environment to which the instance belongs. For more information, see [Change the environment type of an instance](~~163309~~).
                /// </summary>
                [NameInMap("TableInfo")]
                [Validation(Required=false)]
                public GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo TableInfo { get; set; }
                public class GetPermApplyOrderDetailResponseBodyPermApplyOrderDetailResourcesTableInfo : TeaModel {
                    /// <summary>
                    /// The information about the table.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

            /// <summary>
            /// The validity duration of the permissions. Unit: seconds.
            /// </summary>
            [NameInMap("Seconds")]
            [Validation(Required=false)]
            public long? Seconds { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
