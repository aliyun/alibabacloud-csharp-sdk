// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SyncDepartmentRequest : TeaModel {
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
        [NameInMap("SyncDepartmentCommand")]
        [Validation(Required=false)]
        public SyncDepartmentRequestSyncDepartmentCommand SyncDepartmentCommand { get; set; }
        public class SyncDepartmentRequestSyncDepartmentCommand : TeaModel {
            /// <summary>
            /// <para>The department list (full organization tree).</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DepartmentList")]
            [Validation(Required=false)]
            public List<SyncDepartmentRequestSyncDepartmentCommandDepartmentList> DepartmentList { get; set; }
            public class SyncDepartmentRequestSyncDepartmentCommandDepartmentList : TeaModel {
                /// <summary>
                /// <para>The department ID (unique identifier of the department).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("DepartmentId")]
                [Validation(Required=false)]
                public string DepartmentId { get; set; }

                /// <summary>
                /// <para>The display name of the department.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>研发中心</para>
                /// </summary>
                [NameInMap("DepartmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                /// <summary>
                /// <para>The parent department ID (unique identifier of the parent department). Set to null if no parent department exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("ParentDepartmentId")]
                [Validation(Required=false)]
                public string ParentDepartmentId { get; set; }

            }

        }

    }

}
