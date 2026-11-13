// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceCrossBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the cross-region backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BackupEnabled")]
        [Validation(Required=false)]
        public string BackupEnabled { get; set; }

        /// <summary>
        /// <para>The time when cross-region backup was enabled. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-12T05:44:21Z</para>
        /// </summary>
        [NameInMap("BackupEnabledTime")]
        [Validation(Required=false)]
        public string BackupEnabledTime { get; set; }

        /// <summary>
        /// <para>The ID of the destination region for cross-region backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("CrossBackupRegion")]
        [Validation(Required=false)]
        public string CrossBackupRegion { get; set; }

        /// <summary>
        /// <para>The retention type of cross-region backups. Default value: <b>1</b>, which indicates that all backups are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CrossBackupType")]
        [Validation(Required=false)]
        public string CrossBackupType { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 256 characters in length. It must start with a letter or a Chinese character and can contain letters, Chinese characters, digits, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>It cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/26315.html">Instance statuses</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The lock status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
        /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
        /// <item><description><b>LockByExpiration</b>: The instance is automatically locked because it has expired.</description></item>
        /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
        /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage space is exhausted. In this case, the instance is inaccessible.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>Indicates whether cross-region log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("LogBackupEnabled")]
        [Validation(Required=false)]
        public string LogBackupEnabled { get; set; }

        /// <summary>
        /// <para>The time when cross-region log backup was enabled. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-12T05:44:21Z</para>
        /// </summary>
        [NameInMap("LogBackupEnabledTime")]
        [Validation(Required=false)]
        public string LogBackupEnabledTime { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB7667B2-72C8-497B-9BD8-3B343CEF51AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The retention method for cross-region backups. Default value: <b>1</b>, which indicates that backups are retained based on a specified retention period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetentType")]
        [Validation(Required=false)]
        public int? RetentType { get; set; }

        /// <summary>
        /// <para>The retention period of cross-region backups. Valid values: <b>7 to 1825</b>. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

    }

}
