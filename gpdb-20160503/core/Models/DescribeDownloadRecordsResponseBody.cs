// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDownloadRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The URL that is used to download the file.</para>
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
            /// <para>The URL that can be used to download the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://perth-download-task.oss-cn-beijing.aliyuncs.com/">https://perth-download-task.oss-cn-beijing.aliyuncs.com/</a>*****</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220509113448-20220509173448.csv</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The state of the upload task. After you call the DownloadDiagnosisRecords operation, query diagnostic information is first uploaded to Object Storage Service (OSS). After the upload task is complete, the query diagnostic information can be downloaded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>running</b>: uploading</description></item>
            /// <item><description><b>finished</b>: uploaded</description></item>
            /// <item><description><b>failed</b>: failed</description></item>
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
