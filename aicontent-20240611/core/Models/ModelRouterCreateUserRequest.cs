// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateUserRequest : TeaModel {
        /// <summary>
        /// <para>The department roles to assign to the user during creation. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("departmentRoles")]
        [Validation(Required=false)]
        public List<DepartmentRoleCmd> DepartmentRoles { get; set; }

        /// <summary>
        /// <para>The logon name. This parameter is required. The logon name can be the same as the phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("loginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        /// <summary>
        /// <para>The name. This parameter is required. The value must be 2 to 20 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>John</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phone number. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800000000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
