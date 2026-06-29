// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GrantResourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The grant request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GrantCommand")]
        [Validation(Required=false)]
        public GrantResourcePermissionRequestGrantCommand GrantCommand { get; set; }
        public class GrantResourcePermissionRequestGrantCommand : TeaModel {
            /// <summary>
            /// <para>The expiration timestamp, in milliseconds.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("EffectiveEnd")]
            [Validation(Required=false)]
            public string EffectiveEnd { get; set; }

            /// <summary>
            /// <para>The operation types.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("OperateList")]
            [Validation(Required=false)]
            public List<string> OperateList { get; set; }

            /// <summary>
            /// <para>The reason for the authorization.</para>
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
            public List<GrantResourcePermissionRequestGrantCommandResourceList> ResourceList { get; set; }
            public class GrantResourcePermissionRequestGrantCommandResourceList : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hadoop.300000806.data_distill.behavior_gameinfor_01</para>
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
            /// <para>The authorized users pending authorization.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

        }

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

    }

}
