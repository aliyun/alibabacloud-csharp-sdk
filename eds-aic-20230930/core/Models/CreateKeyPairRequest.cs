// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateKeyPairRequest : TeaModel {
        /// <summary>
        /// <para>The name of the key pair. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with http:// or https://. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
