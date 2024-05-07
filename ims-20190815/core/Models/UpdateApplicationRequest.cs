// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateApplicationRequest : TeaModel {
        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The validity period of the access token.
        /// 
        /// Valid values: 900 to 10800. Unit: seconds.
        /// </summary>
        [NameInMap("NewAccessTokenValidity")]
        [Validation(Required=false)]
        public int? NewAccessTokenValidity { get; set; }

        /// <summary>
        /// The display name.
        /// </summary>
        [NameInMap("NewDisplayName")]
        [Validation(Required=false)]
        public string NewDisplayName { get; set; }

        /// <summary>
        /// Specifies whether the application can be installed by using other Alibaba Cloud accounts. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("NewIsMultiTenant")]
        [Validation(Required=false)]
        public bool? NewIsMultiTenant { get; set; }

        /// <summary>
        /// The permission that is granted on the application.
        /// 
        /// For more information about the application permission scope, see [OAuth scopes](~~93693~~). You can also call the [ListPredefinedScopes](~~187206~~) operation to query the permissions that are supported by different types of applications.
        /// 
        /// If you enter multiple permissions, separate them with semicolons (;).
        /// 
        /// The new value of this parameter overwrites the original value, and the permission specified by the new value takes effect. For example, if the original value is `/acs/ccc`, and the new value is `/acs/alidns`, `/acs/alidns` takes effect. If you want to retain the original permission and the `/acs/alidns` permission, set the value to `/acs/ccc;/acs/alidns`.
        /// </summary>
        [NameInMap("NewPredefinedScopes")]
        [Validation(Required=false)]
        public string NewPredefinedScopes { get; set; }

        /// <summary>
        /// The callback URL.
        /// 
        /// If you enter multiple callback URLs, separate them with semicolons (;).
        /// </summary>
        [NameInMap("NewRedirectUris")]
        [Validation(Required=false)]
        public string NewRedirectUris { get; set; }

        /// <summary>
        /// The validity period of the refresh token.
        /// 
        /// Valid values: 7200 to 31536000. Unit: seconds.
        /// </summary>
        [NameInMap("NewRefreshTokenValidity")]
        [Validation(Required=false)]
        public int? NewRefreshTokenValidity { get; set; }

        /// <summary>
        /// The required permission.
        /// 
        /// You can specify one or more permissions for the `RequiredScopes` parameter. After you specify this parameter, the required permissions are automatically selected and cannot be revoked when a user grants permissions on the application.
        /// 
        /// If you also specify the `NewPredefinedScopes` parameter, the `NewPredefinedScopes` parameter specifies the permissions that can be granted on the application, and this parameter specifies the required permissions.
        /// 
        /// If you enter multiple permissions, separate them with semicolons (;).
        /// 
        /// The new value of this parameter overwrites the original value, and the required permission specified by the new value takes effect.
        /// 
        /// >  If the permission that you specify for the `RequiredScopes` parameter is not included in value of the `PredefinedScopes` parameter, the permission does not take effect.
        /// </summary>
        [NameInMap("NewRequiredScopes")]
        [Validation(Required=false)]
        public string NewRequiredScopes { get; set; }

        /// <summary>
        /// Specifies whether a secret is required. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// > 
        /// 
        /// *   For applications of the WebApp and ServerApp types, this parameter is automatically set to true and cannot be changed.
        /// *   For applications of the NativeApp type, this parameter can be set to true or false. If you do not set this parameter, false is used. Applications of the NativeApp type run in untrusted environments and the secrets of these applications are not protected. Therefore, we recommend that you do not set this parameter to true unless otherwise specified. For more information, see [Use an application of the NativeApp type to log on to Alibaba Cloud](~~93697~~).
        /// </summary>
        [NameInMap("NewSecretRequired")]
        [Validation(Required=false)]
        public bool? NewSecretRequired { get; set; }

    }

}
