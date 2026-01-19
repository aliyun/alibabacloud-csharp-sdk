// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationRoleResponseBody : TeaModel {
        [NameInMap("ApplicationRole")]
        [Validation(Required=false)]
        public GetApplicationRoleResponseBodyApplicationRole ApplicationRole { get; set; }
        public class GetApplicationRoleResponseBodyApplicationRole : TeaModel {
            /// <summary>
            /// <para>应用唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>应用角色的唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>approle_01kh2vuo8v9splv8maak1d22rxxxx</para>
            /// </summary>
            [NameInMap("ApplicationRoleId")]
            [Validation(Required=false)]
            public string ApplicationRoleId { get; set; }

            /// <summary>
            /// <para>应用角色名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>Admin Role</para>
            /// </summary>
            [NameInMap("ApplicationRoleName")]
            [Validation(Required=false)]
            public string ApplicationRoleName { get; set; }

            /// <summary>
            /// <para>应用角色值</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin_role</para>
            /// </summary>
            [NameInMap("ApplicationRoleValue")]
            [Validation(Required=false)]
            public string ApplicationRoleValue { get; set; }

            /// <summary>
            /// <para>应用角色描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>Admin Role Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>EIAM 实例唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
