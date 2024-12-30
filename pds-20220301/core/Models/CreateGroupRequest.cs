// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description of the group. The description can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test group description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the group. The name must be 1 to 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test group</para>
        /// </summary>
        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether the group is a root group. A root group cannot be added to any other group. In most cases, a root group is the top-level organization in the organizational structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_root")]
        [Validation(Required=false)]
        public bool? IsRoot { get; set; }

        /// <summary>
        /// <para>The ID of the parent group to which the group is added. If this parameter is specified, the system automatically adds the group to the specified parent group after the group is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e43ec8427dd45f19431b7504649a1b3</para>
        /// </summary>
        [NameInMap("parent_group_id")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

    }

}
