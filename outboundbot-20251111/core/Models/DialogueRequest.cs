// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class DialogueRequest : TeaModel {
        /// <summary>
        /// <para>The JSON array string of additional input events. Supports DTMF key press events (dataType=DTMF, dtmf is the key content), Silence events (dataType=Silence), and RuntimePrompts events (dataType=RuntimePrompts, prompts is the prompt text, persistent specifies whether to persist). For example, a silence event is [{&quot;dataType&quot;:&quot;Silence&quot;}]. This parameter is optional when no additional events are present.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;dataType&quot;:&quot;Silence&quot;}]</para>
        /// </summary>
        [NameInMap("Extras")]
        [Validation(Required=false)]
        public string Extras { get; set; }

        /// <summary>
        /// <para>The instance identity of the associated product. You must use an instance that the invoker has permission to access and that actually exists. It must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the conversation scenario under the instance. Specify an existing scenario. Subsequent conversations and end requests for the same text session must use the scenario specified when the session was initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script-example-001</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The session ID used to uniquely associate this interaction. For a text session, it is the text- identifier returned when the session is initiated. For web voice, it is the ws- identifier. For real number outbound call tests, it is the test- identifier. Subsequent calls must use the actual returned value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-11111111-2222-4333-8444-555555555555</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The text input content of the user for the current round. For normal conversations, pass the actual text of the user. Events such as key presses or silence can be passed through Extras. The processing method is determined by the scenario and the engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I would like to inquire about the business handling process</para>
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
