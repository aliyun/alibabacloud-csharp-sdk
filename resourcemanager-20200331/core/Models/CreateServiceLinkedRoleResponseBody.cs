// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateServiceLinkedRoleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the role.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public CreateServiceLinkedRoleResponseBodyRole Role { get; set; }
        public class CreateServiceLinkedRoleResponseBodyRole : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the role.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The document of the trust policy for the role.
            /// </summary>
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }

            /// <summary>
            /// The time when the role was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The description of the role.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the role is a service-linked role. Valid values:
            /// 
            /// *   true: The role is a service-linked role.
            /// *   false: The role is not a service-linked role.
            /// </summary>
            [NameInMap("IsServiceLinkedRole")]
            [Validation(Required=false)]
            public bool? IsServiceLinkedRole { get; set; }

            /// <summary>
            /// The ID of the role.
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// The name of the role.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The role name that uses a domain name as the suffix.
            /// </summary>
            [NameInMap("RolePrincipalName")]
            [Validation(Required=false)]
            public string RolePrincipalName { get; set; }

        }

    }

}
