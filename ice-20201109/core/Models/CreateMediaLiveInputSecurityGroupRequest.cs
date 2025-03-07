// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateMediaLiveInputSecurityGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the security group. Letters, digits, hyphens (-), and underscores (_) are supported. The maximum length is 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysg</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The security group rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10.1.1.0/24&quot;, &quot;11.11.11.11/0&quot;]</para>
        /// </summary>
        [NameInMap("WhitelistRules")]
        [Validation(Required=false)]
        public List<string> WhitelistRules { get; set; }

    }

}
