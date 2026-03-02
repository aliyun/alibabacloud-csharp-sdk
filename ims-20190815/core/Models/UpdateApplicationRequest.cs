// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
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
        /// <para>The new display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewApp</para>
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// <para>Indicates whether the application can be installed by other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The application can be installed.</para>
        /// </description></item>
        /// <item><description><para>false: The application cannot be installed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NewIsMultiTenant")]
        [Validation(Required=false)]
        public bool? NewIsMultiTenant { get; set; }

        /// <summary>
        /// <para>The permission scopes of the application.</para>
        /// <para>For more information about the valid values and descriptions of permission scopes, see <a href="https://help.aliyun.com/document_detail/93693.html">OAuth scopes</a>. You can also call the <a href="https://help.aliyun.com/document_detail/187206.html">ListPredefinedScopes</a> operation to obtain the permission scopes that are supported by different types of applications.</para>
        /// <para>If you enter multiple permission scopes, separate them with semicolons (;).</para>
        /// <para>The new permission scopes overwrite the original ones. For example, if the original permission scope is <c>/acs/ccc</c> and you set the new permission scope to <c>/acs/alidns</c>, the permission scope that takes effect is <c>/acs/alidns</c>. If you want to add <c>/acs/alidns</c> to the original scope, set the new permission scope to <c>/acs/ccc;/acs/alidns</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openid</para>
        /// </summary>
        [NameInMap("NewPredefinedScopes")]
        [Validation(Required=false)]
        public string NewPredefinedScopes { get; set; }

        /// <summary>
        /// <para>The webhook address.</para>
        /// <para>If you enter multiple webhook addresses, separate them with semicolons (;).</para>
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
        /// <para>The required permission scopes of the application.</para>
        /// <para>You can set one or more scopes specified in <c>RequiredScopes</c> as required. After a scope is set as required, it is selected by default and cannot be deselected when a user grants permissions to the application.</para>
        /// <para>If you also specify <c>NewPredefinedScopes</c>, the list of application scopes is reset by <c>NewPredefinedScopes</c> first. Then, this parameter is used to configure whether the scopes are required.</para>
        /// <para>If you enter multiple permission scopes, separate them with semicolons (;).</para>
        /// <para>The new required scopes overwrite the original ones.</para>
        /// <remarks>
        /// <para>If a scope that you specify for <c>RequiredScopes</c> is not within the range of <c>PredefinedScopes</c>, the required setting for that scope does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>profile;aliuid</para>
        /// </summary>
        [NameInMap("NewRequiredScopes")]
        [Validation(Required=false)]
        public string NewRequiredScopes { get; set; }

        /// <summary>
        /// <para>Indicates whether an application key is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For applications of the WebApp and ServerApp types, this parameter is forcibly set to true and cannot be modified.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For applications of the NativeApp type, you can set this parameter to true or false. The default value is false. These applications often run in untrusted environments and cannot effectively protect application keys. Do not set this parameter to true unless necessary. For more information, see <a href="https://help.aliyun.com/document_detail/93697.html">Log on to Alibaba Cloud using a native application</a>.</description></item>
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
