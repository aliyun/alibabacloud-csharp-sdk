// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The days of the week when calls can be made.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallDay")]
        [Validation(Required=false)]
        public List<string> CallDay { get; set; }

        /// <summary>
        /// <para>The retry interval in minutes. The maximum value is 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("CallRetryInterval")]
        [Validation(Required=false)]
        public long? CallRetryInterval { get; set; }

        /// <summary>
        /// <para>The call failure statuses that trigger a retry.</para>
        /// </summary>
        [NameInMap("CallRetryReason")]
        [Validation(Required=false)]
        public List<string> CallRetryReason { get; set; }

        /// <summary>
        /// <para>The number of retries. The maximum value is 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CallRetryTimes")]
        [Validation(Required=false)]
        public long? CallRetryTimes { get; set; }

        /// <summary>
        /// <para>The callable time windows.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public List<string> CallTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("LineEncoding")]
        [Validation(Required=false)]
        public string LineEncoding { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("LinePhoneNum")]
        [Validation(Required=false)]
        public string LinePhoneNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable retry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Yes.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MissCallRetry")]
        [Validation(Required=false)]
        public bool? MissCallRetry { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>53</para>
        /// </summary>
        [NameInMap("PhoneType")]
        [Validation(Required=false)]
        public long? PhoneType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

        /// <summary>
        /// <para>The startup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>IMMEDIATE</c>: Start immediately.</para>
        /// </description></item>
        /// <item><description><para><c>SCHEDULE</c>: Start at a specified time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMMEDIATE</para>
        /// </summary>
        [NameInMap("StartType")]
        [Validation(Required=false)]
        public string StartType { get; set; }

        /// <summary>
        /// <para>The number of concurrent calls per second (CPS) for the task. The maximum value is 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("TaskCps")]
        [Validation(Required=false)]
        public long? TaskCps { get; set; }

        /// <summary>
        /// <para>The ID of the task to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1187**************</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task name. The name must be unique within an Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The scheduled start time for the task, specified as a Unix timestamp in milliseconds. This parameter is required when <c>StartType</c> is set to <c>SCHEDULE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1748923429000</para>
        /// </summary>
        [NameInMap("TaskStartTime")]
        [Validation(Required=false)]
        public long? TaskStartTime { get; set; }

        /// <summary>
        /// <para>The service instance used for outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0537022*****</para>
        /// </summary>
        [NameInMap("VirtualNumber")]
        [Validation(Required=false)]
        public string VirtualNumber { get; set; }

    }

}
