// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RevokeResourcePermissionRequest : TeaModel {
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
        /// <para>The authorization revocation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RevokeCommand")]
        [Validation(Required=false)]
        public RevokeResourcePermissionRequestRevokeCommand RevokeCommand { get; set; }
        public class RevokeResourcePermissionRequestRevokeCommand : TeaModel {
            /// <summary>
            /// <para>The list of operations.</para>
            /// </summary>
            [NameInMap("OperateList")]
            [Validation(Required=false)]
            public List<string> OperateList { get; set; }

            /// <summary>
            /// <para>The reason for revoking the authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The list of resources.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<RevokeResourcePermissionRequestRevokeCommandResourceList> ResourceList { get; set; }
            public class RevokeResourcePermissionRequestRevokeCommandResourceList : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.300002102.beginner_test.amin_table</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHYSICAL_TABLE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13131</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
