// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup compression method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no compression.</description></item>
        /// <item><description><b>1</b>: zlib compression.</description></item>
        /// <item><description><b>2</b>: parallel zlib compression.</description></item>
        /// <item><description><b>4</b>: quicklz compression. Database and table restoration is enabled.</description></item>
        /// <item><description><b>8</b>: quicklz compression for MySQL 8.0. Database and table restoration is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public string DBInstanceID { get; set; }

        /// <summary>
        /// <para>Indicates whether instance log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled.</description></item>
        /// <item><description><b>0</b>: shutdown.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Instance log backup is enabled by default and cannot be shut down for ApsaraDB RDS for SQL Server instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Indicates whether incremental backup is enabled.</para>
        /// </summary>
        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        /// <summary>
        /// <para>Indicates whether point-in-time recovery (PITR) is enabled for the ApsaraDB RDS for MySQL instance.</para>
        /// </summary>
        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        /// <summary>
        /// <para>Indicates whether binary log files are unconditionally deleted when the storage usage of the <b>ApsaraDB RDS for MySQL</b> instance exceeds 80% or the remaining storage space is less than 5 GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        /// <summary>
        /// <para>The high-frequency incremental backup interval. Unit: minutes. Valid values: 60, 120, 240, 360, and 720.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("IncBackupInterval")]
        [Validation(Required=false)]
        public int? IncBackupInterval { get; set; }

        /// <summary>
        /// <para>The number of hours for which instance log backups are retained locally on the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        /// <summary>
        /// <para>The maximum loop space usage of the local binary log on the <b>MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        /// <summary>
        /// <para>The number of binary log files retained locally on the <b>ApsaraDB RDS for MySQL</b> instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA147739-AEAD-4417-9089-65E9B1D8240D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
