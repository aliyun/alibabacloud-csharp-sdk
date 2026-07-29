// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class RevokeAuthenticationTokenRequest : TeaModel {
        /// <summary>
        /// <para>Original authentication token.</para>
        /// <remarks>
        /// <para>You can pass either the original authentication token or a derived short token.</para>
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
        /// <para>Authentication token type hint.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Currently, no value is required.</para>
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
