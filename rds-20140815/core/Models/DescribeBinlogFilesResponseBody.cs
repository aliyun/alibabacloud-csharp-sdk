// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBinlogFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the log file.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBinlogFilesResponseBodyItems Items { get; set; }
        public class DescribeBinlogFilesResponseBodyItems : TeaModel {
            [NameInMap("BinLogFile")]
            [Validation(Required=false)]
            public List<DescribeBinlogFilesResponseBodyItemsBinLogFile> BinLogFile { get; set; }
            public class DescribeBinlogFilesResponseBodyItemsBinLogFile : TeaModel {
                /// <summary>
                /// <para>The checksum. The value of this parameter is calculated by using the CRC64 algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18358304393468701857</para>
                /// </summary>
                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                /// <summary>
                /// <para>The HTTP-based download URL of the log file. If the return value of this parameter is NULL, ApsaraDB RDS does not provide a download URL for the log file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsxxxxx.oss.aliyuncs.com/xxxxxx">http://rdsxxxxx.oss.aliyuncs.com/xxxxxx</a></para>
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// <para>The size of the log file.</para>
                /// <para>Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2269410</para>
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The ID of the instance to which the log file belongs. This parameter helps determine whether the log file is generated on the primary instance or the secondary instance.</para>
                /// <remarks>
                /// <para> You can log on to the ApsaraDB RDS console and go to the instance details page. In the left-side navigation pane, click <b>Service Availability</b> to view the values of <b>Primary Instance No.</b> and <b>Secondary Instance No.</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5841973</para>
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// <para>The URL that is used to download files over an internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdslog-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxxx">http://rdslog-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxxx</a></para>
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// <para>The expiration time of the URL.</para>
                /// <para>The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2013-06-09T18:00:00Z</para>
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

                /// <summary>
                /// <para>The beginning of the time range to query.</para>
                /// <para>The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-09T17:45:21Z</para>
                /// </summary>
                [NameInMap("LogBeginTime")]
                [Validation(Required=false)]
                public string LogBeginTime { get; set; }

                /// <summary>
                /// <para>The end of the time range to query.</para>
                /// <para>The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-15T13:10:28Z</para>
                /// </summary>
                [NameInMap("LogEndTime")]
                [Validation(Required=false)]
                public string LogEndTime { get; set; }

                /// <summary>
                /// <para>The log file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000000040000000000000019</para>
                /// </summary>
                [NameInMap("LogFileName")]
                [Validation(Required=false)]
                public string LogFileName { get; set; }

                /// <summary>
                /// <para>The status of the log file that is stored in the Object Storage Service (OSS) bucket.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>Completed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("RemoteStatus")]
                [Validation(Required=false)]
                public string RemoteStatus { get; set; }

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
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of log files on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED169A3E-1657-4104-82AB-24EA8CD0DB75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total size of the log file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2269410</para>
        /// </summary>
        [NameInMap("TotalFileSize")]
        [Validation(Required=false)]
        public long? TotalFileSize { get; set; }

        /// <summary>
        /// <para>The total number of log files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
