// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class InitiateOidcAuthRequest : TeaModel {
        /// <summary>
        /// <para>The OIDC provider identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>provider-xxxxxxxx</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
