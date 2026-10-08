// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RestoreDdrTableRequest : TeaModel {
        /// <summary>
        /// <para>The cross-region backup set ID. You can call the DescribeCrossRegionBackups operation to query the backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>279563</para>
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
        /// <para>The instance ID of the existing instance to which you want to recover data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the destination region. You can call the DescribeRegions operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. The point in time must be earlier than the current time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-04-25T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: restores data from a backup set. You must also specify the <b>BackupId</b> parameter.</description></item>
        /// <item><description><b>1</b>: restores data to a point in time. You must also specify the <b>RestoreTime</b>, <b>SourceRegion</b>, and <b>SourceDBInstanceName</b> parameters.</description></item>
        /// </list>
        /// <para>Default value: <b>0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The instance ID of the source instance from which you want to recover data to a point in time.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp****</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID of the source instance for point-in-time restoration.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The databases and tables that you want to restore. Format:
        /// <c>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Database 1 name&gt;&quot;,&quot;newname&quot;:&quot;&lt;New database 1 name&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 1 name in database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 1 name&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 2 name in database 1&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 2 name&gt;&quot;}]},{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;&lt;Database 2 name&gt;&quot;,&quot;newname&quot;:&quot;&lt;New database 2 name&gt;&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 3 name in database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 3 name&gt;&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;&lt;Table 4 name in database 2&gt;&quot;,&quot;newname&quot;:&quot;&lt;New table 4 name&gt;&quot;}]}]</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;db&quot;,&quot;name&quot;:&quot;testdb1&quot;,&quot;newname&quot;:&quot;testdb1&quot;,&quot;tables&quot;:[{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;test1&quot;,&quot;newname&quot;:&quot;test1_backup&quot;},{&quot;type&quot;:&quot;table&quot;,&quot;name&quot;:&quot;test2&quot;,&quot;newname&quot;:&quot;test2_backup&quot;}]}]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

    }

}
