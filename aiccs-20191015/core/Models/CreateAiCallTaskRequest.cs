// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateAiCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent that is online.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1180**************</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The application code. This parameter is used when the creation source is engine.</para>
        /// 
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
        public List<string> CallDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("CallExpireDate")]
        [Validation(Required=false)]
        public string CallExpireDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82</para>
        /// </summary>
        [NameInMap("CallExpireMinutes")]
        [Validation(Required=false)]
        public long? CallExpireMinutes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("CallExpireType")]
        [Validation(Required=false)]
        public long? CallExpireType { get; set; }

        /// <summary>
        /// <para>The retry interval. Unit: minutes. The maximum value is 720 minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("CallRetryInterval")]
        [Validation(Required=false)]
        public long? CallRetryInterval { get; set; }

        /// <summary>
        /// <para>The list of retry reasons for failed calls.</para>
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
        /// <para>The list of callable time periods.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public List<string> CallTime { get; set; }

        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public List<string> CallableTime { get; set; }

        /// <summary>
        /// <para>The line encoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JILIANG_***_***_NET</para>
        /// </summary>
        [NameInMap("LineEncoding")]
        [Validation(Required=false)]
        public string LineEncoding { get; set; }

        /// <summary>
        /// <para>The phone number of the customer-provided line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>152****3120</para>
        /// </summary>
        [NameInMap("LinePhoneNum")]
        [Validation(Required=false)]
        public string LinePhoneNum { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable retry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): disabled.</para>
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
        /// <para>The number type. This parameter is used when the creation source is engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Alibaba Cloud number.</para>
        /// </description></item>
        /// <item><description><para>1: customer-provided line.</para>
        /// </description></item>
        /// </list>
        /// 
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
        /// <para>The creation source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: created by an agent.</para>
        /// </description></item>
        /// <item><description><para>1: created by an engine.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

        /// <summary>
        /// <para>The start type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IMMEDIATE: starts immediately.</para>
        /// </description></item>
        /// <item><description><para>SCHEDULE: starts at a scheduled time.</para>
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
        /// <para>The task name. The name must be unique within the same account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The scheduled start time of the task. Unit: milliseconds (UNIX timestamp). This parameter is valid and required when StarType is set to SCHEDULE. The task automatically starts at the specified time.</para>
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
