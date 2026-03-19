// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyStorageStrategyRequest : TeaModel {
        /// <summary>
        /// <para>Backup plan ID. Obtain this parameter\&quot;s value by calling the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbsqdss5tmh****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>Backup data retention period, in days. Valid values: 0 to 1825.</para>
        /// <remarks>
        /// <para>Default value: 730 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>encrypted</para>
        /// </summary>
        [NameInMap("BackupStorageEncryptMethod")]
        [Validation(Required=false)]
        public string BackupStorageEncryptMethod { get; set; }

        /// <summary>
        /// <para>An arbitrary string used to ensure the idempotence of the request and prevent duplicate submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstest</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Time to convert to Archive Storage. This value must be less than the backup data retention period (BackupRetentionPeriod parameter). For more information about Archive Storage, see <a href="https://help.aliyun.com/document_detail/51374.html">Storage Type Overview</a>.</para>
        /// <remarks>
        /// <para>Default value: 365 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>366</para>
        /// </summary>
        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <para>Time to convert to Infrequent Access storage. This value must be less than the Archive Storage period (DuplicationArchivePeriod parameter). For more information about Infrequent Access storage, see <a href="https://help.aliyun.com/document_detail/51374.html">Storage Type Overview</a>.</para>
        /// <remarks>
        /// <para>Default value: 180 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>190</para>
        /// </summary>
        [NameInMap("DuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public int? DuplicationInfrequentAccessPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("IncrementBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string IncrementBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("IncrementDuplicationArchivePeriod")]
        [Validation(Required=false)]
        public string IncrementDuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("IncrementDuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public string IncrementDuplicationInfrequentAccessPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("LogDuplicationArchivePeriod")]
        [Validation(Required=false)]
        public string LogDuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("LogDuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public string LogDuplicationInfrequentAccessPeriod { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
