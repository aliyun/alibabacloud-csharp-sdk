// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RestoreTableRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required if you want to restore the destination databases and tables from a backup set. You can call the <a href="https://help.aliyun.com/document_detail/98102.html">DescribeBackups</a> operation to query the backup set ID.</para>
        /// </remarks>
        /// <remarks>
        /// <para>To obtain the backup set ID, call the DescribeBackups operation and specify the StartTime and EndTime parameters. Then, call the DescribeMetaList operation to obtain the metadata of the restorable databases and tables. Operation description: Dependency chain description: To obtain the BackupId, you must call the DescribeBackups operation (the StartTime and EndTime parameters are required). To obtain the database and table names required for TableMeta, you must call the DescribeMetaList operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters within your account.</para>
        /// </remarks>
        /// <remarks>
        /// <para>The destination cluster must be in the Running state. You can call the DescribeDBClusterAttribute operation to query the current state. Operation description: Status prerequisite: The cluster must be in the Running state. You can call the DescribeDBClusterAttribute operation to query the current state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore the data. Specify the time in the YYYY-MM-DDThh:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required if you want to restore data to a specific point in time.</description></item>
        /// <item><description>You can restore data to any point in time within the last seven days.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-04T01:40:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The JSON string that contains the information about the destination databases and tables to be restored. All values in the database and table information are of the string type.
        /// Example: <c>[    {        &quot;tables&quot;:[            {                &quot;name&quot;:&quot;testtb&quot;,                &quot;type&quot;:&quot;table&quot;,                &quot;newname&quot;:&quot;testtb_restore&quot;            }        ],        &quot;name&quot;:&quot;testdb&quot;,        &quot;type&quot;:&quot;db&quot;,        &quot;newname&quot;:&quot;testdb_restore&quot;    } ]</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/194770.html">DescribeMetaList</a> operation to view the details of the databases and tables that can be restored, and fill in the restorable database and table information in the corresponding positions in the preceding example.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;tables&quot;:[ { &quot;name&quot;:&quot;testtb&quot;, &quot;type&quot;:&quot;table&quot;, &quot;newname&quot;:&quot;testtb_restore&quot; } ], &quot;name&quot;:&quot;testdb&quot;, &quot;type&quot;:&quot;db&quot;, &quot;newname&quot;:&quot;testdb_restore&quot; } ]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

    }

}
