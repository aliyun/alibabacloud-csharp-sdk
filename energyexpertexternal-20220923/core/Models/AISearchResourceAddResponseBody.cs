// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class AISearchResourceAddResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public AISearchResourceAddResponseBodyData Data { get; set; }
        public class AISearchResourceAddResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>WzMGQZwB7nQEs3Qk3ajH</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>miniapp</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A0AEC56-5C9A-5D47-93DF-7227836FFF82</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
