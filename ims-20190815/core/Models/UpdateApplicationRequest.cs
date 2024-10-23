// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>472457090344041****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The validity period of the access token.</para>
        /// <para>Valid values: 900 to 10800. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("NewAccessTokenValidity")]
        [Validation(Required=false)]
        public int? NewAccessTokenValidity { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewApp</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether the application can be installed by using other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewIsMultiTenant")]
        [Validation(Required=false)]
        public bool? NewIsMultiTenant { get; set; }

        /// <summary>
        /// <para>The permission that is granted on the application.</para>
        /// <para>For more information about the application permission scope, see <a href="https://help.aliyun.com/document_detail/93693.html">OAuth scopes</a>. You can also call the <a href="https://help.aliyun.com/document_detail/187206.html">ListPredefinedScopes</a> operation to query the permissions that are supported by different types of applications.</para>
        /// <para>If you enter multiple permissions, separate them with semicolons (;).</para>
        /// <para>The new value of this parameter overwrites the original value, and the permission specified by the new value takes effect. For example, if the original value is <c>/acs/ccc</c>, and the new value is <c>/acs/alidns</c>, <c>/acs/alidns</c> takes effect. If you want to retain the original permission and the <c>/acs/alidns</c> permission, set the value to <c>/acs/ccc;/acs/alidns</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openid</para>
        /// </summary>
        [NameInMap("NewPredefinedScopes")]
        [Validation(Required=false)]
        public string NewPredefinedScopes { get; set; }

        /// <summary>
        /// <para>The callback URL.</para>
        /// <para>If you enter multiple callback URLs, separate them with semicolons (;).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("NewRedirectUris")]
        [Validation(Required=false)]
        public string NewRedirectUris { get; set; }

        /// <summary>
        /// <para>The validity period of the refresh token.</para>
        /// <para>Valid values: 7200 to 31536000. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7776000</para>
        /// </summary>
        [NameInMap("NewRefreshTokenValidity")]
        [Validation(Required=false)]
        public int? NewRefreshTokenValidity { get; set; }

        /// <summary>
        /// <para>The required permission.</para>
        /// <para>You can specify one or more permissions for the <c>RequiredScopes</c> parameter. After you specify this parameter, the required permissions are automatically selected and cannot be revoked when a user grants permissions on the application.</para>
        /// <para>If you also specify the <c>NewPredefinedScopes</c> parameter, the <c>NewPredefinedScopes</c> parameter specifies the permissions that can be granted on the application, and this parameter specifies the required permissions.</para>
        /// <para>If you enter multiple permissions, separate them with semicolons (;).</para>
        /// <para>The new value of this parameter overwrites the original value, and the required permission specified by the new value takes effect.</para>
        /// <remarks>
        /// <para> If the permission that you specify for the <c>RequiredScopes</c> parameter is not included in value of the <c>PredefinedScopes</c> parameter, the permission does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>profile;aliuid</para>
        /// </summary>
        [NameInMap("NewRequiredScopes")]
        [Validation(Required=false)]
        public string NewRequiredScopes { get; set; }

        /// <summary>
        /// <para>Specifies whether a secret is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For applications of the WebApp and ServerApp types, this parameter is automatically set to true and cannot be changed.</description></item>
        /// <item><description>For applications of the NativeApp type, this parameter can be set to true or false. If you do not set this parameter, false is used. Applications of the NativeApp type run in untrusted environments and the secrets of these applications are not protected. Therefore, we recommend that you do not set this parameter to true unless otherwise specified. For more information, see <a href="https://help.aliyun.com/document_detail/93697.html">Use an application of the NativeApp type to log on to Alibaba Cloud</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewSecretRequired")]
        [Validation(Required=false)]
        public bool? NewSecretRequired { get; set; }

    }

}
