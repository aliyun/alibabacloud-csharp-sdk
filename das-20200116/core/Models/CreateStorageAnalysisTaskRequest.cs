// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateStorageAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// The database name. If you specify a database, the operation analyzes the storage usage of the specified database.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The node ID. For ApsaraDB for MongoDB instances, you can use this parameter to specify a node for storage analysis. You can call the [DescribeRoleZoneInfo](https://help.aliyun.com/document_detail/123802.html) operation to query the information about nodes of an ApsaraDB for MongoDB instance.
        /// 
        /// *   If you set this parameter to a value in the **InsName** format, such as `d-bp1872fa24d5****`, you can call this operation to analyze the hidden node that corresponds to the node ID.
        /// *   If you set this parameter to a value in the `InsName#RoleId` format, such as `d-bp1872fa24d5****#299****5`, you can call this operation to analyze the specified node.
        /// 
        /// >  If you run a storage analysis task on an ApsaraDB for MongoDB replica set instance and you do not specify this parameter, only the hidden node of the instance is analyzed by default. If you run a storage analysis task on an ApsaraDB for MongoDB sharded cluster instance, we recommend that you set this parameter to specify a node.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The table name. If you specify a table in the specified database, the operation analyzes the storage usage of the specified table. If you specify a table, you must also specify the database to which the table belongs by using **DbName**.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
