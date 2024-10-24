// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAsyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the asynchronous export tasks.</para>
        /// </summary>
        [NameInMap("AsyncTasks")]
        [Validation(Required=false)]
        public List<DescribeAsyncTasksResponseBodyAsyncTasks> AsyncTasks { get; set; }
        public class DescribeAsyncTasksResponseBodyAsyncTasks : TeaModel {
            /// <summary>
            /// <para>The end time of the task. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>157927362000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the task. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156927362000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task parameter. The value is a JSON string. The returned field in the value varies based on the value of <b>TaskType</b>.</para>
            /// <para>If <b>TaskType</b> is set to <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the following filed is returned:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the instance. Data type: string.</description></item>
            /// </list>
            /// <para>If <b>TaskType</b> is set to <b>2</b>, the following field is returned:</para>
            /// <list type="bullet">
            /// <item><description><b>domain</b>: the domain name of the website. Data type: string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;instanceId&quot;: &quot;ddoscoo-cn-mp91j1ao****&quot;}</para>
            /// </summary>
            [NameInMap("TaskParams")]
            [Validation(Required=false)]
            public string TaskParams { get; set; }

            /// <summary>
            /// <para>The execution result of the task. The value is a JSON string. The returned fields in the value vary based on the value of <b>TaskType</b>.</para>
            /// <para>If <b>TaskType</b> is set to <b>1</b>, <b>3</b>, <b>4</b>, <b>5</b>, or <b>6</b>, the following fields are returned:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the instance. Data type: string.</description></item>
            /// <item><description><b>url</b>: the URL to download the exported file from Object Storage Service (OSS). Data type: string.</description></item>
            /// </list>
            /// <para>If <b>TaskType</b> is set to <b>2</b>, the following fields are returned:</para>
            /// <list type="bullet">
            /// <item><description><b>domain</b>: the domain name of the website. Data type: string.</description></item>
            /// <item><description><b>url</b>: the URL to download the exported file from OSS. Data type: string.</description></item>
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
            /// <item><description><b>0</b>: indicates that the task is being initialized.</description></item>
            /// <item><description><b>1</b>: indicates that the task is in progress.</description></item>
            /// <item><description><b>2</b>: indicates that the task is successful.</description></item>
            /// <item><description><b>3</b>: indicates that the task failed.</description></item>
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
            /// <item><description><b>1</b>: the task to export the port forwarding rules of an instance</description></item>
            /// <item><description><b>2</b>: the task to export the forwarding rules of a website protected by an instance</description></item>
            /// <item><description><b>3</b>: the task to export the sessions and health check settings of an instance</description></item>
            /// <item><description><b>4</b>: the task to export the mitigation policies of an instance</description></item>
            /// <item><description><b>5</b>: the task to download the blacklist for destination IP addresses of an instance</description></item>
            /// <item><description><b>6</b>: the task to download the whitelist for destination IP addresses of an instance</description></item>
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
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6623EA1F-30FB-5BC8-BEC9-74D55F6F08F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of asynchronous export tasks that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
