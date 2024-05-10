// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleAddRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleAddRequestEntities> Entities { get; set; }
        public class InvoiceRuleAddRequestEntities : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_name")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
