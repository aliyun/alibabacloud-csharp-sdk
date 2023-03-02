// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class GetCallerIdentityResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account to which the current requester belongs.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the current requester.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The type of the identity. Valid values:
        /// 
        /// - Account: an Alibaba Cloud account
        /// - RamUser: a RAM user
        /// - AssumedRoleUser: a RAM role
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The ID of the principal.
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the RAM role.
        /// 
        /// > This parameter is returned only when the current requester uses a RAM role.
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// The ID of the current requester.
        /// 
        /// - If the requester uses an Alibaba Cloud account to call the operation, the ID of the Alibaba Cloud account is returned.
        /// - If the requester uses a RAM user to call the operation, the ID of the RAM user is returned.
        /// 
        /// > This parameter is returned only when the current requester uses an Alibaba Cloud account or a RAM user.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
