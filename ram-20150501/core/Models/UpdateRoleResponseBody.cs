// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class UpdateRoleResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the RAM role.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public UpdateRoleResponseBodyRole Role { get; set; }
        public class UpdateRoleResponseBodyRole : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the role.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The policy that specifies the trusted entity to assume the RAM role.
            /// </summary>
            [NameInMap("AssumeRolePolicyDocument")]
            [Validation(Required=false)]
            public string AssumeRolePolicyDocument { get; set; }

            /// <summary>
            /// The time when the RAM role was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The description of the RAM role.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The maximum session duration of the RAM role.
            /// </summary>
            [NameInMap("MaxSessionDuration")]
            [Validation(Required=false)]
            public long? MaxSessionDuration { get; set; }

            /// <summary>
            /// The ID of the RAM role.
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            /// <summary>
            /// The name of the RAM role.
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// The time when the description of the RAM role was changed.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

    }

}
