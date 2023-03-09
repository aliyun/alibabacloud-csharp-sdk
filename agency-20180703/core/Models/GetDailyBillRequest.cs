// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetDailyBillRequest : TeaModel {
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

    }

}
