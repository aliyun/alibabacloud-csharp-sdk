// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityRequest : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The name of the policy. Separate multiple policies with commas (,). Only system policies are supported.
        /// 
        /// *   **VODAppFullAccess**: authorizes an identity to manage all resources in an application.
        /// *   **VODAppReadOnlyAccess**: authorizes an identity to access all resources in an application in read-only mode.
        /// *   **VODAppAdministratorAccess**: assigns the application administrator role to an identity.
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// The ID of the application. This parameter is optional when the PolicyNames parameter is set to VODAppAdministratorAccess. This parameter is required when the PolicyNames parameter is set to other values.
        /// 
        /// *   Default value: **app-1000000**.
        /// *   For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DetachAppPolicyFromIdentity**.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

    }

}
