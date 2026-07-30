// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityDeleteRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all members.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        /// <summary>
        /// <para>The list of members to delete. This parameter is not required when delAll is set to true.</para>
        /// </summary>
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public List<EntityDeleteRequestEntityDOList> EntityDOList { get; set; }
        public class EntityDeleteRequestEntityDOList : TeaModel {
            /// <summary>
            /// <para>The ID of the user, department, or role.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The type of the available scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: user</description></item>
            /// <item><description>2: department</description></item>
            /// <item><description>3: role</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the third-party cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
