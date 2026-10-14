// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAsyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the asynchronous export tasks.</para>
        /// </summary>
        [NameInMap("AsyncTasks")]
        [Validation(Required=false)]
        public List<DescribeAsyncTasksResponseBodyAsyncTasks> AsyncTasks { get; set; }
        public class DescribeAsyncTasksResponseBodyAsyncTasks : TeaModel {
            /// <summary>
            /// <para>The end time of the task. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157927362000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the task. This value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156927362000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task parameters. This value is a string in the JSON format. Different <b>TaskType</b> values have different task parameters.</para>
            /// <para>When <b>TaskType</b> is <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the task parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the Anti-DDoS instance. The type is String.</description></item>
            /// </list>
            /// <para>When <b>TaskType</b> is <b>2</b>, the task parameters have the following structure:</para>
            /// <list type="bullet">
            /// <item><description><b>domain</b>: the domain name of the website. The type is String.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-cn-mp91j1ao****&quot;}</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The task result. This value is a string in the JSON format. Different <b>TaskType</b> values have different task results.</para>
            /// <para>When <b>TaskType</b> is <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the task result has the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>instanceId</b>: the ID of the Anti-DDoS instance. The type is String.</para>
            /// </description></item>
            /// <item><description><para><b>url</b>: the OSS download URL of the exported file. The type is String.</para>
            /// </description></item>
            /// </list>
            /// <para>When <b>TaskType</b> is <b>2</b>, the task result has the following structure:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domain</b>: the domain name of the website. The type is String.</para>
            /// </description></item>
            /// <item><description><para><b>url</b>: the OSS download URL of the exported file. The type is String.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-cn-mp91j1ao****&quot;,&quot;url&quot;: &quot;https://<b><b>.oss-cn-beijing.aliyuncs.com/heap.bin?Expires=1584785140&amp;OSSAccessKeyId=TMP.3KfzD82FyRJevJdEkRX6JEFHhbvRBBb75PZJnyJmksA2QkMm47xFAFDgMhEV8Nm6Vxr8xExMfiy9LsUFAcLcTBrN3r</b></b>&amp;Signature=Sj8BNcsxJLE8l5qm4cjNlDt8gv****&quot;}</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: indicates that the task is initialized.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: indicates that the task is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: indicates that the task is successful.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: indicates that the task failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Layer 4 export task, which indicates exporting port forwarding rules of the Anti-DDoS instance.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Layer 7 export task, which indicates exporting website forwarding rules.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Session and health check export task, which indicates exporting session and health check configuration of the Anti-DDoS instance.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: DDoS mitigation policies export task, which indicates exporting DDoS mitigation policies configuration of the Anti-DDoS instance.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Blacklist (for destination IP addresses) download task, which indicates exporting blacklist IP addresses for the Anti-DDoS instance.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: Whitelist (for destination IP addresses) download task, which indicates exporting whitelist IP addresses for the Anti-DDoS instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, which is generated by Alibaba Cloud as a unique identifier for this request. You can use this ID to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6623EA1F-30FB-5BC8-BEC9-74D55F6F08F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of asynchronous export tasks that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
