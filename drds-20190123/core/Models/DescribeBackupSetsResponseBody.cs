// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup sets.</para>
        /// </summary>
        [NameInMap("BackupSets")]
        [Validation(Required=false)]
        public DescribeBackupSetsResponseBodyBackupSets BackupSets { get; set; }
        public class DescribeBackupSetsResponseBodyBackupSets : TeaModel {
            [NameInMap("backupSet")]
            [Validation(Required=false)]
            public List<DescribeBackupSetsResponseBodyBackupSetsBackupSet> BackupSet { get; set; }
            public class DescribeBackupSetsResponseBodyBackupSetsBackupSet : TeaModel {
                /// <summary>
                /// <para>Backup Recovery duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-06-05 11:31:38</para>
                /// </summary>
                [NameInMap("BackupConsitentTime")]
                [Validation(Required=false)]
                public string BackupConsitentTime { get; set; }

                /// <summary>
                /// <para>The list of backup databases.</para>
                /// </summary>
                [NameInMap("BackupDbs")]
                [Validation(Required=false)]
                public DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs BackupDbs { get; set; }
                public class DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs : TeaModel {
                    [NameInMap("backupDb")]
                    [Validation(Required=false)]
                    public List<string> BackupDb { get; set; }

                }

                /// <summary>
                /// <para>The end of the backup time which is in timestamp format (measured in millisecond).</para>
                /// <remarks>
                /// <para> 0 indicates not finished.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1591327899000</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public long? BackupEndTime { get; set; }

                /// <summary>
                /// <para>The level of the backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>db: The database level.</description></item>
                /// <item><description>instance: the instance level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("BackupLevel")]
                [Validation(Required=false)]
                public string BackupLevel { get; set; }

                /// <summary>
                /// <para>The backup method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>logic: the logical backup.</description></item>
                /// <item><description>phy: fast backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>logic</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <para>The beginning of the backup time which is in timestamp format (measured in millisecond).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1591327754000</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public long? BackupStartTime { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>93.24</para>
                /// </summary>
                [NameInMap("BackupTotalSize")]
                [Validation(Required=false)]
                public string BackupTotalSize { get; set; }

                /// <summary>
                /// <para>The type of the backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>manual: indicates a manual backup.</description></item>
                /// <item><description>auto: indicates an automatic backup.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set can be restored. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableRecovery")]
                [Validation(Required=false)]
                public bool? EnableRecovery { get; set; }

                /// <summary>
                /// <para>The ID of the data backup file you want to use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ba30d5c4-a6dc-11ea-bd40-************</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The status of the backup instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-1: Failed</description></item>
                /// <item><description>0: Not started</description></item>
                /// <item><description>1: The storage instance is running.</description></item>
                /// <item><description>2: Success</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7103AEE3-9025-442F-B82B-BABD0A******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
