// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateAiCallTaskRequest : TeaModel {
        /// <summary>
        /// <para>The callable days.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CallDay")]
        [Validation(Required=false)]
        public List<string> CallDay { get; set; }

        /// <summary>
        /// <para>The expiration date of outbound call details (the specific deadline). Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-30 20:00:20</para>
        /// </summary>
        [NameInMap("CallExpireDate")]
        [Validation(Required=false)]
        public string CallExpireDate { get; set; }

        /// <summary>
        /// <para>The expiration duration of outbound call details. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallExpireMinutes")]
        [Validation(Required=false)]
        public long? CallExpireMinutes { get; set; }

        /// <summary>
        /// <para>The outbound call validity type. Valid values:</para>
        /// <para>0: Permanently valid.
        /// 1: Valid for a specified period after import.
        /// 2: Valid until a specified date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallExpireType")]
        [Validation(Required=false)]
        public long? CallExpireType { get; set; }

        /// <summary>
        /// <para>The retry interval. Unit: minutes. The maximum value is 120.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("CallRetryInterval")]
        [Validation(Required=false)]
        public long? CallRetryInterval { get; set; }

        /// <summary>
        /// <para>The reasons for retrying failed calls.</para>
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
        /// <para>The callable time periods.</para>
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
        /// <para>The customer-provided line number.</para>
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
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): Disabled.</para>
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
        /// <para>The number type. This parameter is used when the creation source is engine-based.</para>
        /// <para>0: Alibaba Cloud number.</para>
        /// <para>1: Customer-provided line.</para>
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
        /// <para>0: Created by agent.</para>
        /// <para>1: Created by engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cannot be modified. You do not need to specify this parameter</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

        /// <summary>
        /// <para>The start mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IMMEDIATE: Starts immediately.</para>
        /// </description></item>
        /// <item><description><para>SCHEDULE: Starts at a scheduled time.</para>
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
        /// <para>The task concurrency. The maximum value is 500.</para>
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
        /// <para>The task name. The name must be unique within the same account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestTask</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The preset start time of the task. The value is a UNIX timestamp in milliseconds. This parameter is valid and required when StartType is set to SCHEDULE. The task automatically starts at the time specified by this parameter.</para>
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
