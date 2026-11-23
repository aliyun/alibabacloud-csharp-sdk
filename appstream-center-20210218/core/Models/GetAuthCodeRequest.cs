// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetAuthCodeRequest : TeaModel {
        /// <summary>
        /// <para>The account type. Valid values: ad (enterprise AD account) and simple (convenience account).</para>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The Active Directory domain name. This parameter is required when the account type is ad.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad.example.com</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <para>The password of the enterprise AD account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qa****7!Z9</para>
        /// </summary>
        [NameInMap("AdPassword")]
        [Validation(Required=false)]
        public string AdPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously create an EndUserId based on ExternalUserId. This parameter takes effect only when EndUserId is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateUser")]
        [Validation(Required=false)]
        public bool? AutoCreateUser { get; set; }

        /// <summary>
        /// <para>The username of the Wuying convenience account. The username must be unique within an Alibaba Cloud account. This parameter and ExternalUserId cannot be left empty at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The external user ID. This ID is customized by the caller and must be unique within an Alibaba Cloud account. This parameter and ExternalUserId cannot be left empty at the same time.</para>
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
        ///             &quot;Type&quot;: &quot;&lt;resource type&gt;&quot;,
        ///             &quot;Id&quot;: &quot;&lt;resource ID&gt;&quot;
        ///       }
        /// }
        /// </c></pre>
        /// <para>Valid values for <resource type>:</para>
        /// <list type="bullet">
        /// <item><description>AppInstanceGroup: app instance group. You can call the ListAppInstanceGroup operation to obtain the ID.</description></item>
        /// <item><description>AppInstance: app instance. This is a dedicated field.</description></item>
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

        /// <summary>
        /// <para>The token type. Valid values: LoginToken (logon token) and StsToken (temporary identity credential).</para>
        /// 
        /// <b>Example:</b>
        /// <para>StsToken</para>
        /// </summary>
        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
