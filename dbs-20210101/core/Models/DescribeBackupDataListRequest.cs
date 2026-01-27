// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeBackupDataListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>213064****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Physical</b></description></item>
        /// <item><description><b>Logical</b></description></item>
        /// <item><description><b>Snapshot</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Snapshot</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
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
        /// <para>The backup scale. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DBInstance</b></description></item>
        /// <item><description><b>DBTable</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DBInstance</para>
        /// </summary>
        [NameInMap("BackupScale")]
        [Validation(Required=false)]
        public string BackupScale { get; set; }

        /// <summary>
        /// <para>The status of the backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The backup succeeded.</description></item>
        /// <item><description><b>ERROR</b>: The backup failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullBackup</b></description></item>
        /// <item><description><b>IncrementBackup</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullBackup</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>This is a reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test****</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The time follows the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-17T17:00:32Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the cluster is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstanceIsDeleted")]
        [Validation(Required=false)]
        public bool? InstanceIsDeleted { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB for MySQL cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze3nrr64c5******</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region in which the original cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegion")]
        [Validation(Required=false)]
        public string InstanceRegion { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the backup set resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// <para>The type of the backup scenario. Set the value to <b>LEVEL_1</b>, which indicates the level-1 backup of the region in which the PolarDB for MySQL cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LEVEL_1</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-17T17:00:16Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
