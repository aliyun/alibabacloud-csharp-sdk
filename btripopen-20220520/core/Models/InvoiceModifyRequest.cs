// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceModifyRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("bank_name")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        [NameInMap("bank_no")]
        [Validation(Required=false)]
        public string BankNo { get; set; }

        [NameInMap("tax_no")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        [NameInMap("tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("unit_type")]
        [Validation(Required=false)]
        public int? UnitType { get; set; }

    }

}
