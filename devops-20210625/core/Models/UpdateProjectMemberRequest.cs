// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectMemberRequest : TeaModel {
        /// <summary>
        /// 角色id
        /// </summary>
        [NameInMap("roleIdentifier")]
        [Validation(Required=false)]
        public string RoleIdentifier { get; set; }

        /// <summary>
        /// 资源id，也就是项目id
        /// </summary>
        [NameInMap("targetIdentifier")]
        [Validation(Required=false)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("userIdentifier")]
        [Validation(Required=false)]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [NameInMap("userType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
