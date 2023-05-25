// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// The topology of the logical database.
        /// </summary>
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetDBTopologyResponseBodyDBTopology : TeaModel {
            /// <summary>
            /// The alias of the logical database.
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// The topologies of the physical database shards.
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
                /// The ID of the logical database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of the environment to which the logical database belongs. Valid values:
                /// 
                /// *   **product**: production environment
                /// *   **dev**: development environment
                /// *   **pre**: pre-release environment
                /// *   **test**: test environment
                /// *   **sit**: SIT environment
                /// *   **uat**: UAT environment
                /// *   **pet**: stress testing environment
                /// *   **stag**: staging environment
                /// 
                /// > For more information, see [Change the environment type of an instance](~~163309~~).
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// The ID of the instance in which the logical database resides.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the resource related to the instance. The resource corresponds with the database instance type returned in the InstanceSource parameter.
                /// 
                /// *   If the value of the InstanceSource parameter is RDS, the ID of an ApsaraDB RDS instance is returned.
                /// *   If the value of the InstanceSource parameter is ECS_OWN, the ID of a self-managed database that is hosted on an Elastic Compute Service (ECS) instance is returned.
                /// *   If the value of the InstanceSource parameter is PUBLIC_OWN, an empty string is returned.
                /// *   If the value of the InstanceSource parameter is VPC_ID, the ID of a self-managed database instance in a virtual private cloud (VPC) that is connected over Express Connect circuits is returned.
                /// *   If the value of the InstanceSource parameter is GATEWAY, the ID of a database instance connected by using a database gateway is returned.
                /// </summary>
                [NameInMap("InstanceResourceId")]
                [Validation(Required=false)]
                public string InstanceResourceId { get; set; }

                /// <summary>
                /// The type of the database instance. Valid values:
                /// 
                /// *   **RDS**: an ApsaraDB RDS instance.
                /// *   **ECS_OWN**: a self-managed database that is hosted on an ECS instance.
                /// *   **PUBLIC_OWN**: a self-managed database instance that is connected over the Internet.
                /// *   **VPC_ID**: a self-managed database instance in a VPC that is connected over Express Connect circuits.
                /// *   **GATEWAY**: a database instance connected by using a database gateway.
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
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The type of the environment to which the logical database belongs. Valid values:
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
            /// > For more information, see [Change the environment type of an instance](~~163309~~).
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
            /// The name of the logical database.
            /// </summary>
            [NameInMap("LogicDbName")]
            [Validation(Required=false)]
            public string LogicDbName { get; set; }

            /// <summary>
            /// The name that is used to search for the logical database.
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
