// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateSignatureRequest : TeaModel {
        /// <summary>
        /// <para>The security token included in the WebSocket request header. The system uses this token to authenticate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fa876ffb-caab-4f0a-93b3-3409f2fa5199</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The Key value of the key. The value must be 6 to 20 characters in length and can contain letters, digits, and underscores (_). It must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwertyuiop</para>
        /// </summary>
        [NameInMap("SignatureKey")]
        [Validation(Required=false)]
        public string SignatureKey { get; set; }

        /// <summary>
        /// <para>The displayed name of the key. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). It must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backendsignature</para>
        /// </summary>
        [NameInMap("SignatureName")]
        [Validation(Required=false)]
        public string SignatureName { get; set; }

        /// <summary>
        /// <para>The Secret value of the key. The value must be 6 to 30 characters in length and can contain letters, digits, and special characters. Special characters include underscores (_), at signs (@), number signs (#), exclamation points (!), and asterisks (\*). The value must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdfghjkl</para>
        /// </summary>
        [NameInMap("SignatureSecret")]
        [Validation(Required=false)]
        public string SignatureSecret { get; set; }

    }

}
