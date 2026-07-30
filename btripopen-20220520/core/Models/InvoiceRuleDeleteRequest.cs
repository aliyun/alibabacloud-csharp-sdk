// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleDeleteRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete all applicable entities. When del_all is set to true, all entities under the invoice title are deleted, and the entity list parameter is not validated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        /// <summary>
        /// <para>Not required when del_all is set to true. Otherwise, this parameter is required.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleDeleteRequestEntities> Entities { get; set; }
        public class InvoiceRuleDeleteRequestEntities : TeaModel {
            /// <summary>
            /// <para>The entity ID, which can be an employee ID, department ID, role ID, or third-party department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The entity type of the available scope.</para>
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
