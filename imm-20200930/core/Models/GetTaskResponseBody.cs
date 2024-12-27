// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceNotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-24T03:01:49.480109219Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F6-1Bz99Xi93EnRpNEyLudILJm****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The error message of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource project is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The task progress. Valid values: 0 to 100. Unit: %.</para>
        /// <remarks>
        /// <para> This parameter is valid only if the task is in the <c>Running</c> state.``</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C5C1E0F-D8B8-4DA0-8127-EC32C771****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-24T03:01:41.662060377Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING: The task is running.</description></item>
        /// <item><description>Succeeded: The task is successful.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags. This parameter is returned only if you specified Tags when you created the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;: &quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2b277b9-0d30-4882-ad6d-ad661382****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The initial request parameters used to create the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ProjectName&quot;:&quot;test-project&quot;,
        ///     &quot;CompressedFormat&quot;:&quot;zip&quot;,
        ///     &quot;TargetURI&quot;:&quot;oss://test-bucket/output/test.zip&quot;,
        ///     &quot;Sources&quot;:[{&quot;URI&quot;:&quot;oss://test-bucket/input/test.jpg&quot;}]
        /// }</para>
        /// </summary>
        [NameInMap("TaskRequestDefinition")]
        [Validation(Required=false)]
        public string TaskRequestDefinition { get; set; }

        /// <summary>
        /// <para>The type of the task. For more information, see <a href="https://help.aliyun.com/document_detail/2743993.html">Task types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VideoLabelClassification</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The user data of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ID&quot;: &quot;user1&quot;,&quot;Name&quot;: &quot;test-user1&quot;,&quot;Avatar&quot;: &quot;<a href="http://example.com?id=user1%22%7D">http://example.com?id=user1&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
