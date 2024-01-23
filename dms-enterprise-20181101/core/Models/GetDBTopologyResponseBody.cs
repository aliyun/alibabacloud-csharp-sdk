// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// The topology of the data table.
        /// </summary>
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetDBTopologyResponseBodyDBTopology : TeaModel {
            /// <summary>
            /// The alias of the access point.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The list of database splitting topology information.
            /// </summary>
            [NameInMap("DBTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList> DBTopologyInfoList { get; set; }
            public class GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList : TeaModel {
                /// <summary>
                /// The name of the catalog to which the database belongs.
                /// 
                /// > If the database is a PostgreSQL database, the value of this parameter is the name of the database.
                /// </summary>
                [NameInMap("CatalogName")]
                [Validation(Required=false)]
                public string CatalogName { get; set; }

                /// <summary>
                /// The ID of the database for which the schema design is executed.
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
                /// The type of the environment to which the database belongs. Valid values:
                /// 
                /// *   product: production environment
                /// *   dev: development environment
                /// *   pre: staging environment
                /// *   test: test environment
                /// *   sit: SIT environment
                /// *   uat: user acceptance testing (UAT) environment
                /// *   pet: stress testing environment
                /// *   stag: STAG environment
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The ID of the instance. The valid value is returned if you call the ListInstances operation. The instance ID is not the ID of the RDS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// Instance resource ID.
                /// </summary>
                [NameInMap("InstanceResourceId")]
                [Validation(Required=false)]
                public string InstanceResourceId { get; set; }

                /// <summary>
                /// The source of the database instance. Valid values:
                /// 
                /// *   **PUBLIC_OWN:** a self-managed database instance that is deployed on the Internet
                /// *   **RDS:** an ApsaraDB RDS instance
                /// *   **ECS_OWN:** a self-managed database that is deployed on an Elastic Compute Service (ECS) instance
                /// *   **VPC_IDC:** a self-managed database instance that is deployed in a data center connected over a virtual private cloud (VPC)
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// The ID of the region in which the instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the logical database.
                /// 
                /// > If the database is a PostgreSQL database, the value of this parameter is the name of the database schema.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The name of the saved search.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The type of the database engine.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The type of the environment in which the database instance is deployed. Valid values:
            /// 
            /// *   product: production environment
            /// *   dev: development environment
            /// *   pre: pre-release environment
            /// *   test: test environment
            /// *   sit: system integration testing (SIT) environment
            /// *   uat: user acceptance testing (UAT) environment
            /// *   pet: stress testing environment
            /// *   stag: staging environment
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// The ID of the logical database.
            /// </summary>
            [NameInMap("LogicDbId")]
            [Validation(Required=false)]
            public long? LogicDbId { get; set; }

            /// <summary>
            /// Logical database name.
            /// </summary>
            [NameInMap("LogicDbName")]
            [Validation(Required=false)]
            public string LogicDbName { get; set; }

            /// <summary>
            /// The name of the saved search.
            /// </summary>
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// The error code.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
