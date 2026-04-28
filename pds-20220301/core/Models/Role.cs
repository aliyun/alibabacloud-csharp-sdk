// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Role : TeaModel {
        /// <summary>
        /// <para>The time when the role was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703648502811</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a23***</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description of the role.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the resource on which the role has permissions. Valid value: RT_File.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RT_File</para>
        /// </summary>
        [NameInMap("manage_resource_type")]
        [Validation(Required=false)]
        public string ManageResourceType { get; set; }

        /// <summary>
        /// <para>The name of the role.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<Permission> Permissions { get; set; }

        /// <summary>
        /// <para>The ID of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f2a***</para>
        /// </summary>
        [NameInMap("role_id")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The status of the role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the role was modified. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1703648502811</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
