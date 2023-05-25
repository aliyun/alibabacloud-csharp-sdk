// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableTopologyResponseBody : TeaModel {
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

        /// <summary>
        /// The topology information.
        /// </summary>
        [NameInMap("TableTopology")]
        [Validation(Required=false)]
        public GetTableTopologyResponseBodyTableTopology TableTopology { get; set; }
        public class GetTableTopologyResponseBodyTableTopology : TeaModel {
            /// <summary>
            /// Indicates whether the table is a logical table. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The GUID of the table in DMS.
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// Information of the topology of the table.
            /// </summary>
            [NameInMap("TableTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList> TableTopologyInfoList { get; set; }
            public class GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList : TeaModel {
                /// <summary>
                /// The ID of the physical database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// The name that is used to search for the database.
                /// > We recommend that you do not use this parameter for business development. The format of the parameter value may be modified in later versions.
                /// </summary>
                [NameInMap("DbSearchName")]
                [Validation(Required=false)]
                public string DbSearchName { get; set; }

                /// <summary>
                /// The database engine.
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The ID of the instance to which the physical database belongs.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the resource related to the instance. The resource corresponds with the database instance type returned in the InstanceSource parameter.
                /// 
                /// *   **RDS**:The ID of the ApsaraDB RDS instance.
                /// *   **ECS_OWN**: The ID of the Elastic Compute Service (ECS) instance.
                /// *   **PUBLIC_OWN**: This parameter is left empty for self-managed database instances that are connected over the Internet.
                /// *   **VPC_ID**:The ID of the virtual private cloud (VPC).
                /// *   **GATEWAY**: The ID of the database gateway.
                /// </summary>
                [NameInMap("InstanceResourceId")]
                [Validation(Required=false)]
                public string InstanceResourceId { get; set; }

                /// <summary>
                /// The type of the database instance. Valid values:
                /// 
                /// *   **RDS**: an ApsaraDB RDS instance.
                /// *   **ECS_OWN**: a self-managed database that is deployed on an ECS instance
                /// *   **PUBLIC_OWN**: a self-managed database instance that is connected over the Internet.
                /// *   **VPC_ID**: a self-managed database instance in a VPC that is connected over Express Connect circuits.
                /// *   **GATEWAY**: a database instance connected by using a database gateway.
                /// </summary>
                [NameInMap("InstanceSource")]
                [Validation(Required=false)]
                public string InstanceSource { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of tables.
                /// </summary>
                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public long? TableCount { get; set; }

                /// <summary>
                /// The expression of the names of logical tables.
                /// 
                /// **
                /// 
                /// **Description** This parameter is not returned for physical tables.
                /// </summary>
                [NameInMap("TableNameExpr")]
                [Validation(Required=false)]
                public string TableNameExpr { get; set; }

                /// <summary>
                /// The names of tables.
                /// 
                /// > The table names are separated by commas (,).
                /// </summary>
                [NameInMap("TableNameList")]
                [Validation(Required=false)]
                public string TableNameList { get; set; }

            }

        }

    }

}
