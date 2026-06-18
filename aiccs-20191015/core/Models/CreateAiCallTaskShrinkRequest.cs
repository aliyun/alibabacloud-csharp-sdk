// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAiCallTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a published agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1180**************</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>025****C98</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>The list of callable days.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallDay")]
        [Validation(Required=false)]
        public string CallDayShrink { get; set; }

        /// <summary>
        /// <para>The retry interval, in minutes. The maximum value is 720.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("CallRetryInterval")]
        [Validation(Required=false)]
        public long? CallRetryInterval { get; set; }

        /// <summary>
        /// <para>The failure reasons that trigger a retry.</para>
        /// </summary>
        [NameInMap("CallRetryReason")]
        [Validation(Required=false)]
        public string CallRetryReasonShrink { get; set; }

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
        /// <para>The list of callable time periods.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public string CallTimeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JILIANG_***_***_NET</para>
        /// </summary>
        [NameInMap("LineEncoding")]
        [Validation(Required=false)]
        public string LineEncoding { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>152****3120</para>
        /// </summary>
        [NameInMap("LinePhoneNum")]
        [Validation(Required=false)]
        public string LinePhoneNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable retry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables retry.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): Disables retry.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MissCallRetry")]
        [Validation(Required=false)]
        public bool? MissCallRetry { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

        /// <summary>
        /// <para>The startup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>IMMEDIATE</c>: Starts the task immediately.</para>
        /// </description></item>
        /// <item><description><para><c>SCHEDULE</c>: Starts the task at a scheduled time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCHEDULE</para>
        /// </summary>
        [NameInMap("StartType")]
        [Validation(Required=false)]
        public string StartType { get; set; }

        /// <summary>
        /// <para>The task concurrency. The maximum value is 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75</para>
        /// </summary>
        [NameInMap("TaskCps")]
        [Validation(Required=false)]
        public long? TaskCps { get; set; }

        /// <summary>
        /// <para>The name of the task. It must be unique within an account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The scheduled start time for the task, specified as a timestamp in milliseconds. This parameter is required and applies only when <c>StartType</c> is set to <c>SCHEDULE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12313123133</para>
        /// </summary>
        [NameInMap("TaskStartTime")]
        [Validation(Required=false)]
        public long? TaskStartTime { get; set; }

        /// <summary>
        /// <para>The service instance used for outbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>032712122*****</para>
        /// </summary>
        [NameInMap("VirtualNumber")]
        [Validation(Required=false)]
        public string VirtualNumber { get; set; }

    }

}
