// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class DialogueRequest : TeaModel {
        /// <summary>
        /// <para>Extras.
        /// For example, a silence timeout: [{&quot;dataType&quot;:&quot;Silence&quot;}]</para>
        /// <remarks>
        /// <para>Notice: Valid values for <c>dataType</c>: <c>DTMF</c>, <c>Silence</c>, or <c>RuntimePrompts</c>.</para>
        /// </remarks>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If <c>dataType</c> is <c>DTMF</c>, use the format: <c>[{&quot;dataType&quot;:&quot;DTMF&quot;,&quot;dtmf&quot;:&quot;xxxx&quot;}]</c></para>
        /// </description></item>
        /// <item><description><para>If <c>dataType</c> is <c>Silence</c>, use the format: <c>[{&quot;dataType&quot;:&quot;Silence&quot;}]</c></para>
        /// </description></item>
        /// <item><description><para>If <c>dataType</c> is <c>RuntimePrompts</c>, use the format: <c>[{&quot;dataType&quot;:&quot;RuntimePrompts&quot;,&quot;prompts&quot;:&quot;xxxx&quot;,&quot;persistent&quot;:false/true}]</c></para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;dataType&quot;: &quot;Silence&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("Extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

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
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a88e269-01f5-49ac-97af-5830f0ccb271</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07d72ea0-6e38-48d4-8371-14deaaba996f</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The user\&quot;s input for the conversational turn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>行吧，那我就不打扰您了，再见。</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
