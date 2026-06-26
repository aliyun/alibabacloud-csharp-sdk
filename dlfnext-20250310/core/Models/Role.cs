// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Role : TeaModel {
        /// <summary>
        /// <para>The time when the role was created. This is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The name of the user who created the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The role description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_display_name</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Indicates whether the role is a system role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isPredefined")]
        [Validation(Required=false)]
        public string IsPredefined { get; set; }

        /// <summary>
        /// <para>The name of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_name</para>
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The resource descriptor of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:dlf::[accountId]:role/role_name</para>
        /// </summary>
        [NameInMap("rolePrincipal")]
        [Validation(Required=false)]
        public string RolePrincipal { get; set; }

        /// <summary>
        /// <para>The time when the role was last updated. This is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1744970111419</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The name of the user who last updated the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::[accountId]:root</para>
        /// </summary>
        [NameInMap("updatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// <para>The users for the role.</para>
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<User> Users { get; set; }

    }

}
