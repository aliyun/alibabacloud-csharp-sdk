// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The username of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pass****</para>
        /// </summary>
        [NameInMap("AccountPassword")]
        [Validation(Required=false)]
        public string AccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether the database is manually added by the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The database is manually added.</description></item>
        /// <item><description><b>false</b>: The database is not manually added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DatabaseAddByUser")]
        [Validation(Required=false)]
        public string DatabaseAddByUser { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MYSQL</b></description></item>
        /// <item><description><b>ORACLE</b></description></item>
        /// <item><description><b>MSSQL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// <para>The full backup policy. The value is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start time of the backup.</description></item>
        /// <item><description><b>interval</b>: the interval between backups.</description></item>
        /// <item><description><b>type</b>: the unit of the interval.</description></item>
        /// <item><description><b>days</b>: the days of the week on which backups are performed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;days&quot;:[4],&quot;interval&quot;:1,&quot;planType&quot;:&quot;weekly&quot;,&quot;startTime&quot;:&quot;22:00:00&quot;}</para>
        /// </summary>
        [NameInMap("FullPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> FullPlan { get; set; }

        /// <summary>
        /// <para>The incremental backup policy. The value is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: the start time of the backup.</description></item>
        /// <item><description><b>interval</b>: the interval between backups.</description></item>
        /// <item><description><b>type</b>: the unit of the interval.</description></item>
        /// <item><description><b>days</b>: the days of the week on which backups are performed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;interval&quot;:1,&quot;planType&quot;:&quot;daily&quot;,&quot;startTime&quot;:&quot;23:30:00&quot;}</para>
        /// </summary>
        [NameInMap("IncPlan")]
        [Validation(Required=false)]
        public Dictionary<string, object> IncPlan { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeUniBackupDatabase~~">DescribeUniBackupDatabase</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1fu4aqltf1huhc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the anti-ransomware backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql-policy</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The number of days for which backup data is retained.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// <para>The network bandwidth throttling for backup network bandwidth. Unit: bytes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5242880</para>
        /// </summary>
        [NameInMap("SpeedLimiter")]
        [Validation(Required=false)]
        public long? SpeedLimiter { get; set; }

        /// <summary>
        /// <para>The region in which the server protected by the backup policy resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

        /// <summary>
        /// <para>The UUID of the server that is backed up by the database anti-ransomware feature.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to obtain the UUID of the server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>045cad48-eb08-4047-a70c-713aec7b****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
