// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AttachAppPolicyToIdentityRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Overview](~~113600~~).
        /// > This parameter is optional when the PolicyNames parameter is set to VODAppAdministratorAccess. This parameter is required when the PolicyNames parameter is set to other values.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the identity.
        /// *   Specifies the ID of the RAM user when the IdentityType parameter is set to RamUser.
        /// *   Specifies the name of the RAM role when the IdentityType parameter is set to RamRole.
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// The type of the identity. Valid values:
        /// *   **RamUser**: a RAM user.
        /// *   **RamRole**: a RAM role.
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The name of the policy. Only system policies are supported. Separate multiple policies with commas (,). Valid values:
        /// *   **VODAppFullAccess**: authorizes an identity to manage all resources in an application.
        /// *   **VODAppReadOnlyAccess**: authorizes an identity to access all resources in an application in read-only mode.
        /// *   **VODAppAdministratorAccess**: assigns the application administrator role to an identity.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

    }

}
