// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeLogBackupFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeLogBackupFilesResponseBodyItems Items { get; set; }
        public class DescribeLogBackupFilesResponseBodyItems : TeaModel {
            [NameInMap("BinLogFile")]
            [Validation(Required=false)]
            public List<DescribeLogBackupFilesResponseBodyItemsBinLogFile> BinLogFile { get; set; }
            public class DescribeLogBackupFilesResponseBodyItemsBinLogFile : TeaModel {
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log files on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8EC669C-FC85-43D7-AF06-C3641626B37E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total size of log files. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2300</para>
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// <para>The total number of log files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
