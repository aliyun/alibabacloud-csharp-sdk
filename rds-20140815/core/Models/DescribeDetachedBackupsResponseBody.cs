// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDetachedBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDetachedBackupsResponseBodyItems Items { get; set; }
        public class DescribeDetachedBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeDetachedBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeDetachedBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// <para>The URL that is used to download the diagnostic report over the Internet. If the diagnostic report cannot be downloaded, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbak-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx">http://rdsbak-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup task.</para>
                /// <para>The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-13T12:20:00Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>321020562</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the log file over an internal network. If the log file cannot be downloaded, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbak-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxx">http://rdsbak-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The method that is used to generate the data backup file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Logical</b>: logical backup</description></item>
                /// <item><description><b>Physical</b>: physical backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Physical</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The backup method. Valid values:</para>
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
                /// <para>The backup size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2167808</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup task.</para>
                /// <para>The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-03T12:20:00Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The backup type of the backup file. Valid values:</para>
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
                /// <para>The point in time at which the data in the backup set is consistent. The return value of this parameter is a timestamp.</para>
                /// <remarks>
                /// <para> If the instance runs MySQL 5.6, a timestamp is returned. Otherwise, the value 0 is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1576506856</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBInstanceComment")]
                [Validation(Required=false)]
                public string DBInstanceComment { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the instance that generates the backup set. This parameter is used to indicate whether the instance that generates the backup set is a primary instance or a secondary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5882781</para>
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The backup set is unavailable.</description></item>
                /// <item><description><b>1</b>: The backup set is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                /// <summary>
                /// <para>The status of the backup set that is used to restore individual databases or tables. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The backup set is normal.</description></item>
                /// <item><description><b>LARGE</b>: The backup set contains an abnormally large number of tables. It cannot be used to restore individual databases or tables.</description></item>
                /// <item><description><b>EMPTY</b>: The backup set is generated from a failed backup task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("MetaStatus")]
                [Validation(Required=false)]
                public string MetaStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether the data backup file can be deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b></description></item>
                /// <item><description><b>Disabled</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("StoreStatus")]
                [Validation(Required=false)]
                public string StoreStatus { get; set; }

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
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D328C-84B8-40DC-BF49-6C73984D7494</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
