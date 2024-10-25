// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteKeyPairsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SSH key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssh-5lywanlkih1zo9yl8eg****</para>
        /// </summary>
        [NameInMap("KeyPairId")]
        [Validation(Required=false)]
        public string KeyPairId { get; set; }

        /// <summary>
        /// <para>The name of the key pair. The name must conform to the following naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// <para>Before you delete a key pair, you can call the DescribeKeyPairs operation to query existing key pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

    }

}
