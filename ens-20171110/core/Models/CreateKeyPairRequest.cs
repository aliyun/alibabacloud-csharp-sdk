// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateKeyPairRequest : TeaModel {
        /// <summary>
        /// <para>The name of the key pair. The name must conform to the following naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// <item><description>It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
