// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateRtcRobotInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The configuration for the AI Agent instance.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public UpdateRtcRobotInstanceRequestConfig Config { get; set; }
        public class UpdateRtcRobotInstanceRequestConfig : TeaModel {
            /// <summary>
            /// <para>Controls whether voice interrupt is enabled. This change takes effect immediately.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            /// <summary>
            /// <para>The greeting message. The greeting is not updated if it has already been played.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello</para>
            /// </summary>
            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <para>The ID of the voice. The new voice takes effect on the AI Agent\&quot;s next utterance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the AI Agent instance to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727dc0e296014bb58670940a3da95592</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
