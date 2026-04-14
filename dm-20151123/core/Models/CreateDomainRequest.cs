// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>Domain name, length 1-50, can include numbers, uppercase letters, lowercase letters, ., and -.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub.example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The selector field in the DKIM protocol, used to identify a specific public key. It is recommended to leave it blank, as the system will automatically generate it based on cluster information. If the user specifies it manually, for example, if the sending domain is &quot;sub.example.com&quot; and dkimSelector is set to &quot;default&quot;, then the host record will be &quot;default._domainkey.sub&quot;
        /// Constraints: </para>
        /// <ol>
        /// <item><description>The length must not exceed 60 characters. </description></item>
        /// <item><description>It must consist of visible characters only. </description></item>
        /// <item><description>It cannot start with a hyphen (-). </description></item>
        /// <item><description>It cannot end with a hyphen (-). </description></item>
        /// <item><description>It cannot contain any of the following characters: _ :;/!*~.@#$%^&amp;()+=[{]}|?&lt;&gt;,\&quot;&quot;</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dkimSelector")]
        [Validation(Required=false)]
        public string DkimSelector { get; set; }

    }

}
