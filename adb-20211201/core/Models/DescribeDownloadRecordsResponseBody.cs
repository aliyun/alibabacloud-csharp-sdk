// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication failure message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication failed.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>A list of download tasks.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the download task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>636890</para>
            /// </summary>
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            /// <summary>
            /// <para>The exception message returned if the download task fails.</para>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>running</b>: The task is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>finished</b>: The task is complete.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The download URL of the result file.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D761DA51-12F8-5457-AAA9-F52B9F436D2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
