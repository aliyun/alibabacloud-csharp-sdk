// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardForBase64Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{base64}</para>
        /// </summary>
        [NameInMap("ImageBase64Str")]
        [Validation(Required=false)]
        public string ImageBase64Str { get; set; }

        /// <summary>
        /// <para>Service</para>
        /// 
        /// <b>Example:</b>
        /// <para>query_security_check</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;content&quot;:&quot;test&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
