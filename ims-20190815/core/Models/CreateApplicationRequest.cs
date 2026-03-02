// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the access token.</para>
        /// <para>Valid values: 900 to 10800. Unit: seconds.</para>
        /// <para>Default value: 3600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public int? AccessTokenValidity { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>The name can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>WebApp: a web application that is based on browser interaction.</para>
        /// </description></item>
        /// <item><description><para>NativeApp: a native application that runs on an operating system, such as a desktop or mobile operating system.</para>
        /// </description></item>
        /// <item><description><para>ServerApp: an application that directly accesses Alibaba Cloud services without user logon. Currently, only applications that use the System for Cross-domain Identity Management (SCIM) protocol for user synchronization are supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebApp</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The display name of the application.</para>
        /// <para>The name can be up to 24 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the application can be installed by other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: For NativeApp and ServerApp applications, the default value is \<c>true\\</c> if you leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para>false: For WebApp applications, the default value is \<c>false\\</c> if you leave this parameter empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsMultiTenant")]
        [Validation(Required=false)]
        public bool? IsMultiTenant { get; set; }

        /// <summary>
        /// <para>The scopes of the application.</para>
        /// <para>For information about the valid values and descriptions of scopes, see <a href="https://help.aliyun.com/document_detail/93693.html">OAuth scopes</a>. You can also call the <a href="https://help.aliyun.com/document_detail/187206.html">ListPredefinedScopes</a> operation to obtain the scopes that are supported by different application types.</para>
        /// <para>To enter multiple scopes, separate them with semicolons (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid;profile</para>
        /// </summary>
        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public string PredefinedScopes { get; set; }

        /// <summary>
        /// <para>The OAuth protocol version of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>2.0</c>: OAuth 2.0.</para>
        /// </description></item>
        /// <item><description><para><c>2.1</c>: OAuth 2.1.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>2.0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ProtocolVersion")]
        [Validation(Required=false)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// <para>The webhook address.</para>
        /// <para>To enter multiple webhook addresses, separate them with semicolons (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("RedirectUris")]
        [Validation(Required=false)]
        public string RedirectUris { get; set; }

        /// <summary>
        /// <para>The validity period of the refresh token.</para>
        /// <para>Valid values: 7200 to 31536000. Unit: seconds.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>For NativeApp and ServerApp applications, the default value is 2,592,000 seconds (30 days) if you leave this parameter empty.</para>
        /// </description></item>
        /// <item><description><para>For WebApp applications, the default value is 7,776,000 seconds (90 days) if you leave this parameter empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2592000</para>
        /// </summary>
        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public int? RefreshTokenValidity { get; set; }

        /// <summary>
        /// <para>The required scopes.</para>
        /// <para>You can specify one or more scopes in <c>RequiredScopes</c> as required. When a user grants permissions to the application, the required scopes are selected by default and cannot be deselected.</para>
        /// <para>To enter multiple scopes, separate them with semicolons (;).</para>
        /// <remarks>
        /// <para>If a scope that you specify in <c>RequiredScopes</c> is not within the range of <c>PredefinedScopes</c>, the required setting for that scope does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid</para>
        /// </summary>
        [NameInMap("RequiredScopes")]
        [Validation(Required=false)]
        public string RequiredScopes { get; set; }

        /// <summary>
        /// <para>Specifies whether an application key is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For WebApp and ServerApp applications, this parameter is forcibly set to \<c>true\\</c> and cannot be changed.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For NativeApp applications, you can set this parameter to \<c>true\\</c> or \<c>false\\</c>. If you do not set this parameter, the default value is \<c>false\\</c>. Because these applications often run in untrusted environments where application keys cannot be effectively protected, do not set this parameter to \<c>true\\</c> unless necessary. For more information, see <a href="https://help.aliyun.com/document_detail/93697.html">Log on to Alibaba Cloud from a native application</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

    }

}
