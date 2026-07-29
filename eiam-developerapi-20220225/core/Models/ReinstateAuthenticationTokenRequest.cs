// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ReinstateAuthenticationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The original authentication token.</para>
        /// <remarks>
        /// <para>You can pass either the original authentication token or its derived short token.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOixxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>A hint about the authentication token type.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Do not provide a value for this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("token_type_hint")]
        [Validation(Required=false)]
        public string TokenTypeHint { get; set; }

    }

}
