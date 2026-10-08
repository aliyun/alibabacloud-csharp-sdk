// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RestoreTableRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID. You can call the DescribeBackups operation to query the backup set list.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>BackupId</b> and <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>902****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
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
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about fast restoration for individual databases and tables, see <a href="https://help.aliyun.com/document_detail/103175.html">Restore individual databases and tables</a>.</para>
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
        /// <para>Any point in time within the backup retention period. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of <b>BackupId</b> and <b>RestoreTime</b>.</description></item>
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
        /// <para>The databases and tables to restore.</para>
        /// <remarks>
        /// <para>ApsaraDB RDS for PostgreSQL supports only the restoration of specific databases, not specific tables.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>ApsaraDB RDS for MySQL format: <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Database 1 name&gt;&quot;,&quot;newname&quot;:&quot;&lt;New database 1 name&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 1 name in database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 1 name&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 2 name in database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 2 name&gt;&quot;}]},{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Database 2 name&gt;&quot;,&quot;newname&quot;:&quot;&lt;New database 2 name&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 3 name in database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 3 name&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 4 name in database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 4 name&gt;&quot;}]}]</c></para>
        /// </description></item>
        /// <item><description><para>ApsaraDB RDS for PostgreSQL format: <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Database 1 name&gt;&quot;,&quot;newname&quot;:&quot;&lt;New database 1 name&gt;&quot;}]</c></para>
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
