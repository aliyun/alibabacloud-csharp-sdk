// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceRuleSaveRequest : TeaModel {
        [NameInMap("all_employe")]
        [Validation(Required=false)]
        public bool? AllEmploye { get; set; }

        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<InvoiceRuleSaveRequestEntities> Entities { get; set; }
        public class InvoiceRuleSaveRequestEntities : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

    }

}
