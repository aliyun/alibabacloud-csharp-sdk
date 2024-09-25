// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the backup logs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupLogsResponseBodyItems Items { get; set; }
        public class DescribeBackupLogsResponseBodyItems : TeaModel {
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public List<DescribeBackupLogsResponseBodyItemsBackupLog> BackupLog { get; set; }
            public class DescribeBackupLogsResponseBodyItemsBackupLog : TeaModel {
                /// <summary>
                /// <para>The time when the backup task ended. The time follows the ISO 8601 standard in the <c>YYYY-MM-DD\\&quot;T\\&quot;HH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-12T03:55:31Z</para>
                /// </summary>
                [NameInMap("BackupLogEndTime")]
                [Validation(Required=false)]
                public string BackupLogEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111111111</para>
                /// </summary>
                [NameInMap("BackupLogId")]
                [Validation(Required=false)]
                public string BackupLogId { get; set; }

                /// <summary>
                /// <para>The name of the backup log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ib_logfile1</para>
                /// </summary>
                [NameInMap("BackupLogName")]
                [Validation(Required=false)]
                public string BackupLogName { get; set; }

                /// <summary>
                /// <para>The size of the backup log. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1073741824</para>
                /// </summary>
                [NameInMap("BackupLogSize")]
                [Validation(Required=false)]
                public string BackupLogSize { get; set; }

                /// <summary>
                /// <para>The time when the backup task started. The time follows the ISO 8601 standard in the <c>YYYY-MM-DD\\&quot;T\\&quot;HH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-12T03:54:43Z</para>
                /// </summary>
                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                /// <summary>
                /// <para>The public URL used to download the backup log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://***********.oss-cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// <para>The internal URL used to download the backup log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://***********.oss-cn-hangzhou-internal.aliyuncs.com</para>
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// <para>The time when the download URL expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-14T08:40:50Z</para>
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

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
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADAC63DB-0691-4ECE-949A-FAEA68******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
