// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which data backups are retained. Default value: 7. Valid values: 7 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the data flashback feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled. Make sure that append-only file (AOF) persistence is enabled in the parameter settings of the instance (<c>appendonly</c> is set to <c>yes</c>). The data flashback feature is available only after AOF persistence is enabled.</description></item>
        /// <item><description><b>0</b>: Disabled. This is the default value.<remarks>
        /// <para>This parameter is supported only by Tair (Enterprise Edition) memory-optimized and persistent memory-optimized instances. For more information, see <a href="https://help.aliyun.com/document_detail/148479.html">Data flashback</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify multiple values. Separate them with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tuesday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time. Specify the time in the <i>HH:mm</i>Z-<i>HH:mm</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>The time must be on the hour, and the interval must be 1 hour.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07:00Z-08:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
