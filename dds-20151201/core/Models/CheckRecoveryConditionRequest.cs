// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckRecoveryConditionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/62172.html">DescribeBackups</a> operation to query the backup ID.</description></item>
        /// <item><description>You must specify either this parameter or the <b>RestoreTime</b> parameter.</description></item>
        /// <item><description>This parameter is not supported for sharded cluster instances.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5664****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The names of the databases to be restored. The value is a JSON array.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, all databases are restored by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;db1&quot;,&quot;db2&quot;]</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// <para>The area where the backup set resides during geo-redundancy recover.</para>
        /// <remarks>
        /// <para>This parameter is required when the backup recover type is geo-redundancy cloning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>The database version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8.0</b></description></item>
        /// <item><description><b>7.0</b></description></item>
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4.2</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>replicate </description></item>
        /// <item><description>sharding</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the backup recover type is rebuilding a deleted instance.</description></item>
        /// <item><description>This parameter is required when the backup recover type is geo-redundancy cloning.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>replicate</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp179****</para>
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
        /// <para>The point in time to which you want to restore the instance. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value can be any point in time within the last seven days. The value must be earlier than the current time and later than the creation time of the instance.</description></item>
        /// <item><description>You must specify either this parameter or the <b>BackupId</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The backup recover type. Valid values:</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>0: local backup recover</description></item>
        /// <item><description>1: local point-in-time recover</description></item>
        /// <item><description>2: backup recover of a deleted instance using a backup set</description></item>
        /// <item><description>3: geo-redundancy backup recover using a backup set</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The instance ID of the source instance to recover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1378****</para>
        /// </summary>
        [NameInMap("SourceDBInstance")]
        [Validation(Required=false)]
        public string SourceDBInstance { get; set; }

        /// <summary>
        /// <para>The area where the source instance resides.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when the backup recover type is rebuilding a deleted instance.</description></item>
        /// <item><description>This parameter is required when the backup recover type is geo-redundancy cloning.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
