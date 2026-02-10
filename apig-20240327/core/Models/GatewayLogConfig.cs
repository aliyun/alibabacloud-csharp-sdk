// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayLogConfig : TeaModel {
        /// <summary>
        /// <para>The Simple Log Service configurations.</para>
        /// </summary>
        [NameInMap("slsConfig")]
        [Validation(Required=false)]
        public GatewayLogConfigSlsConfig SlsConfig { get; set; }
        public class GatewayLogConfigSlsConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to activate Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

    }

}
