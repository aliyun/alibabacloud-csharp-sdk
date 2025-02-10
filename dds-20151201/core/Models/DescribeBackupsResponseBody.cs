// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the backup set.</para>
        /// </summary>
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyBackups Backups { get; set; }
        public class DescribeBackupsResponseBodyBackups : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyBackupsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyBackupsBackup : TeaModel {
                /// <summary>
                /// <para>The name of the database that has been backed up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>database</para>
                /// </summary>
                [NameInMap("BackupDBNames")]
                [Validation(Required=false)]
                public string BackupDBNames { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, an empty string is returned.</para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-14T03:57:34Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32102****</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The internal download URL of the backup set.</para>
                /// <remarks>
                /// <para> You can use the URL to download the specified backup set on an Elastic Compute Service (ECS) instance that is in the same virtual private cloud (VPC) as the ApsaraDB for MongoDB instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The ID of the backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1123xxxx</para>
                /// </summary>
                [NameInMap("BackupJobId")]
                [Validation(Required=false)]
                public string BackupJobId { get; set; }

                /// <summary>
                /// <para>The method that is used to generate the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Snapshot</b></description></item>
                /// <item><description><b>Physical</b></description></item>
                /// <item><description><b>Logical</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Physical</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The backup mode of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Automated</b></description></item>
                /// <item><description><b>Manual</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Automated</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <para>The name of the backup set. The parameter is invalid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678.tar.gz</para>
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// <para>The backup granularity. The parameter is invalid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DBInstance</para>
                /// </summary>
                [NameInMap("BackupScale")]
                [Validation(Required=false)]
                public string BackupScale { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6168576</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-14T03:56:17Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b>: The backup task is successful.</description></item>
                /// <item><description><b>Failed</b>: The backup task failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The backup type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FullBackup</b></description></item>
                /// <item><description><b>IncrementalBackup</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullBackup</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>Version of the backuped instance.</para>
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
                /// <para>Availability of the backup set.</para>
                /// <list type="bullet">
                /// <item><description>0: unavailable</description></item>
                /// <item><description>1: available</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public bool? IsAvail { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>275D43C3-F12F-5224-B375-0C6BF453BD56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of backup sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
