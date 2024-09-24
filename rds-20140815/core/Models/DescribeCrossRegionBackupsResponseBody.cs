// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCrossRegionBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-06-15T12:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The cross-region data backup files.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupsResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupsResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupsResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// <para>The time when the cross-region data backup file was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-15T12:10:00Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The method that is used to generate the cross-region data backup file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>L</b>: logical backup</description></item>
                /// <item><description><b>P</b>: physical backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>P</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The level at which the cross-region data backup file is generated.</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: instance-level backup</description></item>
                /// <item><description><b>1</b>: database-level backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BackupSetScale")]
                [Validation(Required=false)]
                public int? BackupSetScale { get; set; }

                /// <summary>
                /// <para>The status of the cross-region data backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The cross-region data backup is successful.</description></item>
                /// <item><description><b>1</b>: The cross-region data backup failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BackupSetStatus")]
                [Validation(Required=false)]
                public int? BackupSetStatus { get; set; }

                /// <summary>
                /// <para>The time when the cross-region data backup started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-05-30T12:10:00Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The type of the cross-region data backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>F</b>: full data backup</description></item>
                /// <item><description><b>I</b>: incremental data backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>F</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>The RDS edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: RDS Basic Edition.</description></item>
                /// <item><description><b>HighAvailability</b>: RDS High-availability Edition.</description></item>
                /// <item><description><b>Finance</b>: RDS Enterprise Edition. This edition is available only for the China site (aliyun.com).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighAvailability</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The point in time that is indicated by the data in the cross-region data backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-12T05:44:46Z</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                /// <summary>
                /// <para>The external URL from which you can download the cross-region data backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsddrbak-shanghai.oss-cn-shanghai.aliyuncs.com/xxxxx">http://rdsddrbak-shanghai.oss-cn-shanghai.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("CrossBackupDownloadLink")]
                [Validation(Required=false)]
                public string CrossBackupDownloadLink { get; set; }

                /// <summary>
                /// <para>The ID of the cross-region data backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14377</para>
                /// </summary>
                [NameInMap("CrossBackupId")]
                [Validation(Required=false)]
                public int? CrossBackupId { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the cross-region backup files of the instance are stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                /// <summary>
                /// <para>The name of the compressed package that contains the cross-region data backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou_rm-xxxxx_hins81xxx_data_20190612134426_qp.xb</para>
                /// </summary>
                [NameInMap("CrossBackupSetFile")]
                [Validation(Required=false)]
                public string CrossBackupSetFile { get; set; }

                /// <summary>
                /// <para>The location where the cross-region data backup file is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("CrossBackupSetLocation")]
                [Validation(Required=false)]
                public string CrossBackupSetLocation { get; set; }

                /// <summary>
                /// <para>The size of the cross-region data backup file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5312836</para>
                /// </summary>
                [NameInMap("CrossBackupSetSize")]
                [Validation(Required=false)]
                public long? CrossBackupSetSize { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>local_ssd</b>: local SSDs. This is the recommended storage type.</description></item>
                /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
                /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ssd</para>
                /// </summary>
                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
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
                /// <para>The instance ID. This parameter is used to determine whether the instance that generates the cross-region data backup file is a primary or secondary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8161055</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

                /// <summary>
                /// <para>The regions to which the cross-region data backup file can be restored.</para>
                /// </summary>
                [NameInMap("RestoreRegions")]
                [Validation(Required=false)]
                public DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions RestoreRegions { get; set; }
                public class DescribeCrossRegionBackupsResponseBodyItemsItemRestoreRegions : TeaModel {
                    [NameInMap("RestoreRegion")]
                    [Validation(Required=false)]
                    public List<string> RestoreRegion { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of cross-region data backup files on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

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
        /// <para>60912B41-7579-4B5D-B289-8856030F0A6A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T12:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
