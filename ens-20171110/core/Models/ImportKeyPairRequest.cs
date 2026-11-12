// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportKeyPairRequest : TeaModel {
        /// <summary>
        /// <para>The name of the key pair. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// <para>Only one key pair name can be specified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The public key content of the key pair. Only one public key can be specified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-rsa AAAAB****</para>
        /// </summary>
        [NameInMap("PublicKeyBody")]
        [Validation(Required=false)]
        public string PublicKeyBody { get; set; }

    }

}
