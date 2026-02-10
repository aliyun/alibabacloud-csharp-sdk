// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AuthConfig : TeaModel {
        /// <summary>
        /// <para>The authentication mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoAuth</para>
        /// </summary>
        [NameInMap("authMode")]
        [Validation(Required=false)]
        public string AuthMode { get; set; }

        /// <summary>
        /// <para>The authentication type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jwt</para>
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

    }

}
