// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ActivateEdgeMobileAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ActivateEdgeMobileAgentResponseBodyData Data { get; set; }
        public class ActivateEdgeMobileAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The assigned API key. The plaintext value is returned only upon the first activation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpk-81vfd8t8zdfxdf*****</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sn-0001eevqa6jeapl*****</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the request is an idempotent duplicate request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Idempotent")]
            [Validation(Required=false)]
            public bool? Idempotent { get; set; }

            /// <summary>
            /// <para>The EdgeMobile instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>em-uto81vfd8t8z****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C5CEF0A-D6E1-58D3-8750-67DB4F82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
