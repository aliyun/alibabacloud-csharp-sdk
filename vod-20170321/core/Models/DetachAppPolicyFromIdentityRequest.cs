// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityRequest : TeaModel {
        /// <summary>
        /// The ID of the application. This parameter is optional if you set PolicyNames to VODAppAdministratorAccess. This parameter is required if you set PolicyNames to a value other than VODAppAdministratorAccess.
        /// 
        /// *   Default value: **app-1000000**.
        /// *   For more information, see [Overview](https://help.aliyun.com/document_detail/113600.html).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the RAM user or the name of the RAM role.
        /// 
        /// *   Specifies the ID of the RAM user for this parameter if you set IdentityType to RamUser.
        /// *   Specifies the name of the RAM role for this parameter if you set IdentityType to RamRole.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdentityName")]
        [Validation(Required=false)]
        public string IdentityName { get; set; }

        /// <summary>
        /// The type of the identity. Valid values:
        /// 
        /// *   **RamUser**: RAM user
        /// *   **RamRole**: RAM role
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The name of the policy. Separate multiple names with commas (,). Only system policies are supported.
        /// 
        /// *   **VODAppFullAccess**: permissions to manage all resources in an application
        /// *   **VODAppReadOnlyAccess**: permissions to read all resources in an application
        /// *   **VODAppAdministratorAccess**: permissions of the application administrator
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyNames")]
        [Validation(Required=false)]
        public string PolicyNames { get; set; }

    }

}
