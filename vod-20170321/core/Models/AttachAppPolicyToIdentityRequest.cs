// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AttachAppPolicyToIdentityRequest : TeaModel {
        /// <summary>
        /// The ID of the application. Default value: **app-1000000**. For more information, see [Multi-application service](~~113600~~).
        /// 
        /// > This parameter is optional only if you set the policy name to VODAppAdministratorAccess.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the RAM user or the name of the RAM role.
        /// 
        /// *   Specify the ID of the RAM user when the IdentityType parameter is set to RamUser.
        /// *   Specify the name of the RAM role when the IdentityType parameter is set to RamRole.
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// The type of the identity. Valid values:
        /// 
        /// *   **RamUser**: a RAM user
        /// *   **RamRole**: a RAM role
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The name of the policy. Only system policies are supported. Separate multiple policy names with commas (,). Valid values:
        /// 
        /// *   **VODAppFullAccess**: permissions to manage all resources in an application.
        /// *   **VODAppReadOnlyAccess**: permissions to read all resources in an application.
        /// *   **VODAppAdministratorAccess**: permissions of the application administrator.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

    }

}
