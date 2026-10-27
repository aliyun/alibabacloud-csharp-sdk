// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateInstructionRequest : TeaModel {
        /// <summary>
        /// <para>The unique code for the instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Transfer00</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The configuration for the instruction, specified as a JSON string.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><c>providerId</c>: The ID of the live agent service provider. Call the <c>ListCallCenterProviders</c> operation to obtain this ID.</para>
        /// </description></item>
        /// <item><description><para><c>transferMethod</c>: The method used for the transfer. Valid values: <c>BYE</c>, <c>BRIDGE</c>, and <c>REFER</c>.</para>
        /// </description></item>
        /// <item><description><para><c>transferType</c>: The transfer destination type. Valid values: <c>External</c> (external number), <c>Agent</c> (agent), and <c>SkillGroup</c> (skill group).</para>
        /// </description></item>
        /// <item><description><para><c>transferTarget</c>: The destination of the transfer, such as a phone number, an agent ID, or a skill group ID. The value of this parameter depends on the <c>transferType</c>.</para>
        /// </description></item>
        /// <item><description><para><c>transferor</c>: The caller ID to display for the transfer. If this parameter is not specified, the caller\&quot;s original phone number is used.</para>
        /// </description></item>
        /// <item><description><para><c>timeoutSeconds</c>: The timeout in seconds for transferring a call to an agent. Default: 30.</para>
        /// </description></item>
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
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>转人工指令一</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRANSFER</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
