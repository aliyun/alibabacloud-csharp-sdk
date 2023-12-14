// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// The validity period of the access token.
        /// 
        /// Valid values: 900 to 10800. Unit: seconds.
        /// 
        /// Default value: 3600.
        /// </summary>
        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public int? AccessTokenValidity { get; set; }

        /// <summary>
        /// The name of the application.
        /// 
        /// The name can be up to 64 characters in length. The name can contain letters, digits, periods (.), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The type of the application. Valid values:
        /// 
        /// *   WebApp: a web application that interacts with a browser.
        /// *   NativeApp: a native application that runs on an operating system, such as a desktop operating system or a mobile operating system.
        /// *   ServerApp: an application that accesses Alibaba Cloud services without the need of manual user logon. User provisioning is automated based on the System for Cross-Domain Identity Management (SCIM) protocol.
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// The display name of the application.
        /// 
        /// The name can be up to 24 characters in length.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the application can be installed by using other Alibaba Cloud accounts. Valid values:
        /// 
        /// *   true: If you do not set this parameter for applications of the NativeApp and ServerApp types, true is used.
        /// *   false: If you do not set this parameter for applications of the WebApp type, false is used.
        /// </summary>
        [NameInMap("IsMultiTenant")]
        [Validation(Required=false)]
        public bool? IsMultiTenant { get; set; }

        /// <summary>
        /// The scope of application permissions.
        /// 
        /// For more information about the application permission scope, see [Open authorization scope](~~93693~~). You can also call the [ListPredefinedScopes](~~187206~~) operation to obtain the permission scopes supported by different types of applications.
        /// 
        /// If you enter multiple permission scopes, separate them with semicolons (;).
        /// </summary>
        [NameInMap("PredefinedScopes")]
        [Validation(Required=false)]
        public string PredefinedScopes { get; set; }

        /// <summary>
        /// The callback URL.
        /// 
        /// If you enter multiple callback URLs, separate them with semicolons (;).
        /// </summary>
        [NameInMap("RedirectUris")]
        [Validation(Required=false)]
        public string RedirectUris { get; set; }

        /// <summary>
        /// The validity period of the refreshed token.
        /// 
        /// Valid values: 7200 to 31536000. Unit: seconds.
        /// 
        /// Default value:
        /// 
        /// *   For applications of the WebApp and ServerApp types, if this parameter is left empty, the value 2592000 is used. The value 2592000 indicates that the validity period of the refreshed token is 30 days.
        /// *   For applications of the NativeApp type, if this parameter is left empty, the value 7776000 is used. The value 7776000 indicates that the validity period of the refreshed token is 90 days.
        /// </summary>
        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public int? RefreshTokenValidity { get; set; }

        [NameInMap("RequiredScopes")]
        [Validation(Required=false)]
        public string RequiredScopes { get; set; }

        /// <summary>
        /// Indicates whether a secret is required. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >- For applications of the WebApp and ServerApp types, this parameter is automatically set to true and cannot be changed.
        /// >- For applications of the NativeApp type, this parameter can be set to true or false. If you do not set this parameter, false is used. Applications of the NativeApp type run in untrusted environments and the secrets of these applications are not protected. Therefore, we recommend that you do not set this parameter to true unless otherwise specified. For more information, see [Use an application of the NativeApp type to log on to Alibaba Cloud](~~93697~~).
        /// </summary>
        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

    }

}
