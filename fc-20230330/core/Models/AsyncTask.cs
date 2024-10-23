// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class AsyncTask : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("durationMs")]
        [Validation(Required=false)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633449590000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<AsyncTaskEvent> Events { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:1234/functions/my-func</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D4-*******9FD1-882707E</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prod</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e026ae92-61e5-472f-b32d-1c9e3c4e****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>result</para>
        /// </summary>
        [NameInMap("returnPayload")]
        [Validation(Required=false)]
        public string ReturnPayload { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633449590000</para>
        /// </summary>
        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnhandledInvocationError</para>
        /// </summary>
        [NameInMap("taskErrorMessage")]
        [Validation(Required=false)]
        public string TaskErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e026ae92-61e5-472f-b32d-1c9e3c4e****</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("taskPayload")]
        [Validation(Required=false)]
        public string TaskPayload { get; set; }

    }

}
