// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EntityAddRequest : TeaModel {
        /// <summary>
        /// <para>The list of employee, department, or role information.</para>
        /// </summary>
        [NameInMap("entity_d_o_list")]
        [Validation(Required=false)]
        public List<EntityAddRequestEntityDOList> EntityDOList { get; set; }
        public class EntityAddRequestEntityDOList : TeaModel {
            /// <summary>
            /// <para>The ID of the employee, department, role, or third-party department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The type of the available scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: employee</description></item>
            /// <item><description>2: department</description></item>
            /// <item><description>3: role</description></item>
            /// <item><description>4: third-party department</description></item>
            /// </list>
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
        /// <para>340049</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

    }

}
