// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The key value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apikey-xxxxxxxx</para>
        /// </summary>
        [NameInMap("secretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

    }

}
