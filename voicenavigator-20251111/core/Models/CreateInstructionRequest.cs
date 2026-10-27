// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateInstructionRequest : TeaModel {
        /// <summary>
        /// <para>The instruction code.</para>
        /// <remarks>
        /// <para>Notice: Globally unique.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Transfer00</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The instruction configuration.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>providerId: the ID of the human agent service provider. You can obtain the ID by calling ListCallCenterProviders.</description></item>
        /// <item><description>transferMethod: the transfer method. Valid values: BYE, BRIDGE, and REFER.</description></item>
        /// <item><description>transferType: the transfer target type. Valid values: External (external number), Agent (agent), and SkillGroup (skill group).</description></item>
        /// <item><description>transferTarget: the transfer target.</description></item>
        /// <item><description>transferor: the caller number. If this parameter is left empty, the mobile phone number of the calling customer is used by default.</description></item>
        /// <item><description>timeoutSeconds: the timeout period for transferring to a human agent, in seconds. Default value: 30.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;providerId&quot;: &quot;xxxxxxxxx&quot;,
        ///     &quot;transferMethod&quot;: &quot;BYE&quot;,
        ///     &quot;transferType&quot;: &quot;External&quot;,
        ///     &quot;transferTarget&quot;: &quot;152******&quot;,
        ///     &quot;transferor&quot;: &quot;01*****&quot;,
        ///     &quot;timeoutSeconds&quot;: &quot;10&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instruction name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Transfer to human agent instruction 1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The instruction type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRANSFER</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
