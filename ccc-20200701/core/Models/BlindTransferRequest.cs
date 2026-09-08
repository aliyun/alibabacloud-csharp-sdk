// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class BlindTransferRequest : TeaModel {
        /// <summary>
        /// <para>The queue priority when transferring to a skill group. Valid values are 0–9, where 0 is the highest priority and 9 is the lowest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("CallPriority")]
        [Validation(Required=false)]
        public int? CallPriority { get; set; }

        /// <summary>
        /// <para>Variables passed to the contact flow. This field is optional. The variables configured here can be retrieved and used in the IVR flow. The format is a JSON string representing a set of key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;王先生&quot;,&quot;time&quot;:&quot;19点20分&quot;,&quot;address&quot;:&quot;某某中心&quot;}</para>
        /// </summary>
        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

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
        /// <para>The queuing timeout duration in seconds when the transfer target is a skill group queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("QueuingTimeoutSeconds")]
        [Validation(Required=false)]
        public long? QueuingTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The call routing type. Valid values are Automatic or Manual. If this parameter is empty, the system defaults to Automatic routing, which is also the current default behavior of the system. When Manual routing is selected, you must invoke APIs such as ClaimCall to assign the call to a specific agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("RoutingType")]
        [Validation(Required=false)]
        public string RoutingType { get; set; }

        /// <summary>
        /// <para>Skill group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ee914df4-82bf-4919-bcb3-9cb8aa437f35</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

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
        /// <para>The parameters for the agent assignment policy when transferring to a skill group queue.</para>
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
        /// <para>Ingest endpoint data, primarily used for extension purposes. Regular users do not need to concern themselves with this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5295578135#WAEtqY5U&amp;Biz_Package_Rexian_Zhuanjieanquanyungaojie_2527</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Timeout duration for the direct transfer, in seconds. If the transferee does not answer within the specified time, the call is disconnected. This field is optional and defaults to 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The transfer recipient, which can be either an agent ID or a skill group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("Transferee")]
        [Validation(Required=false)]
        public string Transferee { get; set; }

        /// <summary>
        /// <para>Destination type for the transfer. Valid values are AGENT, SKILL_GROUP, IVR, and EXTERNAL_NUMBER. If this parameter is not specified, the system determines the destination type based on the format of the target number. If the automatic detection is inaccurate, you must explicitly specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SKILL_GROUP</para>
        /// </summary>
        [NameInMap("TransfereeType")]
        [Validation(Required=false)]
        public string TransfereeType { get; set; }

        /// <summary>
        /// <para>The transfer initiator. When the scenario involves directly transferring to an external number, the number specified by this parameter is used as the caller. This parameter is invalid when transferring to an internal agent or skill group; in such cases, the initiator is specified by the UserId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08314325****</para>
        /// </summary>
        [NameInMap("Transferor")]
        [Validation(Required=false)]
        public string Transferor { get; set; }

        /// <summary>
        /// <para>The agent ID that initiates a direct transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
