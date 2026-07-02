// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKeyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID or Alibaba Cloud Resource Name (ARN) of the key.</para>
        /// <remarks>
        /// <para>When you access a key in another Alibaba Cloud account, you must enter the ARN of the key. The ARN of a key is in the <c>acs:kms:${region}:${account}:key/${keyid}</c> format.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz630494463ejqjx****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The name of the key policy. Only the static value default is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
