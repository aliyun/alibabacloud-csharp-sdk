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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeCrossRegionBackupsResponseBodyItems Items { get; set; }
        public class DescribeCrossRegionBackupsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeCrossRegionBackupsResponseBodyItemsItem> Item { get; set; }
            public class DescribeCrossRegionBackupsResponseBodyItemsItem : TeaModel {
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupSetScale")]
                [Validation(Required=false)]
                public int? BackupSetScale { get; set; }

                [NameInMap("BackupSetStatus")]
                [Validation(Required=false)]
                public int? BackupSetStatus { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                [NameInMap("CrossBackupDownloadLink")]
                [Validation(Required=false)]
                public string CrossBackupDownloadLink { get; set; }

                [NameInMap("CrossBackupId")]
                [Validation(Required=false)]
                public int? CrossBackupId { get; set; }

                [NameInMap("CrossBackupRegion")]
                [Validation(Required=false)]
                public string CrossBackupRegion { get; set; }

                [NameInMap("CrossBackupSetFile")]
                [Validation(Required=false)]
                public string CrossBackupSetFile { get; set; }

                [NameInMap("CrossBackupSetLocation")]
                [Validation(Required=false)]
                public string CrossBackupSetLocation { get; set; }

                [NameInMap("CrossBackupSetSize")]
                [Validation(Required=false)]
                public long? CrossBackupSetSize { get; set; }

                [NameInMap("DBInstanceStorageType")]
                [Validation(Required=false)]
                public string DBInstanceStorageType { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public int? InstanceId { get; set; }

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
