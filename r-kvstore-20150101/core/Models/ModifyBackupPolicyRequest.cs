// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which you want to retain data backup files. Valid values: 7 to 730. Default value: 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Enables or disables the data flashback feature for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the data flashback feature. You must also enable AOF persistence by setting <c>appendonly</c> to <c>yes</c> in the parameter settings of the instance. Then, you can use the data flashback feature.</description></item>
        /// <item><description><b>0</b> (default): disables the data flashback feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based and persistent memory-optimized instances. For more information, see <a href="https://help.aliyun.com/document_detail/443784.html">Data flashback</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
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
        /// <para>The days of the week to back up data. Valid values:</para>
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
        /// <para>Separate multiple options with commas (,).</para>
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
        /// <para>The time range to back up data. Specify the time in the <em>HH:mm</em>Z-<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <para>The beginning and end of the time range must be on the hour. The duration must be an hour.</para>
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
