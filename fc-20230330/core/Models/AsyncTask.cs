// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class AsyncTask : TeaModel {
        /// <summary>
        /// <para>The number of retries after the asynchronous task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        /// <summary>
        /// <para>The final state of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        /// <summary>
        /// <para>The execution duration of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("durationMs")]
        [Validation(Required=false)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// <para>The end time of the asynchronous task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633449590000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The events of the asynchronous task.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<AsyncTaskEvent> Events { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:1234/functions/my-func</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <para>The ID of the instance that corresponds to the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4-*******9FD1-882707E</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The version or alias of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The ID of the request corresponding to this asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e026ae92-61e5-472f-b32d-1c9e3c4e****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the response after the asynchronous task is executed. The maximum size is 1 MB. This parameter is in public preview. If you want to use this parameter, <a href="https://help.aliyun.com/document_detail/2513733.html">contact us</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>result</para>
        /// </summary>
        [NameInMap("returnPayload")]
        [Validation(Required=false)]
        public string ReturnPayload { get; set; }

        /// <summary>
        /// <para>The start time of the asynchronous task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1633449590000</para>
        /// </summary>
        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        /// <summary>
        /// <para>The state of the asynchronous task.</para>
        /// <list type="bullet">
        /// <item><description>Enqueued: The asynchronous invocation is enqueued and waiting to be executed.</description></item>
        /// <item><description>Succeeded: The invocation is successful.</description></item>
        /// <item><description>Failed: The invocation fails.</description></item>
        /// <item><description>Running: The invocation is being executed.</description></item>
        /// <item><description>Stopped: The invocation is terminated.</description></item>
        /// <item><description>Stopping: The invocation is being terminated.</description></item>
        /// <item><description>Invalid: The invocation is invalid and not executed due to specific reasons. For example, the function is deleted.</description></item>
        /// <item><description>Expired: The maximum validity period of messages is specified for asynchronous invocation. The invocation is discarded and not executed because the specified maximum validity period of messages expires.</description></item>
        /// <item><description>Retrying: The asynchronous invocation is being retried due to an execution error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The error message for an asynchronous task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnhandledInvocationError</para>
        /// </summary>
        [NameInMap("taskErrorMessage")]
        [Validation(Required=false)]
        public string TaskErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e026ae92-61e5-472f-b32d-1c9e3c4e****</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The content of the input parameter during asynchronous task execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("taskPayload")]
        [Validation(Required=false)]
        public string TaskPayload { get; set; }

    }

}
