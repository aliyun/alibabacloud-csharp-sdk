// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class EndSessionRequest : TeaModel {
        /// <summary>
        /// <para>The instance identity of the associated product. You must use an existing instance that the invoker is authorized to access. The instance must match the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-example-001</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the dialog scenario under the instance. You must specify an existing scenario. Subsequent dialog and session termination requests for the same text session must use the same scenario that was used to start the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>script-example-001</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The session ID used to uniquely identify the current interaction. For a text session, use the text- prefixed ID returned when the session is started. For web voice, use the ws- prefixed ID. For outbound call tests with real numbers, use the test- prefixed ID. Subsequent calls must use the actual returned values.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-11111111-2222-4333-8444-555555555555</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
