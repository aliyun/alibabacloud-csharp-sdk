// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLLogFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the returned audit log files.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogFilesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogFilesResponseBodyItems : TeaModel {
            [NameInMap("LogFile")]
            [Validation(Required=false)]
            public List<DescribeSQLLogFilesResponseBodyItemsLogFile> LogFile { get; set; }
            public class DescribeSQLLogFilesResponseBodyItemsLogFile : TeaModel {
                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custinsxxxxx.csv</para>
                /// </summary>
                [NameInMap("FileID")]
                [Validation(Required=false)]
                public string FileID { get; set; }

                /// <summary>
                /// <para>The download URL of the file. If the audit log file cannot be downloaded, this parameter is null.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdslog-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx">http://rdslog-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("LogDownloadURL")]
                [Validation(Required=false)]
                public string LogDownloadURL { get; set; }

                /// <summary>
                /// <para>The time at which the last SQL statement recorded in the audit log file was executed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-05-24T07:00:00Z</para>
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// <para>The size of the audit log file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("LogSize")]
                [Validation(Required=false)]
                public string LogSize { get; set; }

                /// <summary>
                /// <para>The time at which the first SQL statement recorded in the audit log file was executed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-05-23T07:00:00Z</para>
                /// </summary>
                [NameInMap("LogStartTime")]
                [Validation(Required=false)]
                public string LogStartTime { get; set; }

                /// <summary>
                /// <para>The status of the audit log file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// <item><description><b>Generating</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("LogStatus")]
                [Validation(Required=false)]
                public string LogStatus { get; set; }

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
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
