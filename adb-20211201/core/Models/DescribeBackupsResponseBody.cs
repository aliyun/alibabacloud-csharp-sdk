// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// <para>The end time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-02T16:00Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The backup set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32732****</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The backup method. Snapshot is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Snapshot</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2167808</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public int? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-01T16:00Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

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
                /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bp11q28kvl688****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE17270B-F8F8-5A31-9DB4-DADDFDAD7940</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
