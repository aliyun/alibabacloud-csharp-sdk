// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class E2BNetwork : TeaModel {
        /// <summary>
        /// <para>The allowlist for outbound access from the sandbox. After configuration, the sandbox can access only the destinations in the list.</para>
        /// </summary>
        [NameInMap("allowOut")]
        [Validation(Required=false)]
        public List<string> AllowOut { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow Direct Internet Access to the sandbox.</para>
        /// </summary>
        [NameInMap("allowPublicTraffic")]
        [Validation(Required=false)]
        public bool? AllowPublicTraffic { get; set; }

        /// <summary>
        /// <para>The denylist for outbound access from the sandbox. After configuration, the sandbox cannot access the destinations in the list.</para>
        /// </summary>
        [NameInMap("denyOut")]
        [Validation(Required=false)]
        public List<string> DenyOut { get; set; }

        /// <summary>
        /// <para>The domain name used to rewrite the request Host header when accessing the sandbox. If this parameter is not specified, the original Host is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox.example.com</para>
        /// </summary>
        [NameInMap("maskRequestHost")]
        [Validation(Required=false)]
        public string MaskRequestHost { get; set; }

    }

}
