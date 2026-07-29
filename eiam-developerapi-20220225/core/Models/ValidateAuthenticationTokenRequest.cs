// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ValidateAuthenticationTokenRequest : TeaModel {
        /// <summary>
        /// <para>The original authentication token.</para>
        /// <remarks>
        /// <para>Pass either the original authentication token or a derived short token.</para>
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
        /// <para>A hint about the type of the authentication token.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>No value is currently required for this parameter.</para>
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
