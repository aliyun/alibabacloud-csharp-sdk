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
        /// The validity period of the new access token.
        /// 
        /// Valid values: 900 to 10800. Unit: seconds.
        /// </summary>
        [NameInMap("NewAccessTokenValidity")]
        [Validation(Required=false)]
        public int? NewAccessTokenValidity { get; set; }

        /// <summary>
        /// The new display name of the application.
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
        /// The new scope of application permissions.
        /// 
        /// For more information about the application permission scope, see [Open authorization scope](~~93693~~). You can also call the [ListPredefinedScopes](~~187206~~) operation to obtain the permission scopes supported by different types of applications.
        /// 
        /// Separate multiple permission scopes with semicolons (;).
        /// 
        /// If you specify a new permission scope, the new permission scope takes effect. For example, if the original permission scope is `/acs/ccc`, and the new permission scope is `/acs/alidns`, `/acs/alidns` takes effect. If you want to retain the original permission scope, set the new permission scope to `/acs/ccc;/acs/alidns`.
        /// </summary>
        [NameInMap("NewPredefinedScopes")]
        [Validation(Required=false)]
        public string NewPredefinedScopes { get; set; }

        /// <summary>
        /// The new callback URL.
        /// 
        /// Separate multiple callback URLs with semicolons (;).
        /// </summary>
        [NameInMap("NewRedirectUris")]
        [Validation(Required=false)]
        public string NewRedirectUris { get; set; }

        /// <summary>
        /// The validity period of the refreshed token.
        /// 
        /// Valid values: 7200 to 31536000. Unit: seconds.
        /// </summary>
        [NameInMap("NewRefreshTokenValidity")]
        [Validation(Required=false)]
        public int? NewRefreshTokenValidity { get; set; }

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
