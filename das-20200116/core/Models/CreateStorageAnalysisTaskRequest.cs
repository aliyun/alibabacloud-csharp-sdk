// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateStorageAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <para>The database name. If you specify a database, the operation analyzes the storage usage of the specified database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb01</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID. For ApsaraDB for MongoDB instances, you can use this parameter to specify a node for storage analysis. You can call the <a href="https://help.aliyun.com/document_detail/123802.html">DescribeRoleZoneInfo</a> operation to query the information about nodes of an ApsaraDB for MongoDB instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to a value in the <b>InsName</b> format, such as <c>d-bp1872fa24d5****</c>, you can call this operation to analyze the hidden node that corresponds to the node ID.</description></item>
        /// <item><description>If you set this parameter to a value in the <c>InsName#RoleId</c> format, such as <c>d-bp1872fa24d5****#299****5</c>, you can call this operation to analyze the specified node.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you run a storage analysis task on an ApsaraDB for MongoDB replica set instance and you do not specify this parameter, only the hidden node of the instance is analyzed by default. If you run a storage analysis task on an ApsaraDB for MongoDB sharded cluster instance, we recommend that you set this parameter to specify a node.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23302528</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The table name. If you specify a table in the specified database, the operation analyzes the storage usage of the specified table. If you specify a table, you must also specify the database to which the table belongs by using <b>DbName</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
