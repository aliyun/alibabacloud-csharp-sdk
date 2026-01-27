// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The details of data backup policies.</para>
        /// </summary>
        [NameInMap("AdvanceDataPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvanceDataPolicies> AdvanceDataPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvanceDataPolicies : TeaModel {
            /// <summary>
            /// <para>The type of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATE</b></description></item>
            /// <item><description><b>UPDATE</b></description></item>
            /// <item><description><b>DELETE</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The region in which backup files are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            /// <summary>
            /// <para>The storage method of backup files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>db</b>: database.</description></item>
            /// <item><description><b>level1</b>: level-1 backup.</description></item>
            /// <item><description><b>level2</b>: level-2 backup.</description></item>
            /// <item><description><b>level2Cross</b>: level-2 cross-region backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>level1</para>
            /// </summary>
            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            /// <summary>
            /// <para>The scheduling cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>dayOfWeek</b>: scheduling by week.</description></item>
            /// <item><description><b>dayOfMonth</b>: scheduling by month.</description></item>
            /// <item><description><b>dayOfYear</b>: scheduling by year.</description></item>
            /// <item><description><b>backupInterval</b>: scheduling at a specific interval.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required only when FilterType is set to <b>crontab</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>backupInterval</para>
            /// </summary>
            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            /// <summary>
            /// <para>The scheduling mode of the advanced backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>crontab</b>: periodic scheduling.</description></item>
            /// <item><description><b>event</b>: event-based scheduling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>crontab</para>
            /// </summary>
            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            /// <summary>
            /// <para>The backup cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180</para>
            /// </summary>
            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("OnlyPreserveOneEachDay")]
            [Validation(Required=false)]
            public bool? OnlyPreserveOneEachDay { get; set; }

            /// <summary>
            /// <para>The ID of the advanced backup policy. You can call the <a href="https://help.aliyun.com/document_detail/2869783.html">DescribeBackupPolicy</a> operation to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6s67c7i3y8f8p72808p******</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The retention type of backup sets. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>never</b>: Backup sets never expire.</description></item>
            /// <item><description><b>delay</b>: Backup sets are retained for a specific number of days.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            /// <summary>
            /// <para>The retention period. Unit: day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RetentionValue")]
            [Validation(Required=false)]
            public string RetentionValue { get; set; }

            /// <summary>
            /// <para>The region in which the data source of the backup policy resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            /// <summary>
            /// <para>The type of the data source of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>db</b>: database.</description></item>
            /// <item><description><b>level1</b>: level-1 backup.</description></item>
            /// <item><description><b>level2</b>: level-2 backup.</description></item>
            /// <item><description><b>level2Cross</b>: level-2 cross-region backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>db</para>
            /// </summary>
            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

        }

        [NameInMap("AdvanceIncPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvanceIncPolicies> AdvanceIncPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvanceIncPolicies : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("OnlyPreserveOneEachDay")]
            [Validation(Required=false)]
            public bool? OnlyPreserveOneEachDay { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("RetentionType")]
            [Validation(Required=false)]
            public string RetentionType { get; set; }

            [NameInMap("RetentionValue")]
            [Validation(Required=false)]
            public string RetentionValue { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        [NameInMap("AdvanceLogPolicies")]
        [Validation(Required=false)]
        public List<ModifyBackupPolicyRequestAdvanceLogPolicies> AdvanceLogPolicies { get; set; }
        public class ModifyBackupPolicyRequestAdvanceLogPolicies : TeaModel {
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("DestRegion")]
            [Validation(Required=false)]
            public string DestRegion { get; set; }

            [NameInMap("DestType")]
            [Validation(Required=false)]
            public string DestType { get; set; }

            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public long? EnableLogBackup { get; set; }

            [NameInMap("FilterKey")]
            [Validation(Required=false)]
            public string FilterKey { get; set; }

            [NameInMap("FilterType")]
            [Validation(Required=false)]
            public string FilterType { get; set; }

            [NameInMap("FilterValue")]
            [Validation(Required=false)]
            public string FilterValue { get; set; }

            [NameInMap("LogRetentionType")]
            [Validation(Required=false)]
            public string LogRetentionType { get; set; }

            [NameInMap("LogRetentionValue")]
            [Validation(Required=false)]
            public string LogRetentionValue { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("SrcRegion")]
            [Validation(Required=false)]
            public string SrcRegion { get; set; }

            [NameInMap("SrcType")]
            [Validation(Required=false)]
            public string SrcType { get; set; }

        }

        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("EnableIncBackup")]
        [Validation(Required=false)]
        public bool? EnableIncBackup { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze3nrr64c5****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The start time of a basic backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupWindowBegin")]
        [Validation(Required=false)]
        public string PreferredBackupWindowBegin { get; set; }

        /// <summary>
        /// <para>The region in which backup sets reside.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

    }

}
