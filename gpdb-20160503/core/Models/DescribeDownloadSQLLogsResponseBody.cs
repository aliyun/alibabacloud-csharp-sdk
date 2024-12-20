// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDownloadSQLLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of download records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadSQLLogsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadSQLLogsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>Download record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1150</para>
            /// </summary>
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            /// <summary>
            /// <para>Download link.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://perth-download-task.oss-cn-beijing.aliyuncs.com/">https://perth-download-task.oss-cn-beijing.aliyuncs.com/</a>*****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>Error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// <para>File name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220509113448-20220509173448.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Task status, with possible values being:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: Downloading.</description></item>
            /// <item><description><b>finished</b>: Completed.</description></item>
            /// <item><description><b>failed</b>: Download failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDE9942A-D919-527B-B559-5D0F6F20CCEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
