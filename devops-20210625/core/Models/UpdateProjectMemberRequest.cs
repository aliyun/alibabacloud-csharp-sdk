// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateProjectMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project.admin</para>
        /// </summary>
        [NameInMap("roleIdentifier")]
        [Validation(Required=false)]
        public string RoleIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5e70xxxxxxcd000xxxxe96</para>
        /// </summary>
        [NameInMap("targetIdentifier")]
        [Validation(Required=false)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Space</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19xx7043xxxxxxx914</para>
        /// </summary>
        [NameInMap("userIdentifier")]
        [Validation(Required=false)]
        public string UserIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("userType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
