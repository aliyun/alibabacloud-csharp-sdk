// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeBackupsResponseBodyItems> Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The end time of the backup. The time is in the yyyy-MM-ddTHH:mmZ format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-22T18:28:41Z</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// <para>The data backup task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>117403****</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The backup method. The value is always <b>Physical</b>, which indicates a physical backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Physical</para>
            /// </summary>
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            /// <summary>
            /// <para>The number of cluster nodes.</para>
            /// <list type="bullet">
            /// <item><description><para>For a single-replica edition cluster, the value is an integer from 1 to 48.</para>
            /// </description></item>
            /// <item><description><para>For a double-replica edition cluster, the value is an integer from 1 to 24.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;shard_count&quot;: 4}</para>
            /// </summary>
            [NameInMap("BackupSetInfo")]
            [Validation(Required=false)]
            public string BackupSetInfo { get; set; }

            /// <summary>
            /// <para>The backup size. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("BackupSize")]
            [Validation(Required=false)]
            public long? BackupSize { get; set; }

            /// <summary>
            /// <para>The start time of the backup. The time is in the yyyy-MM-ddTHH:mmZ format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-22T18:28:22Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The backup status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Success</b>: The backup is successful.</para>
            /// </description></item>
            /// <item><description><para><b>Failure</b>: The backup failed.</para>
            /// </description></item>
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
            /// <item><description><para><b>FullBackup</b>: full backup.</para>
            /// </description></item>
            /// <item><description><para><b>IncrementalBackup</b>: incremental backup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IncrementalBackup</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp1qx68m06981****</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The expiration time of the backup set. The time is in the yyyy-MM-ddTHH:mmZ format and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-22T18:28:41Z</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

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
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
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
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
