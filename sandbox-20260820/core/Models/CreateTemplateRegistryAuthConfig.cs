// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateRegistryAuthConfig : TeaModel {
        /// <summary>
        /// <para>The logon password or access token for the image repository. The value is encrypted on the server side and is not returned in plaintext when queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Passw0rd****</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The username for logging on to the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-puller</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
