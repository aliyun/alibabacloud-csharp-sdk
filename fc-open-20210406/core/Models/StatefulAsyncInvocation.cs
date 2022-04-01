// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class StatefulAsyncInvocation : TeaModel {
        /// <summary>
        /// 异步任务调用失败后的已重试次数。
        /// </summary>
        [NameInMap("alreadyRetriedTimes")]
        [Validation(Required=false)]
        public long? AlreadyRetriedTimes { get; set; }

        /// <summary>
        /// 异步任务的目的状态。
        /// </summary>
        [NameInMap("destinationStatus")]
        [Validation(Required=false)]
        public string DestinationStatus { get; set; }

        /// <summary>
        /// 异步任务的结束时间。
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 异步任务事件列表。
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<StatefulAsyncInvocationEvent> Events { get; set; }

        /// <summary>
        /// 异步任务所属的函数的名称。
        /// </summary>
        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// 异步任务的执行实例ID。
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 异步任务的错误消息。
        /// </summary>
        [NameInMap("invocationErrorMessage")]
        [Validation(Required=false)]
        public string InvocationErrorMessage { get; set; }

        /// <summary>
        /// 异步任务ID。
        /// </summary>
        [NameInMap("invocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        /// <summary>
        /// 异步任务的任务触发事件。
        /// </summary>
        [NameInMap("invocationPayload")]
        [Validation(Required=false)]
        public string InvocationPayload { get; set; }

        /// <summary>
        /// 异步任务所属的服务的别名或版本。
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// 异步任务的请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 异步任务所属的服务的名称。
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 异步任务的开始时间。
        /// </summary>
        [NameInMap("startedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        /// <summary>
        /// 异步任务的执行状态。      Enqueued：异步消息已入队，等待处理。      Succeeded：调用执行成功。      Failed：调用执行失败。      Running：调用执行中。      Stopped：调用执行终止。      Stopping：执行停止中。      Invalid：您的执行因函数被删除等原因处于无效状态（任务未被执行）。      Expired：您为任务配置了最长排队等待的期限。该任务因为超期被丢弃（任务未被执行）。      Retrying：异步调用因执行错误重试中。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
