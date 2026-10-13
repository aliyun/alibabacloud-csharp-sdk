// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HandleOidcCallbackRequest : TeaModel {
        /// <summary>
        /// <para>The code parameter carried in the OIDC callback request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-xxxxxxxx</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The state parameter carried in the OIDC callback request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>state-xxxxxxxx</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
