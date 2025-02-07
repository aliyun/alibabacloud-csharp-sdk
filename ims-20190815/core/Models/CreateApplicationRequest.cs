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
        /// <para>The name can be up to 64 characters in length. The name can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
        /// <item><description>WebApp: a web application that interacts with a browser.</description></item>
        /// <item><description>NativeApp: a native application that runs on an operating system, such as a desktop operating system or a mobile operating system.</description></item>
        /// <item><description>ServerApp: an application that accesses Alibaba Cloud services without the need of manual user logon. User provisioning is automated based on the System for Cross-Domain Identity Management (SCIM) protocol.</description></item>
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
        /// <para>Indicates whether the application can be installed by using other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: If you do not set this parameter for applications of the NativeApp and ServerApp types, true is used.</description></item>
        /// <item><description>false: If you do not set this parameter for applications of the WebApp type, false is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsMultiTenant")]
        [Validation(Required=false)]
        public bool? IsMultiTenant { get; set; }

        /// <summary>
        /// <para>The scope of application permissions.</para>
        /// <para>For more information about the application permission scope, see <a href="https://help.aliyun.com/document_detail/93693.html">Open authorization scope</a>. You can also call the <a href="https://help.aliyun.com/document_detail/187206.html">ListPredefinedScopes</a> operation to query the permissions that are supported by different types of applications.</para>
        /// <para>If you enter multiple permission scopes, separate them with semicolons (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid</para>
        /// </summary>
        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public string PredefinedScopes { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// <para>If you enter multiple callback URLs, separate them with semicolons (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("RedirectUris")]
        [Validation(Required=false)]
        public string RedirectUris { get; set; }

        /// <summary>
        /// <para>The validity period of the refreshed token.</para>
        /// <para>Valid values: 7200 to 31536000. Unit: seconds.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>For applications of the WebApp and ServerApp types, if this parameter is left empty, the value 2592000 is used. The value 2592000 indicates that the validity period of the refreshed token is 30 days.</description></item>
        /// <item><description>For applications of the NativeApp type, if this parameter is left empty, the value 7776000 is used. The value 7776000 indicates that the validity period of the refreshed token is 90 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2592000</para>
        /// </summary>
        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public int? RefreshTokenValidity { get; set; }

        /// <summary>
        /// <para>The required permission.</para>
        /// <para>You can specify one or more permissions for the <c>RequiredScopes</c> parameter. After you specify this parameter, the required permissions are automatically selected and cannot be revoked when a user grants permissions on the application.</para>
        /// <para>If you enter multiple permission scopes, separate them with semicolons (;).</para>
        /// <remarks>
        /// <para> If the permission that you specify for the <c>RequiredScopes</c> parameter is not included in the value of the <c>PredefinedScopes</c> parameter, the permission does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid;profile</para>
        /// </summary>
        [NameInMap("RequiredScopes")]
        [Validation(Required=false)]
        public string RequiredScopes { get; set; }

        /// <summary>
        /// <para>Indicates whether a secret is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For applications of the WebApp and ServerApp types, this parameter is automatically set to true and cannot be changed.</description></item>
        /// <item><description>For applications of the NativeApp type, this parameter can be set to true or false. If you do not set this parameter, false is used. Applications of the NativeApp type run in untrusted environments and the secrets of these applications are not protected. Therefore, we recommend that you do not set this parameter to true unless otherwise specified. For more information, see <a href="https://help.aliyun.com/document_detail/93697.html">Use an application of the NativeApp type to log on to Alibaba Cloud</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

    }

}
