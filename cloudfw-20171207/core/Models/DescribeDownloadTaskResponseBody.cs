// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F2BED13-F3D0-5984-80D6-D5F298CFEA88</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<DescribeDownloadTaskResponseBodyTasks> Tasks { get; set; }
        public class DescribeDownloadTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706595827</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the task expires. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1714371828</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The size of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24.04KB</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// <para>The URL of the OSS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cfw-table-download-cn.oss-cn-hangzhou.aliyuncs.com/%E4%BA%92%E8%81%94%E7%BD%91%E8%BE%B9%E7%95%8C%E9%98%B2%E7%81%AB%E5%A2%99%E8%B5%84%E4%BA%A7-IPv4_1069.csv?Expires=1708583913&OSSAccessKeyId=****&Signature=******%3D">https://cfw-table-download-cn.oss-cn-hangzhou.aliyuncs.com/%E4%BA%92%E8%81%94%E7%BD%91%E8%BE%B9%E7%95%8C%E9%98%B2%E7%81%AB%E5%A2%99%E8%B5%84%E4%BA%A7-IPv4_1069.csv?Expires=1708583913&amp;OSSAccessKeyId=****&amp;Signature=******%3D</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>finish</b></description></item>
            /// <item><description><b>start</b></description></item>
            /// <item><description><b>error</b></description></item>
            /// <item><description><b>expire</b>: The task file is invalid and cannot be downloaded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internet Boundary Firewall Assets - IPv4</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternetFirewallAsset</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
