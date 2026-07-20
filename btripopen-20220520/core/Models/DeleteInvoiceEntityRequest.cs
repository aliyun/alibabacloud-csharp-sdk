// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DeleteInvoiceEntityRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all applicable personnel. If del_all is set to true, all entities under the invoice header are deleted, and the entity list parameter is not validated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        /// <summary>
        /// <para>The entity list. This parameter is required when del_all is set to false or null.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<DeleteInvoiceEntityRequestEntities> Entities { get; set; }
        public class DeleteInvoiceEntityRequestEntities : TeaModel {
            /// <summary>
            /// <para>The entity ID, which can be a personnel ID, department ID, role ID, or third-party department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values:</para>
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
        /// <para>The third-party invoice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340049</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
