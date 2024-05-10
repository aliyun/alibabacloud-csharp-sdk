// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleDeleteRequest : TeaModel {
        [NameInMap("del_all")]
        [Validation(Required=false)]
        public bool? DelAll { get; set; }

        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleDeleteRequestEntities> Entities { get; set; }
        public class InvoiceRuleDeleteRequestEntities : TeaModel {
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

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
