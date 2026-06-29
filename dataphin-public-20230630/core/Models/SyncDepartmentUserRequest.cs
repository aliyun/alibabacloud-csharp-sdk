// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SyncDepartmentUserRequest : TeaModel {
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
        /// <para>The request command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SyncDepartmentUserCommand")]
        [Validation(Required=false)]
        public SyncDepartmentUserRequestSyncDepartmentUserCommand SyncDepartmentUserCommand { get; set; }
        public class SyncDepartmentUserRequestSyncDepartmentUserCommand : TeaModel {
            /// <summary>
            /// <para>The mapping between users and their affiliated departments.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DeptUserMapping")]
            [Validation(Required=false)]
            public List<SyncDepartmentUserRequestSyncDepartmentUserCommandDeptUserMapping> DeptUserMapping { get; set; }
            public class SyncDepartmentUserRequestSyncDepartmentUserCommandDeptUserMapping : TeaModel {
                /// <summary>
                /// <para>The list of department IDs to which the user belongs. If this parameter is left empty, the user-department affiliation is deleted.</para>
                /// </summary>
                [NameInMap("DepartmentIdList")]
                [Validation(Required=false)]
                public List<string> DepartmentIdList { get; set; }

                /// <summary>
                /// <para>The user ID in the user system. This value is the unique identifier of the user.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000001</para>
                /// </summary>
                [NameInMap("SourceUserId")]
                [Validation(Required=false)]
                public string SourceUserId { get; set; }

            }

        }

    }

}
