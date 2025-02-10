// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckRecoveryConditionRequest : TeaModel {
        /// <summary>
        /// <para>The backup ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/62172.html">DescribeBackups</a> operation to query the backup ID.</description></item>
        /// <item><description>You must specify one of the <b>RestoreTime</b> and BackupId parameters.</description></item>
        /// <item><description>This parameter is not applicable to sharded cluster instances.</description></item>
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
        /// <para>The name of the source database. The value is a JSON array.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, all databases are restored by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;db1&quot;,&quot;db2&quot;]</para>
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// <para>The region of the backup set used for the cross-region backup and restoration.</para>
        /// <remarks>
        /// <para> This parameter is required when you set the RestoreType parameter to 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// <list type="bullet">
        /// <item><description><b>6.0</b></description></item>
        /// <item><description><b>5.0</b></description></item>
        /// <item><description><b>4.4</b></description></item>
        /// <item><description><b>4.2</b></description></item>
        /// <item><description><b>4.0</b></description></item>
        /// <item><description><b>3.4</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4.2</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>replicate</description></item>
        /// <item><description>sharding</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you set the RestoreType parameter to 2.</description></item>
        /// <item><description>This parameter is required when you set the RestoreType parameter to 3.</description></item>
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
        /// <para>The ID of the resource group to which the instance belongs.</para>
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
        /// <para>The point in time to which the instance is restored. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The time can be a point in time within the past seven days. The time must be earlier than the current time, but later than the time when the instance was created.</description></item>
        /// <item><description>You must specify one of the RestoreTime and <b>BackupId</b> parameters.</description></item>
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
        /// <para>The restoration type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>0: The data of the source instance is restored to a new instance in the same region.</description></item>
        /// <item><description>1: The data of the source instance is restored to an earlier point in time.</description></item>
        /// <item><description>2: The data of a deleted instance is restored to a new instance from the backup set.</description></item>
        /// <item><description>3: The data of a deleted instance is restored to a new instance in another region from the backup set.</description></item>
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
        /// <para>The ID of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1378****</para>
        /// </summary>
        [NameInMap("SourceDBInstance")]
        [Validation(Required=false)]
        public string SourceDBInstance { get; set; }

        /// <summary>
        /// <para>The region where the source instance resides.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required when you set the RestoreType parameter to 2.</description></item>
        /// <item><description>This parameter is required when you set the RestoreType parameter to 3.</description></item>
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
