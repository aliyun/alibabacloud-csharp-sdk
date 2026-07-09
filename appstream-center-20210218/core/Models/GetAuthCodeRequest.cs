// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetAuthCodeRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        [NameInMap("AdPassword")]
        [Validation(Required=false)]
        public string AdPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously create an EndUserId based on ExternalUserId. This parameter takes effect only when EndUserId is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateUser")]
        [Validation(Required=false)]
        public bool? AutoCreateUser { get; set; }

        /// <summary>
        /// <para>The username of the China Desktop Service (China Desktop Service) convenience account. The username must be unique within an Alibaba Cloud account. This parameter and ExternalUserId cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The external user ID. This ID is defined by the caller and must be unique within an Alibaba Cloud account. This parameter and EndUserId cannot both be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The access policy that restricts the access permissions of the authorization code. If this parameter is left empty, no restrictions are applied.</para>
        /// <para>Syntax:</para>
        /// <pre><code class="language-json">{
        ///       &quot;Version&quot;: &quot;1&quot;,
        ///       &quot;Resource&quot;: {
        ///             &quot;Type&quot;: &quot;&lt;Resource type&gt;&quot;,
        ///             &quot;Id&quot;: &quot;&lt;Resource ID&gt;&quot;
        ///       }
        /// }
        /// </c></pre>
        /// <para>Valid values of <Resource type>:</para>
        /// <list type="bullet">
        /// <item><description>AppInstanceGroup: delivery group. You can call the ListAppInstanceGroup operation to obtain the ID.</description></item>
        /// <item><description>AppInstance: application instance (dedicated field).</description></item>
        /// <item><description>App: application. You can call the ListAppInstanceGroup operation to obtain the ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Version&quot;: &quot;1&quot;,
        ///       &quot;Resource&quot;: {
        ///             &quot;Type&quot;: &quot;AppInstanceGroup&quot;,
        ///             &quot;Id&quot;: &quot;aig-9ciijz60n4xsv****&quot;
        ///       }
        /// }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
