// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried download tasks.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The download task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            /// <summary>
            /// <para>The error message returned if the download task failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The query result is empty.</para>
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// <para>The name of the downloaded file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210806094635-20210806095135</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The status of the download task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b></description></item>
            /// <item><description><b>finished</b></description></item>
            /// <item><description><b>failed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The download URL of the file.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>987F51BE-C4CB-332A-B159-63CE87******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
