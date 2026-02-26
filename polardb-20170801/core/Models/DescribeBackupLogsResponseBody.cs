// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupLogsResponseBodyItems Items { get; set; }
        public class DescribeBackupLogsResponseBodyItems : TeaModel {
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public List<DescribeBackupLogsResponseBodyItemsBackupLog> BackupLog { get; set; }
            public class DescribeBackupLogsResponseBodyItemsBackupLog : TeaModel {
                [NameInMap("BackupLogEndTime")]
                [Validation(Required=false)]
                public string BackupLogEndTime { get; set; }

                [NameInMap("BackupLogId")]
                [Validation(Required=false)]
                public string BackupLogId { get; set; }

                [NameInMap("BackupLogName")]
                [Validation(Required=false)]
                public string BackupLogName { get; set; }

                [NameInMap("BackupLogSize")]
                [Validation(Required=false)]
                public string BackupLogSize { get; set; }

                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

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
