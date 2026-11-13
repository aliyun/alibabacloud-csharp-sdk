// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RestoreTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set. You can call the DescribeBackups operation to query backup sets.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>BackupId</b> and <b>RestoreTime</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>902****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, and you must ensure that the value is unique among different requests. The value can be up to 64 ASCII characters in length and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable fast restoration for individual databases and tables. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables fast restoration.</description></item>
        /// <item><description><b>false</b>: disables fast restoration.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about fast restoration for individual databases and tables, see <a href="https://help.aliyun.com/document_detail/103175.html">Restore databases and tables</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InstantRecovery")]
        [Validation(Required=false)]
        public bool? InstantRecovery { get; set; }

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
        /// <para>The point in time to which you want to restore data. The point in time must be within the backup retention period. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of the <b>BackupId</b> and <b>RestoreTime</b> parameters.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/98818.html">Log backup</a> must be enabled for the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The databases and tables to be restored.</para>
        /// <remarks>
        /// <para>ApsaraDB RDS for PostgreSQL supports restoring only specific databases and does not support restoring specific tables.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Format for ApsaraDB RDS for MySQL: <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Name of Database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Database 1&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Name of Table 1 in Database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Table 1&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Name of Table 2 in Database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Table 2&gt;&quot;}]},{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Name of Database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Database 2&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Name of Table 3 in Database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Table 3&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Name of Table 4 in Database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Table 4&gt;&quot;}]}]</c></para>
        /// </description></item>
        /// <item><description><para>Format for ApsaraDB RDS for PostgreSQL: <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Name of Database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New name of Database 1&gt;&quot;}]</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;testdb1&quot;,&quot;newname&quot;:&quot;testdb1_new&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;testdb1table1&quot;,&quot;newname&quot;:&quot;testdb1table1_new&quot;}]}]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

    }

}
