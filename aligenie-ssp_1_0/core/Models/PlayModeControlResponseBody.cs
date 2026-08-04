// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class PlayModeControlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code of the invocation</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Additional information, typically used to briefly describe a failed invocation to help the caller troubleshoot the issue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002398812</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Actual return result of the service</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public PlayModeControlResponseBodyResult Result { get; set; }
        public class PlayModeControlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Playback mode</para>
            /// <para>List loop: Repeat; Shuffle: Shuffle; Single-track loop: RepeatOne; NAT mode: Normal;</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OpenPlayMode")]
            [Validation(Required=false)]
            public string OpenPlayMode { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded. true indicates success, and false indicates failure. When the value is false, check the Message field for details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
