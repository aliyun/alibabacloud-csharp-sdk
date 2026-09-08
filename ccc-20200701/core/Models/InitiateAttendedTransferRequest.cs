// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class InitiateAttendedTransferRequest : TeaModel {
        /// <summary>
        /// <para>The queuing priority when transferring to a skill group queue. Valid values range from 0 to 9, where 0 is the highest priority and 9 is the lowest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("CallPriority")]
        [Validation(Required=false)]
        public int? CallPriority { get; set; }

        /// <summary>
        /// <para>Device ID. This parameter is meaningless and can be filled with any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACC-YUNBS-1.0.10-****</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The call ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6538214103685****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The queuing overflow threshold when the transfer target is a skill group queue. The default value is 0, which means no overflow occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QueuingOverflowThreshold")]
        [Validation(Required=false)]
        public long? QueuingOverflowThreshold { get; set; }

        /// <summary>
        /// <para>The queuing timeout period in seconds when the transfer target is a skill group queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("QueuingTimeoutSeconds")]
        [Validation(Required=false)]
        public long? QueuingTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The call assignment type. Valid values are Automatic or Manual. If this parameter is empty, the default value is Automatic, which is also the current system\&quot;s default behavior. When Manual is selected, you must invoke APIs such as ClaimCall to assign the call to a specific agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic</para>
        /// </summary>
        [NameInMap("RoutingType")]
        [Validation(Required=false)]
        public string RoutingType { get; set; }

        /// <summary>
        /// <para>The policy name for agent assignment when transferring to a skill group queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MOST_IDLE，MOST_SKILLED，MOST_ACQUAINTED，CUSTOMIZED等</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The policy parameters for agent assignment when transferring to a skill group queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当分配策略为CUSTOMIZED时，本参数的内容为如下格式：
        ///  {
        ///   &quot;functionId&quot;: &quot;512fed64-e379-400f-a1a5-14d5730xxxxx&quot;,
        ///   &quot;functionName&quot;: &quot;routing-strategy-test-2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("StrategyParams")]
        [Validation(Required=false)]
        public string StrategyParams { get; set; }

        /// <summary>
        /// <para>Ingest endpoint data, primarily used for extension requirements. Regular users do not need to concern themselves with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=b</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Timeout duration for the consultation transfer, in seconds. If the transferee does not answer within the specified time, the call is disconnected. This field is optional. Default value is 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The transferee, which can be an agent ID or a skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent2@ccc-test</para>
        /// </summary>
        [NameInMap("Transferee")]
        [Validation(Required=false)]
        public string Transferee { get; set; }

        /// <summary>
        /// <para>The destination type for the transfer. Valid values are AGENT, SKILL_GROUP, and EXTERNAL. If this parameter is not provided, the system determines the destination type based on the format of the target number. If inaccurate detection occurs, explicitly specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SKILL_GROUP</para>
        /// </summary>
        [NameInMap("TransfereeType")]
        [Validation(Required=false)]
        public string TransfereeType { get; set; }

        /// <summary>
        /// <para>The party initiating the transfer. When transferring to an external number, this parameter specifies the caller number. This parameter is invalid when transferring to an internal agent or skill group; in such cases, the initiator is determined by the UserId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Transferor")]
        [Validation(Required=false)]
        public string Transferor { get; set; }

        /// <summary>
        /// <para>The agent ID initiating the consultation transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
