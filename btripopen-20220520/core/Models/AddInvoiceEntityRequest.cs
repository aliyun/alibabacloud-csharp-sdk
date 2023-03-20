// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddInvoiceEntityRequest : TeaModel {
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<AddInvoiceEntityRequestEntities> Entities { get; set; }
        public class AddInvoiceEntityRequestEntities : TeaModel {
            [NameInMap("entity_id")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entity_name")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("entity_type")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

        }

        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
