// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddProjectMemberRequest : TeaModel {
        /// <summary>
        /// <para>The command to add members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddProjectMemberRequestAddCommand AddCommand { get; set; }
        public class AddProjectMemberRequestAddCommand : TeaModel {
            /// <summary>
            /// <para>The environment identifier. Valid values: DEV and PROD.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The user members.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<AddProjectMemberRequestAddCommandUserList> UserList { get; set; }
            public class AddProjectMemberRequestAddCommandUserList : TeaModel {
                /// <summary>
                /// <para>The list of role codes for members. System and custom project roles are supported and can be obtained from ListProjectRoles. Only one role is supported. If this parameter is not empty, it takes precedence over RoleList. You must specify at least one of RoleList and RoleCodeList.</para>
                /// </summary>
                [NameInMap("RoleCodeList")]
                [Validation(Required=false)]
                public List<string> RoleCodeList { get; set; }

                /// <summary>
                /// <para>The member role. Valid values: 1 (Project administrator), 2 (Developer), 3 (Guest), 4 (Analyst), and 5 (O&amp;M engineer).</para>
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public List<int?> RoleList { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>711833</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
