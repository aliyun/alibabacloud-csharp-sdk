// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeOssDownloadsResponseBody : TeaModel {
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
        /// <para>Details of the backup file.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeOssDownloadsResponseBodyItems Items { get; set; }
        public class DescribeOssDownloadsResponseBodyItems : TeaModel {
            [NameInMap("OssDownload")]
            [Validation(Required=false)]
            public List<DescribeOssDownloadsResponseBodyItemsOssDownload> OssDownload { get; set; }
            public class DescribeOssDownloadsResponseBodyItemsOssDownload : TeaModel {
                /// <summary>
                /// <para>The backup type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Database</b>: full backup file</description></item>
                /// <item><description><b>Differential_Database</b>: incremental backup file</description></item>
                /// <item><description><b>Transaction_Log</b>: log backup file</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Database</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <para>The time when the backup file was created in the download list. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-17T12:45:15Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>App description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-27T12:45:15Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The name of the backup file stored in the Object Storage Service (OSS) bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The size of the backup file. Unit: MB</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup file is available. Valid values: <b>True and False</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public string IsAvailable { get; set; }

                /// <summary>
                /// <para>The state of the backup file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NoStart</b></description></item>
                /// <item><description><b>Downloading</b></description></item>
                /// <item><description><b>Finished</b></description></item>
                /// <item><description><b>DownloadFailed</b></description></item>
                /// <item><description><b>VerifyFailed</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// <item><description><b>DeleteFailed</b></description></item>
                /// <item><description><b>CheckSuccess</b></description></item>
                /// <item><description><b>CheckFailed</b></description></item>
                /// <item><description><b>Restoring</b></description></item>
                /// <item><description><b>Restored</b></description></item>
                /// <item><description><b>RestoreFailed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>562154852</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5409D02-D661-4BF3-8F3D-0A814D0574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
