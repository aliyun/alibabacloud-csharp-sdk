// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DeleteInvoiceEntityRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<DeleteInvoiceEntityRequestEntities> Entities { get; set; }
        public class DeleteInvoiceEntityRequestEntities : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
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
