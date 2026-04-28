// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Permission : TeaModel {
        /// <summary>
        /// <para>Action list.</para>
        /// </summary>
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<PermissionActionList> ActionList { get; set; }
        public class PermissionActionList : TeaModel {
            /// <summary>
            /// <para>Specific action, such as FILE.ALL</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE.ALL</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

        }

        /// <summary>
        /// <para>The permission set. Set this parameter to global for global permissions. In other scenarios, this parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>Condition</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public PermissionCondition Condition { get; set; }

        /// <summary>
        /// <para>The creation time in the millisecond timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703648502811</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>Effect. Valid values: allow, deny.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// <para>Identity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af22***</para>
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <para>Identity type. Valid values: IT_User, IT_Group, IT_Role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT_User</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fa212***</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The type of the resource. The file type resource is RT_File.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RT_File</para>
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The time when the modification was made. The value is a millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703648502811</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>Custom tag.</para>
        /// </summary>
        [NameInMap("user_tags")]
        [Validation(Required=false)]
        public List<string> UserTags { get; set; }

    }

}
