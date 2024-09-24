// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateRtcRobotInstanceRequest : TeaModel {
        [NameInMap("Config")]
        [Validation(Required=false)]
        public UpdateRtcRobotInstanceRequestConfig Config { get; set; }
        public class UpdateRtcRobotInstanceRequestConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableVoiceInterrupt")]
            [Validation(Required=false)]
            public bool? EnableVoiceInterrupt { get; set; }

            [NameInMap("Greeting")]
            [Validation(Required=false)]
            public string Greeting { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhixiaoxia</para>
            /// </summary>
            [NameInMap("VoiceId")]
            [Validation(Required=false)]
            public string VoiceId { get; set; }

        }

        /// <summary>
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
