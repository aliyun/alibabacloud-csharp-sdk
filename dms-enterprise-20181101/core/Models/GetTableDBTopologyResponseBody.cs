// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// The topology of the data table.
        /// </summary>
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetTableDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetTableDBTopologyResponseBodyDBTopology : TeaModel {
            /// <summary>
            /// The data sources.
            /// </summary>
            [NameInMap("DataSourceList")]
            [Validation(Required=false)]
            public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceList> DataSourceList { get; set; }
            public class GetTableDBTopologyResponseBodyDBTopologyDataSourceList : TeaModel {
                /// <summary>
                /// The physical databases.
                /// </summary>
                [NameInMap("DatabaseList")]
                [Validation(Required=false)]
                public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList> DatabaseList { get; set; }
                public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList : TeaModel {
                    /// <summary>
                    /// The ID of the database.
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public string DbId { get; set; }

                    /// <summary>
                    /// The name of the database.
                    /// </summary>
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    /// <summary>
                    /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](https://help.aliyun.com/document_detail/198106.html).
                    /// </summary>
                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    /// <summary>
                    /// The type of the environment to which the database belongs. Valid values:
                    /// 
                    /// *   **product**: production environment
                    /// *   **dev**: development environment
                    /// *   **pre**: pre-release environment
                    /// *   **test**: test environment
                    /// *   **sit**: system integration testing (SIT) environment
                    /// *   **uat**: user acceptance testing (UAT) environment
                    /// *   **pet**: stress testing environment
                    /// *   **stag**: staging environment
                    /// 
                    /// > For more information, see [Change the environment type of an instance](https://help.aliyun.com/document_detail/163309.html).
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// The physical tables.
                    /// </summary>
                    [NameInMap("TableList")]
                    [Validation(Required=false)]
                    public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList> TableList { get; set; }
                    public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList : TeaModel {
                        /// <summary>
                        /// The ID of the table.
                        /// </summary>
                        [NameInMap("TableId")]
                        [Validation(Required=false)]
                        public string TableId { get; set; }

                        /// <summary>
                        /// The name of the physical table.
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                        /// <summary>
                        /// The type of the table. This is a reserved parameter.
                        /// </summary>
                        [NameInMap("TableType")]
                        [Validation(Required=false)]
                        public string TableType { get; set; }

                    }

                }

                /// <summary>
                /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](https://help.aliyun.com/document_detail/198106.html).
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The endpoint of the data source.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The port that is used to connect to the data source.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The system ID (SID) of the data source.
                /// </summary>
                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

            }

            /// <summary>
            /// The GUID of the table in DMS.
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// The name of the table.
            /// 
            /// > 
            /// 
            /// *   If a logical table is queried, the name of the logical table is returned.
            /// 
            /// *   If a physical table is queried, the name of the physical table is returned.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
