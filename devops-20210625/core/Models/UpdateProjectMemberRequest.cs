// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectMemberRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleIdentifier")]
        [Validation(Required=false)]
        public string RoleIdentifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetIdentifier")]
        [Validation(Required=false)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIdentifier")]
        [Validation(Required=false)]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
