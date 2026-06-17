// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of download records.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDownloadRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeDownloadRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the download record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1150</para>
            /// </summary>
            [NameInMap("DownloadId")]
            [Validation(Required=false)]
            public long? DownloadId { get; set; }

            /// <summary>
            /// <para>The download URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://perth-download-task.oss-cn-beijing.aliyuncs.com/">https://perth-download-task.oss-cn-beijing.aliyuncs.com/</a>*****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220509113448-20220509173448.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The status of the task that uploads the query diagnostic information file to Object Storage Service (OSS). You can download the file after the upload is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>running</b>: The file is being uploaded.</para>
            /// </description></item>
            /// <item><description><para><b>finished</b>: The file upload is complete.</para>
            /// </description></item>
            /// <item><description><para><b>failed</b>: The file upload failed.</para>
            /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
