// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBinaryLogListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of binlog files.</para>
        /// </summary>
        [NameInMap("LogList")]
        [Validation(Required=false)]
        public List<DescribeBinaryLogListResponseBodyLogList> LogList { get; set; }
        public class DescribeBinaryLogListResponseBodyLogList : TeaModel {
            /// <summary>
            /// <para>The start time of the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-09 10:27:46</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            /// <summary>
            /// <para>The creation time of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-09 10:27:46</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The download link for the file. The link is valid for 2 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://polarx-cdc-binlog-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/polardbx_cdc/pxc-hzfd132143sfds1/binlog.000001?Expires=1636469502&OSSAccessKeyId=LT13fds12dsafddsf&Signature=fdpm%bdsfadsa%2F%bdsafdsaf%3D">http://polarx-cdc-binlog-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/polardbx_cdc/pxc-hzfd132143sfds1/binlog.000001?Expires=1636469502&amp;OSSAccessKeyId=LT13fds12dsafddsf&amp;Signature=fdpm%bdsfadsa%2F%bdsafdsaf%3D</a></para>
            /// </summary>
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            /// <summary>
            /// <para>The end time of the current binlog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09 10:27:46</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The name of the binlog file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>binlog.000001</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The unique ID of the current record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The size of the current log file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>536870912</para>
            /// </summary>
            [NameInMap("LogSize")]
            [Validation(Required=false)]
            public long? LogSize { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09 10:27:46</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The purge status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not deleted.</description></item>
            /// <item><description>1: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PurgeStatus")]
            [Validation(Required=false)]
            public int? PurgeStatus { get; set; }

            /// <summary>
            /// <para>The backup host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.110.88.9</para>
            /// </summary>
            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }

            /// <summary>
            /// <para>The backup status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Not backed up.</description></item>
            /// <item><description>1: Backing up.</description></item>
            /// <item><description>2: Backed up.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public int? UploadStatus { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of binlog entries displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2DFF784E-DC31-5BBC-9B25-9261CD9E0AA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of binlog files found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
