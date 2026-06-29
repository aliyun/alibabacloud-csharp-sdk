// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateProjectMemberRequest : TeaModel {
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
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateProjectMemberRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateProjectMemberRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The environment identifier.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The list of user members.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserList")]
            [Validation(Required=false)]
            public List<UpdateProjectMemberRequestUpdateCommandUserList> UserList { get; set; }
            public class UpdateProjectMemberRequestUpdateCommandUserList : TeaModel {
                /// <summary>
                /// <para>The member role. Valid values: 1: project administrator. 2: developer. 3: visitor. 4: analyst. 5: O&amp;M engineer.</para>
                /// <para>This parameter is required.</para>
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

    }

}
